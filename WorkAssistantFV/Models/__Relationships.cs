using Micron;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data.Models
{

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

   public bool HasUser_Tasks(string where="true") {return DefaultDBContext.GetRecords<User_Tasks>("user_id = "+this.id+" AND "+where+" LIMIT 1").Count()>0;}
   public IEnumerable<User_Tasks> GetUser_Tasks(string where="true") {return DefaultDBContext.GetRecords<User_Tasks>("user_id = "+this.id+" AND "+where);}
    public void AddUser_Task(User_Tasks model) { model.SetUser(this); }
    public void AddUser_Tasks(IEnumerable<User_Tasks> models) {foreach(var model in models) model.SetUser(this); }

 }
#endregion

}
