using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***USER MODEL***/
  [Table("users")]
 public partial class Users : IMicron
 {
        [Primary]
        public Int32 id {get; set;}
        public string First_name {get; set;}
        public string Last_name {get; set;}
        public string Username {get; set;}
        public string Email {get; set;}
        public string Password {get; set;}
        public string Company_name {get; set;}
 }
}
