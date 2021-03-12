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
        public String first_name {get; set;}
        public String last_name {get; set;}
        public String username {get; set;}
        public String email {get; set;}
        public String password {get; set;}
        [Foreign(typeof(Company))]
        public Int32 company_id {get; set;}
        public String company_name {get; set;}
 }
}
