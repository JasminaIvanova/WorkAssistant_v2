using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{

 public partial class Users:IMicron
 {
        public Users()
        {

        }
        public Users(string first_name, string last_name, string username, string email, string password, string phone, string company)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.username = username;
            this.email = email;
            this.password = password;
            this.phone_number_contact = phone;
            this.company_name = company;

        }
        public int id {get; set;}
        public string first_name {get; set;}
        public string last_name {get; set;}
        public string username {get; set;}
        public string email {get; set;}
        public string password {get; set;}
        public string phone_number_contact {get; set;}
        public string company_name {get; set;}
 }
}
