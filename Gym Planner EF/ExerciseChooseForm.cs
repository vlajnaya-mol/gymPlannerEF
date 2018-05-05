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
    public partial class ExerciseChooseForm : Form
    {
        NewGymPlannerEntities ctx;
        public string exerciseName;
        private List<string> exercisesList;
        public ExerciseChooseForm()
        {
            ctx = new NewGymPlannerEntities();
            ctx.MuscleGroups.Load();
            InitializeComponent();
            ctx.Configuration.ProxyCreationEnabled = false;
            this.exercisesList = ctx.Exercises.Select(e => e.Name).ToList();
            this.ExercisesListBox.DataSource = this.exercisesList;
            var groups = ctx.MuscleGroups.Local.ToBindingList();
            ChooseMuscleGroupComboBox.Items.Add("Всі");
            foreach (var group in groups)
            {
                ChooseMuscleGroupComboBox.Items.Add(group.Name);
            }
            ChooseMuscleGroupComboBox.SelectedIndex = 0;
        }

        private void GetExerciseButton_Click(object sender, EventArgs e)
        {
            if (this.ExercisesListBox.SelectedItems.Count != 0)
            {
                this.exerciseName = this.ExercisesListBox.SelectedItems[0].ToString();
                this.Close();
                return;
            }
            if (this.ExercisesListBox.Items.Count == 1)
            {
                this.exerciseName = this.ExercisesListBox.Items[0].ToString();
                this.Close();
                return;
            }
            MessageBox.Show("\t\tТакої вправи немає!\n\r Будь ласка, виберіть зі списку, чи введіть правильну назву вправи! :)", "Помилка");
        }

        private void ExerciseNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.ExercisesListBox.ClearSelected();
            string group = ChooseMuscleGroupComboBox.GetItemText(ChooseMuscleGroupComboBox.SelectedItem);
            if (group == "")
                return;
            if (group == "Всі")
            {
                this.ExercisesListBox.DataSource = exercisesList.Where(ex => ex.ToLower()
                .Contains(ExerciseNameTextBox.Text.ToLower())).ToList();
            }
            else
            {
                var muscleGroup = ctx.MuscleGroups.FirstOrDefault(g => g.Name == group);
                this.ExercisesListBox.DataSource = ctx.MuscleGroups.FirstOrDefault(g => g.Name == group)
                    .Exercises.Select(ex => ex.Name).Where(ex => ex.ToLower()
                    .Contains(ExerciseNameTextBox.Text.ToLower())).ToList();
            }
        }

        private void ExerciseChooseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ctx.Dispose();
        }

        private void ChooseMuscleGroupComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            this.ExercisesListBox.ClearSelected();
            string group = ChooseMuscleGroupComboBox.GetItemText(ChooseMuscleGroupComboBox.SelectedItem);
            if (group == "")
                return;
            if (group == "Всі")
            {
                this.ExercisesListBox.DataSource = exercisesList.Where(ex => ex.ToLower()
                .Contains(ExerciseNameTextBox.Text.ToLower())).ToList();
            }
            else
            {
                var muscleGroup = ctx.MuscleGroups.FirstOrDefault(g => g.Name == group);
                this.ExercisesListBox.DataSource = ctx.MuscleGroups.FirstOrDefault(g => g.Name == group)
                    .Exercises.Select(ex => ex.Name).Where(ex => ex.ToLower()
                    .Contains(ExerciseNameTextBox.Text.ToLower())).ToList();
            }
        }
    }
}
