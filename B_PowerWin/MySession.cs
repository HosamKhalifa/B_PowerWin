using B_PowerWin.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin
{
    public class MySession
    {
        public MySession()
        {

        }
        public AppDbContext Database { get; set; }
        public ObjectContext ObjectContext { get { return ((IObjectContextAdapter)Database).ObjectContext; } }
        public MySession(string _userId)
        {
            Database = new AppDbContext();
            
                var ret = new MySession();
                var usr = Database.SecPrincipalUsers.Find(_userId);
                ret.UserId = usr.PrincipalId;
                ret.UserKey = usr.UserKey;
                ret.Employee = Database.Employees.Find(usr.EmplId);
                ret.Company = Database.Companies.Find(usr.DefaultCompany);
            

        }
      
        public static MySession Session { get; set; }
        
        public string UserId { get; set; }
        public int? UserKey { get; set; }
        public Employee Employee { get; set; }
        public Company Company { get; set; }
        public string LangId { get; set; }



    }
}
