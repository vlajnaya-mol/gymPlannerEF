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
    public partial class DayForm : Form
    {
        int dayId;

        //NewGymPlannerDataSet dataSet;

        //NewGymPlannerDataSetTableAdapters.QueryAdapter queryAdapter;
        //NewGymPlannerDataSetTableAdapters.DaysTableAdapter daysAdapter;
        //NewGymPlannerDataSetTableAdapters.WorkoutsTableAdapter workoutsAdapter;
        //NewGymPlannerDataSetTableAdapters.Workout_ExerciseTableAdapter workoutExerciseAdapter;
        //NewGymPlannerDataSetTableAdapters.Day_WorkoutTableAdapter dayWorkoutAdapter;
        //NewGymPlannerDataSetTableAdapters.WorkoutByDayAdapter workoutByDayAdapter;
        //NewGymPlannerDataSetTableAdapters.SetsTableAdapter setsAdapter;

        public DayForm(DateTime date, int dayId)
        {
            InitializeComponent();
            this.Text = date.ToShortDateString();
            this.dayId = dayId;
        }
        public DayForm(string date,int dayId)
        {
            InitializeComponent();
            this.Text = date;
            this.dayId = dayId;
        }

        private void DayForm_Load(object sender, EventArgs e)
        {
            //dataSet = new NewGymPlannerDataSet();
            //daysAdapter = new NewGymPlannerDataSetTableAdapters.DaysTableAdapter();
            //queryAdapter = new NewGymPlannerDataSetTableAdapters.QueryAdapter();
            //workoutsAdapter = new NewGymPlannerDataSetTableAdapters.WorkoutsTableAdapter();
            //workoutExerciseAdapter = new NewGymPlannerDataSetTableAdapters.Workout_ExerciseTableAdapter();
            //dayWorkoutAdapter = new NewGymPlannerDataSetTableAdapters.Day_WorkoutTableAdapter();
            //workoutByDayAdapter = new NewGymPlannerDataSetTableAdapters.WorkoutByDayAdapter();
            //setsAdapter = new NewGymPlannerDataSetTableAdapters.SetsTableAdapter();
            UpdateTreeView();
        }

        private void UpdateTreeView()
        {
            //PlanTreeView.Nodes.Clear();
            //DataTable ids = workoutByDayAdapter.GetData(dayId);
            //DayCommentRichTextBox.Text = daysAdapter.GetDataById(dayId).Rows[0]["Comment"].ToString();
            ////List<string> exerciseNames = new List<string>(table.Rows.Count);
            //foreach (DataRow idRow in ids.Rows)
            //{
            //    TreeNode exerciseNode = PlanTreeView.Nodes.Add(idRow["Name_Exercise"].ToString());
            //    exerciseNode.Tag = (idRow["ID_Workout"]);
            //    DataTable sets = setsAdapter.GetDataByWorkoutId((int)idRow["ID_Workout"]);
            //    foreach (DataRow setRow in sets.Rows)
            //    {
            //        exerciseNode.Nodes.Add(setRow["Num_Reps"].ToString() + " раз(и) по " + setRow["Weight"].ToString() + " кг");
            //    }
            //}
            //PlanTreeView.ExpandAll();
        }

        private void AddTrainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int workoutId = -1;
            //using (ExerciseChooseForm Window = new ExerciseChooseForm())
            //{
            //    if (Window.ShowDialog() == DialogResult.OK)
            //    {
            //        NewGymPlannerDataSet.WorkoutsRow workoutRow = dataSet.Workouts.AddWorkoutsRow(0);
            //        workoutsAdapter.Update(dataSet);

            //        NewGymPlannerDataSet.Workout_ExerciseRow workoutExerciseRow =
            //            dataSet.Workout_Exercise.NewWorkout_ExerciseRow();
            //        workoutId = workoutRow.ID_Workout;
            //        workoutExerciseRow.ID_Workout = workoutRow.ID_Workout;
            //        workoutExerciseRow.Name_Exercise = Window.exerciseName;
            //        dataSet.Workout_Exercise.AddWorkout_ExerciseRow(workoutExerciseRow);
            //        workoutExerciseAdapter.Update(dataSet);

            //        NewGymPlannerDataSet.Day_WorkoutRow dayWorkoutRow =
            //            dataSet.Day_Workout.NewDay_WorkoutRow();
            //        dayWorkoutRow.ID_Workout = workoutRow.ID_Workout;
            //        dayWorkoutRow.ID_Day = dayId;
            //        workoutExerciseRow.Name_Exercise = Window.exerciseName;
            //        dataSet.Day_Workout.AddDay_WorkoutRow(dayWorkoutRow);
            //        dayWorkoutAdapter.Update(dataSet);

            //        UpdateTreeView();
            //       // Window.Hide();
            //        using (EditSetsForm setsForm = new EditSetsForm(workoutId))
            //        {
            //            if (setsForm.ShowDialog() == DialogResult.OK)
            //            {
            //                UpdateTreeView();
            //            }
            //        }
            //    }
            //}
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
            if (node.Level == 1)
                node = node.Parent;
            int workoutId = (int)node.Tag;
            //queryAdapter.DeleteWorkout(workoutId);
            UpdateTreeView();
        }

        private void SaveCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //daysAdapter.Fill(dataSet.Days);
            //DataRow dr = dataSet.Days.Select("ID_Day=" + dayId).FirstOrDefault();
            //if (dr != null)
            //{
            //    dr["Comment"] = DayCommentRichTextBox.Text;
            //}
            //daysAdapter.Update(dataSet);
        }
    }
}
