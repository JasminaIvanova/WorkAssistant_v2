using Micron;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{

 public partial class User_Tasks
 {
        public User_Tasks()
        {

        }
        public User_Tasks(string task_title, string task_description, string task_date, string task_time, int percent)
        {
            this.task_title = task_title;
            this.task_description = task_description;
            this.task_date = task_date;
            this.task_time = task_time;
            this.percentage = percent;
        }
        
        public int id {get; set;}
        [ForeignKey("Users")]
        public int user_id {get; set;}
        public Users Users { get; set; }
        public string task_title {get; set;}
        public string task_description {get; set;}
        public string task_time {get; set;}
        public string task_date {get; set;}
        public int percentage {get; set;}
 }
}
