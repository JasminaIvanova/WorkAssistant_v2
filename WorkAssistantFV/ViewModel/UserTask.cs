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
using WorkAssistantFV.ViewModel;

namespace WorkAssistantFV.ViewModel
{
    public partial class UserTask : UserControl
    {
        MicronDbContext micron = new MicronDbContext();
        int id = 0;
        public UserTask(User_Tasks tasks)
        {
            InitializeComponent();
            id = tasks.id;
            lblTitle.Text = $"{tasks.task_title}";
            txtForTask.Text = $"{tasks.task_description}";
            lblDate.Text = $"{tasks.task_date}";
            lblTime.Text = $"{tasks.task_time}";
        }
        

        public UserTask()
        {
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCheckBox1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
           
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            using (var db = TestDbContext.GetConnection()) 
            {
                User_Tasks task = db.User_Tasks.Where(x => x.id == id).First();
                db.User_Tasks.Remove(task);
                db.SaveChanges();
                lblTitle.Text = "Deleted";
                txtForTask.Text = "Deleted";
            }
            //User_Tasks task = micron.GetRecord<User_Tasks>($"SELECT * FROM user_tasks WHERE id = {id}");
            //micron.Delete<User_Tasks>(task);
           
        }

        private void UserTask_Load(object sender, EventArgs e)
        {

        }

        private void txtForTask_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
