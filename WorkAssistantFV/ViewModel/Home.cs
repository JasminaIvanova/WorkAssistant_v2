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

namespace WorkAssistantFV
{
    public partial class Home : Form
    {
        MicronDbContext micron = new MicronDbContext();
        public Home(Users user)
        {
            InitializeComponent();
            lblName.Text = $"Hello, {user.first_name}!";
            bunifuFormDock1.SubscribeControlToDragEvents(bunifuGradientPanel1);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage1);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage2);
        }

      

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
        }

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(1);
        }

        private void bunifuFormDock1_FormDragging(object sender, Bunifu.UI.WinForms.BunifuFormDock.FormDraggingEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCircleProgress1_ProgressChanged(object sender, Bunifu.UI.WinForms.BunifuCircleProgress.ProgressChangedEventArgs e)
        {
            //done tasks*100/all tasks- primerno
           //neshto.Value   = 
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

        public void addItem(string text) 
        {

        }
        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            
            User_Tasks task = micron.GetRecord<User_Tasks>($"task_title='{taskTitleBox.Text}' AND task_description = '{taskDescriptionBox.Text}' AND task_time = '{timePicker.Value.TimeOfDay}' AND percentage = '{int.Parse(perecnt.Value.ToString())}'");

          //  datePicker.CustomFormat = "yyyy-MM-dd";
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.CustomFormat = "HH:mm:ss";

            task = new User_Tasks()
            {
                task_title = taskTitleBox.Text,
                task_description = taskDescriptionBox.Text,
                //task_date = datePicker.Value.Date,
                task_time = timePicker.Value.TimeOfDay,
                percentage = int.Parse(perecnt.Value.ToString())
                //Customer customer = micron.GetRecord<Customer>("SELECT * FROM CUSTOMERS WHERE Id=1");
            };

            task = micron.Save<User_Tasks>(task);
            MessageBox.Show($"Task succesfully created! {timePicker.Value.TimeOfDay} {int.Parse(perecnt.Value.ToString())}");

           // taskTitleBox.Text = taskDescriptionBox.Text = dateTimePicker1.Text = dateTimePicker2.Text = string.Empty;
          
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void taskDescriptionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void taskTitleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
