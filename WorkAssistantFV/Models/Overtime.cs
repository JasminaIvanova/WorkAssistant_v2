using Micron;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{

 public partial class Overtime

    {
        public Overtime()
        {

        }
        public Overtime(string description, string start, string end, string date)
        {
            this.short_description = description;
            this.start_time = start;
            this.end_time = end;
            this.overtime_date = date;
        }
        
        public int id {get; set;}
        [ForeignKey("Users")]
        public int user_id {get; set;}
        public Users Users { get; set; }
        public string short_description {get; set;}
        public string start_time {get; set;}
        public string end_time {get; set;}
        public string overtime_date {get; set;}
 }
}
