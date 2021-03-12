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
 }
}
