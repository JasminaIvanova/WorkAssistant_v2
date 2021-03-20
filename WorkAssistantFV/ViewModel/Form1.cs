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
       
        Users user = new Users();
        public WorkAssistant()
        {
            InitializeComponent();
            bunifuFormDock1.SubscribeControlToDragEvents(bunifuGradientPanel1);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage1);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage2);

        }


      
        /// <summary>
        /// button to set the page sign in 
        /// </summary>
        public void bunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
        }
        /// <summary>
        /// sets page to sign up
        /// </summary>
        public void bunifuButton2_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(1);
        }

      

        /// <summary>
        /// create account and add it to database
        /// </summary>
        public void btnCreate_Click(object sender, EventArgs e)
        {
            using (var db = TestDbContext.GetConnection())
            {
                if (db.Users.Any(x => x.username == txtUsername.Text))
                {
                    MessageBox.Show("This username is already taken!");
                    return;
                }
                if (db.Users.Any(x => x.email == txtEmail.Text))
                {
                    MessageBox.Show("This email is already taken!");
                    return;
                }
               
            }
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
            using (var db = TestDbContext.GetConnection()) 
            {
                db.Users.Add(user);
                db.SaveChanges();
            }

         
            MessageBox.Show("Account succesfully created!");

            txtFirstName.Text = txtLastName.Text =txtPhone.Text= txtEmail.Text = txtUsername.Text = txtPassword.Text = txtPasswordConfirm.Text = txtCompany.Text = string.Empty;
            bunifuPages1.SetPage(0);
        }

        /// <summary>
        /// sign in 
        /// </summary>
        public void btnSignIn_Click(object sender, EventArgs e)
        {
            string pass = Program.CalculateMD5(txtPassword2.Text);
            using (var db = TestDbContext.GetConnection()) 
            {
                try
                {
                    var user = db.Users.Where(x => x.username == txtUsername2.Text).First();
                    if (user.password == pass) 
                    {
                        this.Visible = false;
                        var home = new Home(user);
                        home.ShowDialog();
                        this.Visible = true;
                    }
                   
                }
                catch { 
               
                    MessageBox.Show("Invalid username or password! Please try again!");
                    return;
                }
                
            }
            txtUsername2.Text = txtPassword2.Text = string.Empty;
        }

        /// <summary>
        /// close the window 
        /// </summary>
        public void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtCompany_TextChanged(object sender, EventArgs e)
        {

        }

        public void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }
        public void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        public void SignIn_Click(object sender, EventArgs e)
        {

        }

        public void bunifuTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
