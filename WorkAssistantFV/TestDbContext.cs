using Data.Models;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkAssistantFV
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class TestDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<User_Tasks> User_Tasks { get; set; }
        public DbSet<Overtime> Overtime { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Company_Users> Company_Users { get; set; }

        public TestDbContext() :base("name = Connection")
        {

        }
        public static TestDbContext GetConnection() 
        {
            return new TestDbContext();
        }
    }
}
