using Data.Models;
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
    public partial class UserTask : UserControl
    {
        public UserTask(User_Tasks tasks)
        {
            InitializeComponent();
            bunifuLabel1.Text = $"{tasks.task_title}";
            textForTask.Text = $"{tasks.task_description}";
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCheckBox1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {

        }
    }
}
