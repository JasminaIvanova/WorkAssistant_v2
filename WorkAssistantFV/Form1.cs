using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Micron;
using Data.Models;

namespace WorkAssistantFV
{
    public partial class WorkAssistant : Form
    {
        MicronDbContext micron = new MicronDbContext(); 
        public WorkAssistant()
        {
            InitializeComponent();
            bunifuFormDock1.SubscribeControlToDragEvents(bunifuGradientPanel1);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage1);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage2);

        }


        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(1);
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void SignIn_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Users user = micron.GetRecord<Users>($"username='{txtUsername.Text}' AND password = MD5('{txtPassword.Text}')");

            user = new Users()
            {
                First_name = txtFirstName.Text,
                Last_name = txtLastName.Text,
                Email = txtEmail.Text,
                Username = txtUsername.Text,
                Password = Program.CalculateMD5(txtPassword.Text),
                Company_name = txtCompany.Text
            };

            if (txtPasswordConfirm.Text != txtPassword.Text) 
            {
                MessageBox.Show("password does not match!");
                return;
            }

            if (txtFirstName.Text.Length == 0) 
            {
                MessageBox.Show("Please insert First name!");
                return;
            }
            if (txtLastName.Text.Length == 0) 
            {
                MessageBox.Show("Please insert last name!");
                return;
            }


            //if proverka za sushtestvuvasht username
            user = micron.Save(user);
            MessageBox.Show("Account succesfully created!");

            txtFirstName.Text = txtLastName.Text = txtEmail.Text = txtUsername.Text = txtPassword.Text = txtPasswordConfirm.Text = txtCompany.Text = string.Empty;
            bunifuPages1.SetPage(0);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Users user = micron.GetRecord<Users>($"username='{txtUsername2.Text}' AND password = MD5('{txtPassword2.Text}')");
            if (user == null) 
            {
                MessageBox.Show("Invalid username or password! Please try again!");
                return;
            }
            this.Visible = false;
            var home = new Home(user);
            home.ShowDialog();
            this.Visible = true;
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
