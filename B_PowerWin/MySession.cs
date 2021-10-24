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
        public  MySession()
        {

        }
        public AppDbContext Database { get; set; }
        public ObjectContext ObjectContext { get { return ((IObjectContextAdapter)Database).ObjectContext; } }
        public MySession(string _userId,MainFrm _mainFrm)
        {
                Database = new AppDbContext();
            
                
                var usr = Database.SecPrincipalUsers.Find(_userId);
                UserId = usr.PrincipalId;
                UserKey = usr.UserKey;
                Employee = Database.Employees.Find(usr.EmplId);
                Company = Database.Companies.Find(usr.DefaultCompany);
                LangId = usr.LangId;
                SkinName = usr.SkinName;
                MainForm = _mainFrm;
                
                Session =this;

        }
      
        public static MySession Session { get; set; }
        public MainFrm MainForm { get; set; }
        public string UserId { get; set; }
        public int? UserKey { get; set; }
        public Employee Employee { get; set; }
        public Company Company { get; set; }
        public string LangId { get; set; }
        public string SkinName { get; set; }




    }
}
