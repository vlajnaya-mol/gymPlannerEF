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
    public partial class NewExerciseForm : Form
    {
        NewGymPlannerEntities ctx;
        public NewExerciseForm()
        {
            InitializeComponent();
            ctx = new NewGymPlannerEntities();
            ctx.MuscleGroups.Load();
            ChooseMuscleGroupComboBox.DataSource = ctx.MuscleGroups.Local.ToBindingList();
        }

        private void CreateExerciseButton_Click(object sender, EventArgs e)
        {
            if (!ctx.Exercises.Any(x => x.Name == ExerciseNameTextBox.Text))
            {
                Exercises exercise = new Exercises
                {
                    Name = ExerciseNameTextBox.Text,
                    Information = ExerciseInfoRichTextBox.Text
                };
                string group = ChooseMuscleGroupComboBox.GetItemText(ChooseMuscleGroupComboBox.SelectedItem);
                exercise.MuscleGroups.Add(ctx.MuscleGroups.FirstOrDefault(g => g.Name == group));
                ctx.Exercises.Add(exercise);
                ctx.SaveChanges();
                this.Close();
            }
            else { MessageBox.Show("Дана вправа вже існує"); }
        }

        private void NewExerciseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ctx.Dispose();
        }
    }
}
