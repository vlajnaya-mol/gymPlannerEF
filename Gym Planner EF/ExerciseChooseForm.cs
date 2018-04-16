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
        private DataTable listDataTable;
        public ExerciseChooseForm()
        {
            InitializeComponent();

            //try
            //{
            //    DataTable dataTable = this.exercisesNameTableAdapter.GetData();
            //    this.ExercisesListBox.DataSource = dataTable;
            //    this.ExercisesListBox.DisplayMember = dataTable.Columns[0].ToString();
            //    //this.ExercisesListBox.ValueMember = dataTable.Columns[0].ToString();
            //    this.listDataTable = dataTable;
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}
        }

        private void GetExerciseButton_Click(object sender, EventArgs e)
        {
            if (this.ExercisesListBox.SelectedItems.Count != 0)
            {
                this.exerciseName = ((DataRowView)this.ExercisesListBox.SelectedItem).Row.ItemArray[0].ToString();
                this.Close();
                return;
            }
            // короче цей код мав працювати коли рядків в списку не виділено, але чомусь навіть попри ClearSelected вони виділені))0

            //foreach (System.Data.DataRowView exercise in this.ExercisesListBox.Items)
            //    if (exercise[0].ToString() == this.ExerciseNameTextBox.Text)
            //    {
            //        this.exerciseName = this.ExerciseNameTextBox.Text;
            //        this.Close();
            //        return;
            //    }
            DialogResult = DialogResult.None;
            MessageBox.Show("\t\tТакої вправи немає!\n\r Будь ласка, виберіть зі списку, чи введіть правильну назву вправи! :)", "Помилка");
        }

        private void ExerciseNameTExtBox_TextChanged(object sender, EventArgs e)
        {
            this.ExercisesListBox.ClearSelected();
            DataTable newListDataTable = new DataTable();
            newListDataTable.Columns.Add(new DataColumn("Назва вправи"));
            foreach (DataRow row in this.listDataTable.Rows)
                if (((string)row[0]).ToLower().Contains(ExerciseNameTextBox.Text.ToLower()))
                {
                    var new_row = newListDataTable.NewRow();
                    new_row.ItemArray = row.ItemArray.Clone() as object[];
                    newListDataTable.Rows.Add(new_row);
                }
            this.ExercisesListBox.DataSource = newListDataTable;
            this.ExercisesListBox.DisplayMember = newListDataTable.Columns[0].ToString();
            //this.ExercisesListBox.ValueMember = "Name";//newListDataTable.Columns[0].ToString();
        }
    }
}
