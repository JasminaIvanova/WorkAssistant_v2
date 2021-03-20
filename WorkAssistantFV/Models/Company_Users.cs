using Micron;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{

 public partial class Company_Users
    {
        [Key]
        [ForeignKey("Company")]
        public int company_id { get; set; }
        public Company Company { get; set; }

        [ForeignKey("Users")]
        public int user_id { get; set; }
        public Users Users { get; set; }
    }
}
