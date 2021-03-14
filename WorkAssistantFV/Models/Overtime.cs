using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***OVERTIME MODEL***/
  [Table("overtime")]
 public partial class Overtime : IMicron
 {
        [Primary]
        public Int32 id {get; set;}
        [Foreign(typeof(Users))]
        public Int32 user_id {get; set;}
        public String short_description {get; set;}
        public String start_time {get; set;}
        public String end_time {get; set;}
        public String overtime_date {get; set;}
 }
}
