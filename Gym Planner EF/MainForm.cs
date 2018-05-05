﻿using System;
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
    public partial class MainForm : Form
    {
        private bool searchExerciseChosen = false;
        private NewGymPlannerEntities ctx;
        private User user;
        public MainForm(User user)
        {
            this.user = user;
            InitializeComponent();
            if (this.user.isAdmin())
                ExercisesMenuStrip.Visible = true;
            else
                ExercisesMenuStrip.Visible = false;
            this.ctx = new NewGymPlannerEntities();
            this.ctx.Exercises.Load();
            this.exercisesBindingSource.DataSource = this.ctx.Exercises.Local.ToBindingList();
            MuscleGroupToolStripComboBox.ComboBox.DataSource = ctx.MuscleGroups.Select(g => g.Name).ToList();

            List<DateTime> dates = (from d in ctx.Days.Where(d => d.Users.Any(u => u.Login == user.Login) && d.Workouts.Count() > 0) select d.Date).ToList();
            Calendar.RemoveAllBoldedDates();
            foreach (DateTime date in dates)
            {
                Calendar.AddBoldedDate(date);
            }
            Calendar.UpdateBoldedDates();

            string muscleGroup = MuscleGroupToolStripComboBox.SelectedItem.ToString();
            List<string> exercises =
                (from ex in ctx.Exercises.Where(ex => ex.Workouts.Any(w => w.Days.Any(d => d.Users.Any(u => u.Login == user.Login)))
                 && ex.MuscleGroups.Any(mg => mg.Name == muscleGroup))
                 select ex.Name).ToList();

            this.UpdateChart(exercises);
        }

        private void CalendarDayClicked(object sender, DateRangeEventArgs e)
        {
            var day = ctx.Days.FirstOrDefault(d => d.Users.Any(u => u.Login == user.Login) && d.Date == e.Start.Date);
            int id = -1;
            if (day == null)
            {
                Days newDay = new Days
                {
                    Date = e.Start.Date,
                    Comment = ""
                };
                newDay.Users.Add(ctx.Users.FirstOrDefault(u => u.Login == user.Login));
                ctx.Days.Add(newDay);
                ctx.SaveChanges();
                day = newDay;

            }
            id = day.ID_Day;
            (new DayForm(e.Start.ToShortDateString(), id)).ShowDialog();
            List<DateTime> dates = (from d in ctx.Days.Where(d => d.Users.Any(u => u.Login == user.Login) && d.Workouts.Count() > 0) select d.Date).ToList();
            Calendar.RemoveAllBoldedDates();
            foreach (DateTime date in dates)
            {
                Calendar.AddBoldedDate(date);
            }
            Calendar.UpdateBoldedDates();
        }

        private void AddNewExerciseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewExerciseForm newExerciseForm = new NewExerciseForm();
            using (NewExerciseForm Window = new NewExerciseForm())
            {
                if (Window.ShowDialog() == DialogResult.OK)
                {
                    ctx.Exercises.Load();
                    this.exercisesBindingSource.DataSource = this.ctx.Exercises.Local.ToBindingList();
                }
            }
        }

        private void ChooseExToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string exerciseName;
            using (ExerciseChooseForm Window = new ExerciseChooseForm())
            {
                if (Window.ShowDialog() == DialogResult.OK)
                {
                    exerciseName = Window.exerciseName;
                }
                else
                    return;
            }
            List<string> exercises = new List<string>();
            exercises.Add(exerciseName);
            this.UpdateChart(exercises);
        }

        private void UpdateChart(List<string> exercises)
        {
            this.ExerciseStatisticChart.Series.Clear();
            try
            {
                foreach (string exerciseName in exercises)
                {
                    this.ExerciseStatisticChart.Series.Add(exerciseName);
                    var records = (from d in ctx.Days.Where(d => d.Users.Any(u => u.Login == user.Login) && d.Workouts.Any(w => w.Exercises.Any(ex => ex.Name == exerciseName)))
                                   group d by d.ID_Day into g
                                   select new
                                   {
                                       date = (from d in g select d.Date).FirstOrDefault(),
                                       record = (from w in (from day in g select day.Workouts.FirstOrDefault())
                                                 select w.Sets.Max(s => s.Weight)).Max()
                                   }).ToList();
                    this.ExerciseStatisticChart.Series[exerciseName].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    foreach (var record in records)
                        this.ExerciseStatisticChart.Series[exerciseName].Points.AddXY(record.date, record.record);

                }
                this.ExerciseStatisticChart.ChartAreas[0].AxisX.Title = "Час";
                this.ExerciseStatisticChart.ChartAreas[0].AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
                this.ExerciseStatisticChart.ChartAreas[0].AxisX.LabelStyle.Format = "dd-MM-yy";
                this.ExerciseStatisticChart.ChartAreas[0].AxisY.Title = "Вага";
                this.ExerciseStatisticChart.ChartAreas[0].AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void ExercisesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.ExercisesDataGridView.SelectedCells.Count != 0)
            {
                int rowIndex = this.ExercisesDataGridView.SelectedCells[0].RowIndex;
                this.ExerciseInfoLabel.Text = this.ExercisesDataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            }
        }

        private void MuscleGroupToolStripComboBox_Click(object sender, EventArgs e)
        {
            this.ctx = new NewGymPlannerEntities();

            if (!this.MuscleGroupToolStripComboBox.Selected)
                return;
            string muscleGroup = MuscleGroupToolStripComboBox.SelectedItem.ToString();

            List<string> exercises =
                (from ex in ctx.Exercises.Where(ex => ex.Workouts.Any(w => w.Days.Any(d => d.Users.Any(u => u.Login == user.Login)))
                 && ex.MuscleGroups.Any(mg => mg.Name == muscleGroup))
                 select ex.Name).ToList();

            this.UpdateChart(exercises);
        }

        private void RemoveExerciseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ex = ctx.Exercises.Where(x => x.Name == ExercisesDataGridView.CurrentCell.Value.ToString()).Select(x => x).FirstOrDefault();
            ctx.Exercises.Remove(ex);
            ctx.SaveChanges();
            ctx.Exercises.Load();
            this.exercisesBindingSource.DataSource = this.ctx.Exercises.Local.ToBindingList();
        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            this.ctx.Dispose();
            this.ctx = new NewGymPlannerEntities();
            this.ctx.Configuration.ProxyCreationEnabled = false;

            var query = (from day in this.ctx.Days select day);

            query = query.Where(d => d.Date.CompareTo(this.BeforeDateTimePicker.Value) <= 0 && d.Date.CompareTo(this.AfterDateTimePicker.Value) >= 0 && d.Workouts.Count() > 0);

            if (this.searchExerciseChosen)
                query = query.Where(d => d.Workouts.Any(w => w.Exercises.Any(ex => ex.Name == ExerciseNameLabel.Text)));

            if (this.RepsTextBox.Text != "")
                query = query.Where(d => d.Workouts.Any(w => w.Sets.Any(s => s.Num_Reps == Int32.Parse(RepsTextBox.Text) && (!this.searchExerciseChosen || w.Exercises.Any(ex => ex.Name == ExerciseNameLabel.Text)))));

            //if (this.minWeightTextBox.Text != "" || this.maxWeightTextBox.Text != "")
            //    query = query.Where(d => d.Workouts.Any(w => w.Sets.Any(s => (this.minWeightTextBox.Text != "" || Convert.ToDouble(s.Weight) >= Convert.ToDouble(minWeightTextBox.Text)) 
            //                        && (this.maxWeightTextBox.Text != "" || Convert.ToDouble(s.Weight) <= Convert.ToDouble(maxWeightTextBox.Text))
            //                        && (!this.searchExerciseChosen || w.Exercises.Any(ex => ex.Name == ExerciseNameLabel.Text)))));

            var bs = new BindingSource();
            bs.DataSource = query.Select(d => d.Date).ToList();
            this.DayListBox.DisplayMember = "Дні";
            this.DayListBox.ValueMember = "Дні";
            this.DayListBox.DataSource = bs;

            //try
            //{
            //    DataTable dataTable = findDays.GetData(Parser.ToNullableInt(RepsTextBox.Text),
            //    Parser.ToNullableDecimal(minWeightTextBox.Text), Parser.ToNullableDecimal(maxWeightTextBox.Text),
            //    user.Login, AfterDateTimePicker.Text, BeforeDateTimePicker.Text, ExerciseNameLabel.Text);
            //    this.DayListBox.DisplayMember = dataTable.Columns[0].ToString();
            //    this.DayListBox.ValueMember = dataTable.Columns[0].ToString();
            //    this.DayListBox.DataSource = dataTable;
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}
        }

        private void GetExerciseButton_Click(object sender, EventArgs e)
        {
            using (ExerciseChooseForm Window = new ExerciseChooseForm())
            {
                if (Window.ShowDialog() == DialogResult.OK)
                {
                    this.ExerciseNameLabel.Text = Window.exerciseName;
                    this.searchExerciseChosen = true;
                }
            }
        }

        private void DayListBox_DoubleClick(object sender, EventArgs e)
        {
            if (this.DayListBox.SelectedItems.Count == 1)
            {
                DateTime date = Convert.ToDateTime((DayListBox.SelectedItem));
                var day = (from d in ctx.Days.Where(d => d.Users.Any(u => u.Login == user.Login) && d.Date == date) select d).SingleOrDefault();
                DayForm dayForm = new DayForm(day.Date.ToString(), day.ID_Day);
                dayForm.Show();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ctx.Dispose();
        }
    }
}
