using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***COMPANY_USER MODEL***/
  [Table("company_users")]
 public partial class Company_User : IMicron
 {
        [Foreign(typeof(Company))]
        public Int32 company_id {get; set;}
        [Foreign(typeof(Users))]
        public Int32 user_id {get; set;}
        public String first_name_contact {get; set;}
        public String last_name_contact {get; set;}
        public String phone_number_contact {get; set;}
        public String e_mail_contact {get; set;}
 }
}
