using Data.Models;
using Micron;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkAssistantFV.ViewModel
{
    public partial class UserContacts : UserControl
    {
        public UserContacts(Users user)
        {
            InitializeComponent();
            lblFirstName.Text = $"{user.first_name}";
            lblLastName.Text = $"{user.last_name}";
            lblEmail.Text = $"{user.email}";
            lblPhone.Text = $"{user.phone_number_contact}";

        }

        public UserContacts()
        {
        }

        private void txtForTask_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

    
    }
}
