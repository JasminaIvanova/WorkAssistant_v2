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

namespace WorkAssistantFV
{
    public partial class Home : Form
    {
        MicronDbContext micron = new MicronDbContext();
        public Home(Users user)
        {
            InitializeComponent();
            lblName.Text = $"{user.username}";
            bunifuFormDock1.SubscribeControlToDragEvents(bunifuGradientPanel1);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage1);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage2);
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFormDock1_FormDragging(object sender, Bunifu.UI.WinForms.BunifuFormDock.FormDraggingEventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }


        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        
        private void taskDescriptionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void taskTitleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void taskTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void taskDate_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnAddTasks_Click(object sender, EventArgs e)
        {
            User_Tasks task = micron.GetRecord<User_Tasks>($"task_title='{taskTitleBox.Text}' AND task_description = '{taskDescriptionBox.Text}'");

            Users user = micron.GetRecord<Users>($"SELECT id FROM users WHERE username='{lblName.Text}'");

            task = new User_Tasks()
            {
                user_id = user.id,
                task_title = taskTitleBox.Text,
                task_description = taskDescriptionBox.Text,
                task_date = taskDate.Text,
                task_time = taskTime.Text,
                percentage = int.Parse(percent.Text)
            };

            if (taskTitleBox.Text.Length == 0 || taskTitleBox == null) 
            {
                MessageBox.Show("Plese enter title for your task!");
                return;
            }
            if (taskDescriptionBox.Text.Length == 0 || taskDescriptionBox == null)
            {
                MessageBox.Show("Plese enter description for your task!");
                return;
            }
            if (taskDate.Text.Length == 0  || taskDate == null)
            {
                MessageBox.Show("Plese enter date for your task!");
                return;
            }
            if (taskTime.Text.Length == 0 || taskTime == null)
            {
                MessageBox.Show("Plese enter time for your task!");
                return;
            }
            if (percent.Text.Length == 0 || percent == null)
            {
                MessageBox.Show("Plese enter percentage for your task!");
                return;
            }

            task = micron.Save<User_Tasks>(task);
            MessageBox.Show($"Task succesfully created!");

            taskTitleBox.Text = taskDescriptionBox.Text = taskDate.Text = taskTime.Text = percent.Text = string.Empty;
            addTask(task);
            

        }
        public int Row { get; set; }
        public int Column { get; set; }

        private void Home_Load_1(object sender, EventArgs e)
        {
            
            Users user = micron.GetRecord<Users>($"SELECT id FROM users WHERE username ='{lblName.Text}'");
            Row = 0;
            Column = 0;
            List<User_Tasks> task = micron.GetRecords<User_Tasks>($"SELECT * FROM user_tasks WHERE user_id = '{user.id}'").ToList();
            foreach (var task_one in task)
            {
                addTask(task_one);
                
            }
            

        }
        public void addTask(User_Tasks tasks)
        {
            UserTask todo = new UserTask(tasks);
            todo.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(todo, Row, Column);
            Column += 1;
            if (Column == 2) 
            {
                Row += 1;
                Column = 0;

            }
        }

        private void bunifuLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void circle_ProgressChanged(object sender, Bunifu.UI.WinForms.BunifuCircleProgress.ProgressChangedEventArgs e)
        {
            
        }

        private void btnDaily_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
        }


        private void btnOverdue_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(1);
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(2);
        }
    }
}
