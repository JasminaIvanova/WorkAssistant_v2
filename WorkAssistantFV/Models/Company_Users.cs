using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***COMPANY_USER MODEL***/
  [Table("company_users")]
 public partial class Company_Users : IMicron
 {
        [Foreign(typeof(Company))]
        public Int32 company_id {get; set;}
        [Foreign(typeof(Users))]
        public Int32 user_id {get; set;}
 }
}
