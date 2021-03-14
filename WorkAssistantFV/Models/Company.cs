using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***COMPANY MODEL***/
  [Table("company")]
 public partial class Company : IMicron
 {
        [Primary]
        public Int32 id {get; set;}
        public String name_company {get; set;}
        public DateTime date_created {get; set;}
        public String adress_company {get; set;}
        public String owner_company {get; set;}
        public String CEO_company {get; set;}
 }
}
