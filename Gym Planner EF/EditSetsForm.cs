using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Planner_EF
{
    public partial class EditSetsForm : Form
    {
        int workoutId;
        private NewGymPlannerEntities ctx;

        public EditSetsForm(int workoutId)
        {
            InitializeComponent();
            this.workoutId = workoutId;
            ctx = new NewGymPlannerEntities();
            UpdateListView();
        }

        private void UpdateListView()
        {
            RepsListView.Items.Clear();
            var sets = ctx.Sets.Where(s => s.Workouts.Any(w => w.ID_Workout == workoutId)); ;
            foreach (Sets set in sets)
            {
                RepsListView.Items.Add(new ListViewItem(new[] { set.Num_Reps.ToString(), set.Weight.ToString() })).Tag = set.ID_Set;
            }
        }

        private void AddSetButton_Click(object sender, EventArgs e)
        {
            try
            {
                Sets set = new Sets
                {
                    Num_Reps = Int32.Parse(RepsTextBox.Text),
                    Weight = Int32.Parse(WeightTextBox.Text)
                };
                set.Workouts.Add(ctx.Workouts.FirstOrDefault(w => w.ID_Workout == workoutId));
                ctx.Sets.Add(set);
                ctx.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Неправильний формат даних");
            }
            UpdateListView();
        }

        private void RemoveSetButton_Click(object sender, EventArgs e)
        {
            if (RepsListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Виберіть підхід");
                return;
            }
            int setId = (int)RepsListView.SelectedItems[0].Tag;
            ctx.Sets.Remove(ctx.Sets.FirstOrDefault(s => s.ID_Set == setId));
            ctx.SaveChanges();
            UpdateListView();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditSetsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ctx.Dispose();
        }
    }
}
