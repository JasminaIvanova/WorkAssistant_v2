using Data.Models;
using Micron;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WorkAssistantFV.ViewModel;


namespace WorkAssistantFV
{
    public partial class Home : Form
    {       
        int valueForCircle = 0;
        string dateNow = DateTime.Now.ToString("yyyy/MM/dd");
        string timeNow = DateTime.Now.ToString("HH:mm");
        public Home(Users user)
        {
            InitializeComponent();
            lblName.Text = $"{user.username}";
            bunifuFormDock1.SubscribeControlToDragEvents(bunifuGradientPanel1);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage1);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage2);
        }

        public int Row { get; set; }
        public int Column { get; set; }

        /// <summary>
        /// button to sign out
        /// </summary>
        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// button to minimize the window
        /// </summary>
        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
     

        /// <summary>
        /// This method adds new task in database in user's account(when we click button "add")
        /// </summary>
        private void btnAddTasks_Click(object sender, EventArgs e)
        {
            valueForCircle = 0;

            if (taskTitleBox.Text == "")
            {
                MessageBox.Show("Plese enter title for your task!");
                return;
            }
            if (taskDescriptionBox.Text == "")
            {
                MessageBox.Show("Plese enter description for your task!");
                return;
            }
            if (taskDate.Text == "")
            {
                MessageBox.Show("Plese enter date for your task!");
                return;
            }
            if (taskTime.Text == "")
            {
                MessageBox.Show("Plese enter time for your task!");
                return;
            }
            if (percent.Text == "")
            {
                MessageBox.Show("Plese enter percentage for your task!");
                return;
            }
            using (var db = TestDbContext.GetConnection())
            {
                Users user = db.Users.First(x => x.username == lblName.Text);
                User_Tasks task = new User_Tasks()
                {
                    user_id = user.id,
                    task_title = taskTitleBox.Text,
                    task_description = taskDescriptionBox.Text,
                    task_date = taskDate.Text,
                    task_time = taskTime.Text,
                    percentage = int.Parse(percent.Text)
                };
                db.User_Tasks.Add(task);
                db.SaveChanges();
                circleValue(user);
    
                MessageBox.Show($"Task succesfully created!");

                taskTitleBox.Text = taskDescriptionBox.Text = taskDate.Text = taskTime.Text = percent.Text = string.Empty;
                Row = 0;
                Column = 0;
                addTask(task, tableLayoutPanel1);
                Row = 0;
                Column = 0;
                if (string.Compare(task.task_date, dateNow) == -1
                       || (string.Compare(task.task_time, timeNow) == -1
                       && string.Compare(task.task_date, dateNow) == 0))
                {
                    addTask(task, tableLayoutPanel2);
                }

            }
        }

        /// <summary>
        /// what is displayed when Home page is load(in different pages)
        /// </summary>
        private void Home_Load_1(object sender, EventArgs e)
        {
            using (var db = TestDbContext.GetConnection())
            {
                Users user = db.Users.First(x => x.username == lblName.Text);
                task_view(user);
                company_view(user);
                contacts_view(user);
                LoadData();
                overdue_view(user);
               
                
                //for (int i = 0; i < 100; i++)
                //{
                //    OvertimeTable.Rows.Add(new object[] { }); 
                //}

            }
       
        }
        /// <summary>
        /// add task in tableLayoutPanel
        /// </summary>
        public void addTask(User_Tasks tasks, TableLayoutPanel panel)
        {
            UserTask todo = new UserTask(tasks);
            todo.Dock = DockStyle.Fill;
            panel.Controls.Add(todo, Column, Row);
            Column += 1;
            if (Column == 2)
            {
                Row += 1;
                Column = 0;

            }
        }
        /// <summary>
        /// add contact in TableLayoutPanel
        /// </summary>
        public void addContact(Users user)
        {
            UserContacts contact = new UserContacts(user);
            contact.Dock = DockStyle.Fill;
            tableLayoutContact.Controls.Add(contact, Column, Row);
            Column += 1;
            if (Column == 3)
            {
                Row += 1;
                Column = 0;

            }

        }

        
        /// <summary>
        /// sets page to daily tasks when button is clicked 
        /// </summary>
        private void btnDaily_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
        }
        /// <summary>
        /// sets page to overdue when button is clicked
        /// </summary>
        private void btnOverdue_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(1);
        }
        /// <summary>
        /// sets page to contacts when button is clicked
        /// </summary>
        private void btnContacts_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(3);
        }
        /// <summary>
        /// sets page to overtime when button is clicked
        /// </summary>
        private void btnOvertime_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(2);
        }

 
        /// <summary>
        /// method for calculating the value for the circle progress bar
        /// </summary>
        public void circleValue(Users user)
        {
            using (var db = TestDbContext.GetConnection()) 
            {
                List<User_Tasks> tasksForUser = db.User_Tasks.Where(x => x.user_id == user.id).ToList(); 
                foreach (var task_one in tasksForUser)
                {
                    valueForCircle += task_one.percentage;
                }
                
                if (tasksForUser == null)
                {
                    circle.Value = 0;
                }
                else
                {
                    circle.Value = valueForCircle / tasksForUser.Count();
                }
                circle.PerformStep();
            }
               
           
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        ///display only the searched contact when button is clicked
        /// </summary>
        private void btnSearchContact_Click(object sender, EventArgs e)
        {
            using (var db = TestDbContext.GetConnection())
            {
                Users user = db.Users.First(x => x.username == lblName.Text);
                if (string.IsNullOrEmpty(boxSearch.Text))
                {
                    ClearTable(tableLayoutContact);                    
                    List<Users> user_contacts = db.Users.Where(x => x.company_name == user.company_name).ToList();
                    Row = 0;
                    Column = 0;
                    foreach (var contact_one in user_contacts)
                    {
                        addContact(contact_one);
                    }
                }
                else
                {
                    try
                    {
                       
                        Users searchedContact = db.Users.Where(x => x.company_name == user.company_name && x.first_name == boxSearch.Text || x.last_name == boxSearch.Text).First();
                        ClearTable(tableLayoutContact);
                        Row = 0;
                        Column = 0;
                        addContact(searchedContact);
                    }
                    catch
                    {
                        MessageBox.Show("This contact does not exists");
                    }
                }
            }
        }
        /// <summary>
        /// clears TableLayoutPanel
        /// </summary>
        public void ClearTable(TableLayoutPanel panel)
        {
            while (panel.Controls.Count > 0)
            {
                panel.Controls[0].Dispose();
            }
        }

        /// <summary>
        /// sets page to info when button is clicked
        /// </summary>
        private void btnInfo_Click(object sender, EventArgs e)
        { 
            bunifuPages1.SetPage(4);
        }

        /// <summary>
        /// loads the data from database to the table 
        /// </summary>
        public void LoadData()
        {
            using (var db = TestDbContext.GetConnection()) 
            {
                Users user = db.Users.First(x => x.username == lblName.Text);
                List<Overtime> over = db.Overtime.Where(x => x.user_id == user.id).ToList();
                OvertimeTable.Rows.Clear();
                foreach (var time in over)
                {
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(OvertimeTable);
                    newRow.Cells[3].Value = time.short_description;
                    newRow.Cells[0].Value = time.start_time;
                    newRow.Cells[1].Value = time.end_time;
                    newRow.Cells[2].Value = time.overtime_date;
                    OvertimeTable.Rows.Add(newRow);

                }
            }           
            
        }
        /// <summary>
        /// add overtime details to the database and then load the data to the table
        /// </summary>
        private void btnAddOvertime_Click(object sender, EventArgs e)
        {
            if (txtStartTime.Text == "")
            {
                MessageBox.Show("Plese enter start time for your overtime!");
                return;
            }
            if (txtEndTime.Text == "")
            {
                MessageBox.Show("Plese enter end time for your overtime!");
                return;
            }
            if (txtOvertimeDescription.Text == "")
            {
                MessageBox.Show("Plese enter description for your overtime!");
                return;
            }
            if (bunifuTextBox1.Text == "")
            {
                MessageBox.Show("Plese enter date for your overtime!");
                return;
            }
            using (var db = TestDbContext.GetConnection())
            {
                Overtime time = new Overtime();
                Users user = db.Users.First(x => x.username == lblName.Text);
                time = new Overtime()
                {
                    user_id = user.id,
                    start_time = txtStartTime.Text,
                    end_time = txtEndTime.Text,
                    short_description = txtOvertimeDescription.Text,
                    overtime_date = bunifuTextBox1.Text
                };
                db.Overtime.Add(time);
                db.SaveChanges();
            }

            MessageBox.Show($"Overtime data succesfully added!");

            txtStartTime.Text = txtEndTime.Text = txtOvertimeDescription.Text = bunifuTextBox1.Text = string.Empty;
            LoadData();
            

        }

        /// <summary>
        /// load data 
        /// </summary>
        private void Home_Shown(object sender, EventArgs e)
        {
            LoadData();
        }

        public void task_view(Users user) 
        {
            using (var db = TestDbContext.GetConnection()) 
            {
                List<User_Tasks> tasks = db.User_Tasks.Where(x => x.user_id == user.id).ToList();
                Row = 0;
                Column = 0;
                foreach (var task_one in tasks)
                {
                    addTask(task_one, tableLayoutPanel1);
                }
            }
                
        }
        public void overdue_view(Users user)
        {
            using (var db = TestDbContext.GetConnection())
            {
                Row = 0;
                Column = 0;
                List<User_Tasks> tasks = db.User_Tasks.Where(x => x.user_id == user.id).ToList();
                List<User_Tasks> task_new = new List<User_Tasks>();
                foreach (var task_one in tasks)
                {
                    if (string.Compare(task_one.task_date, dateNow) == -1
                        || (string.Compare(task_one.task_time, timeNow) == -1
                        && string.Compare(task_one.task_date, dateNow) == 0)) 
                    {
                        task_new.Add(task_one);
                        addTask(task_one, tableLayoutPanel2);
                    }
                }

            }

        }
        public void contacts_view(Users user)
        {
            using (var db = TestDbContext.GetConnection())
            {
                List<Users> user_contacts = db.Users.Where(x => x.company_name == user.company_name).ToList(); 
                Row = 0;
                Column = 0;
                foreach (var contact_one in user_contacts)
                {
                    addContact(contact_one);
                }
            }

        }
        public void company_view(Users user)
        {
            using (var db = TestDbContext.GetConnection())
            {

                Company company_info = db.Company.Where(x => x.name_company == user.company_name).First();
                lblCompanyName.Text = company_info.name_company;
                lblDateCreate.Text = $"Year of foundation:  {company_info.date_created}";
                lblAdress.Text = $" Headquartered at:  {company_info.adress_company}";
                lblOwner.Text = $" Owner:  {company_info.owner_company}";
                lblCEO.Text = $"Chief executive officer (CEO):  {company_info.CEO_company}";
                
            }

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
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void bunifuLabel1_Click_1(object sender, EventArgs e)
        {

        }
        private void circle_ProgressChanged(object sender, Bunifu.UI.WinForms.BunifuCircleProgress.ProgressChangedEventArgs e)
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
        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
