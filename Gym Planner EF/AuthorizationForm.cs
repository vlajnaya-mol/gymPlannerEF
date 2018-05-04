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
    public partial class AuthorizationForm : Form
    {
        NewGymPlannerEntities ctx;
        public AuthorizationForm()
        {
            InitializeComponent();
            ctx = new NewGymPlannerEntities();
            ctx.Users.Load();
            this.LoginTextBox.Text = "admin";
            this.PassTextBox.Text = "admin";
            this.PassTextBox.UseSystemPasswordChar = true;
        }

        private void NewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewAccountForm newAccountForm = new NewAccountForm();
            newAccountForm.Show();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (ctx.Users.Any(u => u.Login == LoginTextBox.Text && u.Password == PassTextBox.Text))
            {
                User user = new User(this.LoginTextBox.Text, this.PassTextBox.Text, "TODO");
                this.Hide();
                using (MainForm mainForm = new MainForm(user))
                {
                    if (mainForm.ShowDialog() == DialogResult.OK)
                        this.Show();
                    else
                        this.Close();
                }
            }
            else
            {
                MessageBox.Show("Неправильний логін чи пароль! Спробуйте ще раз!", "Помилка!");
            }
        }

        private void AuthorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ctx.Dispose();
        }
    }
}
