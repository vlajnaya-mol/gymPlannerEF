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
    public partial class ExerciseChooseForm : Form
    {
        public string exerciseName;
        private List<string> exercisesList;
        public ExerciseChooseForm()
        {
            InitializeComponent();
            NewGymPlannerEntities ctx = new NewGymPlannerEntities();
            ctx.Configuration.ProxyCreationEnabled = false;
            this.exercisesList = ctx.Exercises.Select(e => e.Name).ToList();
            this.ExercisesListBox.DataSource = this.exercisesList;
        }

        private void GetExerciseButton_Click(object sender, EventArgs e)
        {
            if (this.ExercisesListBox.SelectedItems.Count != 0)
            {
                this.exerciseName = this.ExercisesListBox.SelectedItems[0].ToString();//((DataRowView)this.ExercisesListBox.SelectedItem).Row.ItemArray[0].ToString();
                this.Close();
                return;
            }
            if (this.ExercisesListBox.Items.Count == 1)
            {
                this.exerciseName = this.ExercisesListBox.Items[0].ToString();//((DataRowView)this.ExercisesListBox.SelectedItem).Row.ItemArray[0].ToString();
                this.Close();
                return;
            }
            MessageBox.Show("\t\tТакої вправи немає!\n\r Будь ласка, виберіть зі списку, чи введіть правильну назву вправи! :)", "Помилка");
        }

        private void ExerciseNameTExtBox_TextChanged(object sender, EventArgs e)
        {
            this.ExercisesListBox.ClearSelected();
            this.ExercisesListBox.DataSource = this.exercisesList.Where(ex => ex.ToLower().Contains(ExerciseNameTextBox.Text.ToLower())).ToList();
        }
    }
}
