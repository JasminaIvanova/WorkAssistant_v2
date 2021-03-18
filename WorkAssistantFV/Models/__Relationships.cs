using Micron;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data.Models
{

    #region COMPANY
    public partial class Company
    {
        public MicronDbContext DefaultDBContext { get; set; }

        public bool HasCompany_Users(string where = "true") { return DefaultDBContext.GetRecords<Company_Users>("company_id = " + this.id + " AND " + where + " LIMIT 1").Count() > 0; }
        public IEnumerable<Company_Users> GetCompany_Users(string where = "true") { return DefaultDBContext.GetRecords<Company_Users>("company_id = " + this.id + " AND " + where); }
        public void AddCompany_User(Company_Users model) { model.SetCompany(this); }
        public void AddCompany_Users(IEnumerable<Company_Users> models) { foreach (var model in models) model.SetCompany(this); }

    }
    #endregion
    #region COMPANY_USERS
    public partial class Company_Users
    {
        public MicronDbContext DefaultDBContext { get; set; }
        public Company GetCompany() { return DefaultDBContext.GetRecord<Company>(this.company_id); }
        public void SetCompany(Company model) { DefaultDBContext.SetRelation(this, model); }
        public Users GetUser() { return DefaultDBContext.GetRecord<Users>(this.user_id); }
        public void SetUser(Users model) { DefaultDBContext.SetRelation(this, model); }


    }
    #endregion
    #region OVERTIME
    public partial class Overtime
    {
        public MicronDbContext DefaultDBContext { get; set; }
        public Users GetUser() { return DefaultDBContext.GetRecord<Users>(this.user_id); }
        public void SetUser(Users model) { DefaultDBContext.SetRelation(this, model); }


    }
    #endregion
    #region USER_TASKS
    public partial class User_Tasks
    {
        public MicronDbContext DefaultDBContext { get; set; }
        public Users GetUser() { return DefaultDBContext.GetRecord<Users>(this.user_id); }
        public void SetUser(Users model) { DefaultDBContext.SetRelation(this, model); }


    }
    #endregion
    #region USERS
    public partial class Users
    {
        public MicronDbContext DefaultDBContext { get; set; }

        public bool HasCompany_Users(string where = "true") { return DefaultDBContext.GetRecords<Company_Users>("user_id = " + this.id + " AND " + where + " LIMIT 1").Count() > 0; }
        public IEnumerable<Company_Users> GetCompany_Users(string where = "true") { return DefaultDBContext.GetRecords<Company_Users>("user_id = " + this.id + " AND " + where); }
        public void AddCompany_User(Company_Users model) { model.SetUser(this); }
        public void AddCompany_Users(IEnumerable<Company_Users> models) { foreach (var model in models) model.SetUser(this); }
        public bool HasOvertime(string where = "true") { return DefaultDBContext.GetRecords<Overtime>("user_id = " + this.id + " AND " + where + " LIMIT 1").Count() > 0; }
        public IEnumerable<Overtime> GetOvertime(string where = "true") { return DefaultDBContext.GetRecords<Overtime>("user_id = " + this.id + " AND " + where); }
        public void AddOvertime(Overtime model) { model.SetUser(this); }
        public void AddOvertime(IEnumerable<Overtime> models) { foreach (var model in models) model.SetUser(this); }
        public bool HasUser_Tasks(string where = "true") { return DefaultDBContext.GetRecords<User_Tasks>("user_id = " + this.id + " AND " + where + " LIMIT 1").Count() > 0; }
        public IEnumerable<User_Tasks> GetUser_Tasks(string where = "true") { return DefaultDBContext.GetRecords<User_Tasks>("user_id = " + this.id + " AND " + where); }
        public void AddUser_Task(User_Tasks model) { model.SetUser(this); }
        public void AddUser_Tasks(IEnumerable<User_Tasks> models) { foreach (var model in models) model.SetUser(this); }

    }
    #endregion

}
