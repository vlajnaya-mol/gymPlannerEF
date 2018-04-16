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
    public partial class NewExerciseForm : Form
    {
        //NewGymPlannerDataSetTableAdapters.ExercisesTableAdapter exercisesTableAdapter;
        //NewGymPlannerDataSetTableAdapters.Exercise_MuscleGroupTableAdapter exerciseGroupAdapter;
        //NewGymPlannerDataSetTableAdapters.QueryAdapter queryAdapter;
        public NewExerciseForm()
        {
            InitializeComponent();
            //exercisesTableAdapter = new NewGymPlannerDataSetTableAdapters.ExercisesTableAdapter();
            //exerciseGroupAdapter = new NewGymPlannerDataSetTableAdapters.Exercise_MuscleGroupTableAdapter();
            //queryAdapter = new NewGymPlannerDataSetTableAdapters.QueryAdapter();
        }

        private void NewExerciseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newGymPlannerDataSet.MuscleGroups' table. You can move, or remove it, as needed.
            //this.muscleGroupsTableAdapter.Fill(this.newGymPlannerDataSet.MuscleGroups);

        }

        private void CreateExerciseButton_Click(object sender, EventArgs e)
        {
            //if (queryAdapter.CheckExerciseExists(ExerciseNameTextBox.Text) == 0)
            //{
            //    newGymPlannerDataSet.Exercises.AddExercisesRow(ExerciseNameTextBox.Text, ExerciseInfoRichTextBox.Text);
            //    NewGymPlannerDataSet.Exercise_MuscleGroupRow egRow = newGymPlannerDataSet.Exercise_MuscleGroup.NewExercise_MuscleGroupRow();
            //    egRow.Name_Exercise = ExerciseNameTextBox.Text;
            //    egRow.Name_MuscleGroup = ChooseMuscleGroupComboBox.GetItemText(ChooseMuscleGroupComboBox.SelectedItem);
            //    newGymPlannerDataSet.Exercise_MuscleGroup.Rows.Add(egRow);
            //    exercisesTableAdapter.Update(newGymPlannerDataSet);
            //    exerciseGroupAdapter.Update(newGymPlannerDataSet);
            //    this.Close();
            //}
            //else { MessageBox.Show("Дана вправа вже існує"); }
        }
    }
}
