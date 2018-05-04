using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Planner_EF
{
    public partial class DayForm : Form
    {
        private NewGymPlannerEntities ctx;
        int dayId;

        public DayForm(string date, int dayId)
        {
            InitializeComponent();
            this.Text = date;
            this.dayId = dayId;
            ctx = new NewGymPlannerEntities();
        }

        private void DayForm_Load(object sender, EventArgs e)
        {
            UpdateTreeView();
        }

        private void UpdateTreeView()
        {
            ctx.Dispose();
            ctx = new NewGymPlannerEntities();
            PlanTreeView.Nodes.Clear();
            var workouts = (from d in ctx.Days.Where(d => d.ID_Day == dayId) select d).SingleOrDefault().Workouts;
            DayCommentRichTextBox.Text = (from d in ctx.Days.Where(d => d.ID_Day == dayId)
                                          select d).SingleOrDefault().Comment.ToString();
            foreach (Workouts workout in workouts)
            {
                TreeNode exerciseNode = PlanTreeView.Nodes.Add(workout.Exercises.SingleOrDefault().Name);
                exerciseNode.Tag = (workout.ID_Workout);
                var sets = (from w in ctx.Workouts.Where(w => w.ID_Workout == workout.ID_Workout) select w).SingleOrDefault().Sets;
                foreach (Sets set in sets)
                {
                    exerciseNode.Nodes.Add(set.Num_Reps + " раз(и) по " + set.Weight + " кг");
                }
            }
            PlanTreeView.ExpandAll();
        }

        private void AddTrainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ExerciseChooseForm Window = new ExerciseChooseForm())
            {
                if (Window.ShowDialog() == DialogResult.OK)
                {
                    Workouts workout = new Workouts
                    {
                        Num_Sets = 0
                    };
                    workout.Exercises.Add(ctx.Exercises.FirstOrDefault(ex => ex.Name == Window.exerciseName));
                    workout.Days.Add(ctx.Days.FirstOrDefault(d => d.ID_Day == dayId));
                    ctx.Workouts.Add(workout);
                    ctx.SaveChanges();
                    UpdateTreeView();
                    (new EditSetsForm(workout.ID_Workout)).ShowDialog();
                    UpdateTreeView();
                }
            }
        }

        private void ChangeTrainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = PlanTreeView.SelectedNode;
            if (node == null)
            {
                MessageBox.Show("Виберіть тренування для зміни");
                return;
            }
            if (node.Level == 1)
                node = node.Parent;
            int workoutId = (int)node.Tag;
            using (EditSetsForm Window = new EditSetsForm(workoutId))
            {
                if (Window.ShowDialog() == DialogResult.OK)
                {
                    UpdateTreeView();
                }
            }
        }

        private void RemoveTrainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = PlanTreeView.SelectedNode;
            if (node == null)
            {
                MessageBox.Show("Виберіть тренування для видалення");
                return;
            }
            DialogResult result = MessageBox.Show("Ви дійсно бажаєте видалити тренування?", "Видалення тренування", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            if (node.Level == 1)
                node = node.Parent;
            int workoutId = (int)node.Tag;
            ctx.Workouts.Remove(ctx.Workouts.FirstOrDefault(w => w.ID_Workout == workoutId));
            ctx.SaveChanges();
            UpdateTreeView();
        }

        private void SaveCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ctx.Days.FirstOrDefault(d => d.ID_Day == dayId).Comment = DayCommentRichTextBox.Text;
            ctx.SaveChanges();
        }

        private void DayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ctx.Dispose();
        }
    }
}
