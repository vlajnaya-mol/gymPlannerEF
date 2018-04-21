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
    public partial class NewAccountForm : Form
    {
        NewGymPlannerEntities ctx;
        public NewAccountForm()
        {
            InitializeComponent();
            ctx = new NewGymPlannerEntities();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            if (!ctx.Users.Any(u => u.Login == LoginTextBox.Text)) {
                Users user = new Users()
                {
                    Login = LoginTextBox.Text,
                    Password = PassTextBox.Text,
                    Name = NameTextBox.Text
                };
                ctx.Users.Add(user);
                ctx.SaveChanges();
                this.Close();
            } else
            {
                MessageBox.Show("Користувач з таким логіном уже існує");
            }
            //if (QueryAdapter.CheckLoginExists(LoginTextBox.Text) == 0)
            //{
            //    newGymPlannerDataSet.Users.AddUsersRow(LoginTextBox.Text, PassTextBox.Text, NameTextBox.Text);
            //    usersTableAdapter.Update(newGymPlannerDataSet);
            //    this.Close();
            //}
            //else { MessageBox.Show("Користувач з таким логіном уже існує"); }
        }

        private void NewAccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ctx.Dispose();
        }
    }
}
