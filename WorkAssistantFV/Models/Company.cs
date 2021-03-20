using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***COMPANY MODEL***/
  [Table("company")]
 public partial class Company : IMicron
    {
        public Company()
        {

        }
        public Company(string name, int date, string address, string owner, string ceo)
        {
            this.name_company = name;
            this.date_created = date;
            this.adress_company = address;
            this.owner_company = owner;
            this.CEO_company = ceo;
        }
        public int id {get; set;}
        public string name_company {get; set;}
        public int date_created {get; set;}
        public string adress_company {get; set;}
        public string owner_company {get; set;}
        public string CEO_company {get; set;}
 }
}
