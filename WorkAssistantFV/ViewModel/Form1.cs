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
            Company company = micron.GetRecord<Company>($"name_company='{txtCompany.Text}'");
            user = new Users()
            {
                first_name = txtFirstName.Text,
                last_name = txtLastName.Text,
                email = txtEmail.Text,
                username = txtUsername.Text,
                password = Program.CalculateMD5(txtPassword.Text),
                phone_number_contact = txtPhone.Text,
                company_name = txtCompany.Text
            };

            if (txtPasswordConfirm.Text != txtPassword.Text) 
            {
                MessageBox.Show("password does not match!");
                return;
            }

            if (String.IsNullOrEmpty(txtFirstName.Text)) 
            {
                MessageBox.Show("Please insert First name!");
                return;
            }
            if (String.IsNullOrEmpty(txtLastName.Text)) 
            {
                MessageBox.Show("Please insert last name!");
                return;
            }
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please insert password!");
                return;
            }
            if (String.IsNullOrEmpty(txtPasswordConfirm.Text))
            {
                MessageBox.Show("Please confirm your password!");
                return;
            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Please enter your email address!");
                return;
            }
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please insert username!");
                return;
            }

            List<Users> usersExisting = micron.GetRecords<Users>("SELECT username FROM users").ToList();
            List<Users> emailsExisting = micron.GetRecords<Users>("SELECT email FROM users").ToList();

            foreach (var username in usersExisting) 
            {
                if (username.username == txtUsername.Text) 
                {
                    MessageBox.Show("This username is already taken!");
                    return;
                }
            }

            foreach (var email in emailsExisting)
            {
                if (email.email == txtEmail.Text)
                {
                    MessageBox.Show("This email is already used!");
                    return;
                }
            }

            user = micron.Save(user);
            MessageBox.Show("Account succesfully created!");

            txtFirstName.Text = txtLastName.Text =txtPhone.Text= txtEmail.Text = txtUsername.Text = txtPassword.Text = txtPasswordConfirm.Text = txtCompany.Text = string.Empty;
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
            txtUsername2.Text = txtPassword2.Text = string.Empty;
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCompany_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
