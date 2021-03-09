using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***USER_TASK MODEL***/
  [Table("user_tasks")]
 public partial class User_Tasks : IMicron
 {
        [Primary]
        public Int32 id {get; set;}
        [Foreign(typeof(Users))]
        public Int32 user_id {get; set;}
        public String task_title {get; set;}
        public String task_description {get; set;}
        public TimeSpan task_time {get; set;}
        public Int32 percentage {get; set;}
 }
}
