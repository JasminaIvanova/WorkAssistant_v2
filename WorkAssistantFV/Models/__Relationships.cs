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

   public bool HasCompany_Users(string where="true") {return DefaultDBContext.GetRecords<Company_User>("company_id = "+this.id+" AND "+where+" LIMIT 1").Count()>0;}
   public IEnumerable<Company_User> GetCompany_Users(string where="true") {return DefaultDBContext.GetRecords<Company_User>("company_id = "+this.id+" AND "+where);}
    public void AddCompany_User(Company_User model) { model.SetCompany(this); }
    public void AddCompany_Users(IEnumerable<Company_User> models) {foreach(var model in models) model.SetCompany(this); }
   public bool HasUsers(string where="true") {return DefaultDBContext.GetRecords<Users>("company_id = "+this.id+" AND "+where+" LIMIT 1").Count()>0;}
   public IEnumerable<Users> GetUsers(string where="true") {return DefaultDBContext.GetRecords<Users>("company_id = "+this.id+" AND "+where);}
    public void AddUser(Users model) { model.SetCompany(this); }
    public void AddUsers(IEnumerable<Users> models) {foreach(var model in models) model.SetCompany(this); }

 }
#endregion
#region COMPANY_USERS
 public partial class Company_User
 {
public MicronDbContext DefaultDBContext { get; set; }
  public  Company GetCompany() { return DefaultDBContext.GetRecord<Company>(this.company_id); }
   public void SetCompany(Company model)  {  DefaultDBContext.SetRelation(this, model);}
  public  Users GetUser() { return DefaultDBContext.GetRecord<Users>(this.user_id); }
   public void SetUser(Users model)  {  DefaultDBContext.SetRelation(this, model);}


 }
#endregion
#region USER_TASKS
 public partial class User_Tasks
 {
public MicronDbContext DefaultDBContext { get; set; }
  public  Users GetUser() { return DefaultDBContext.GetRecord<Users>(this.user_id); }
   public void SetUser(Users model)  {  DefaultDBContext.SetRelation(this, model);}


 }
#endregion
#region USERS
 public partial class Users
 {
public MicronDbContext DefaultDBContext { get; set; }
  public  Company GetCompany() { return DefaultDBContext.GetRecord<Company>(this.company_id); }
   public void SetCompany(Company model)  {  DefaultDBContext.SetRelation(this, model);}

   public bool HasCompany_Users(string where="true") {return DefaultDBContext.GetRecords<Company_User>("user_id = "+this.id+" AND "+where+" LIMIT 1").Count()>0;}
   public IEnumerable<Company_User> GetCompany_Users(string where="true") {return DefaultDBContext.GetRecords<Company_User>("user_id = "+this.id+" AND "+where);}
    public void AddCompany_User(Company_User model) { model.SetUser(this); }
    public void AddCompany_Users(IEnumerable<Company_User> models) {foreach(var model in models) model.SetUser(this); }
   public bool HasUser_Tasks(string where="true") {return DefaultDBContext.GetRecords<User_Tasks>("user_id = "+this.id+" AND "+where+" LIMIT 1").Count()>0;}
   public IEnumerable<User_Tasks> GetUser_Tasks(string where="true") {return DefaultDBContext.GetRecords<User_Tasks>("user_id = "+this.id+" AND "+where);}
    public void AddUser_Task(User_Tasks model) { model.SetUser(this); }
    public void AddUser_Tasks(IEnumerable<User_Tasks> models) {foreach(var model in models) model.SetUser(this); }

 }
#endregion

}
