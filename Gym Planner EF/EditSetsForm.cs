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

        //NewGymPlannerDataSet dataSet;
        //NewGymPlannerDataSetTableAdapters.QueryAdapter queryAdapter;
        //NewGymPlannerDataSetTableAdapters.SetsTableAdapter setsAdapter;
        //NewGymPlannerDataSetTableAdapters.Workout_SetTableAdapter workoutSetAdapter;
        public EditSetsForm(int workoutId)
        {
            InitializeComponent();
            this.workoutId = workoutId;
            //dataSet = new NewGymPlannerDataSet();
            //queryAdapter = new NewGymPlannerDataSetTableAdapters.QueryAdapter();
            //setsAdapter = new NewGymPlannerDataSetTableAdapters.SetsTableAdapter();
            //workoutSetAdapter = new NewGymPlannerDataSetTableAdapters.Workout_SetTableAdapter();
            UpdateListView();
        }

        private void UpdateListView()
        {
            RepsListView.Items.Clear();
            //DataTable dt = setsAdapter.GetDataByWorkoutId(workoutId);
            //foreach (DataRow row in dt.Rows)
            //{
            //    RepsListView.Items.Add(new ListViewItem(new[] { row["Num_Reps"].ToString(), row["Weight"].ToString() })).Tag = row["ID_Set"];
            //}
        }

        private void AddSetButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    NewGymPlannerDataSet.SetsRow setsRow = dataSet.Sets.AddSetsRow(Int32.Parse(RepsTextBox.Text), Decimal.Parse(WeightTextBox.Text));
            //    setsAdapter.Update(dataSet);

            //    NewGymPlannerDataSet.Workout_SetRow workoutSetRow =
            //                dataSet.Workout_Set.NewWorkout_SetRow();
            //    workoutSetRow.ID_Workout = workoutId;
            //    workoutSetRow.ID_Set = setsRow.ID_Set;
            //    dataSet.Workout_Set.AddWorkout_SetRow(workoutSetRow);
            //    workoutSetAdapter.Update(dataSet);

            //    UpdateListView();
            //}
            //catch
            //{
            //    MessageBox.Show("Неправильний формат даних");
            //}
        }

        private void RemoveSetButton_Click(object sender, EventArgs e)
        {
            if (RepsListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Виберіть підхід");
                return;
            }
           // queryAdapter.DeleteSet((int)RepsListView.SelectedItems[0].Tag);
            UpdateListView();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
