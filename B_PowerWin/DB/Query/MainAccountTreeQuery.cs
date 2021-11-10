using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB.Query
{
    [NotMapped]
   public class MainAccountTreeQuery
    {
        public static string DDL_SQL { get { return "CREATE or ALTER VIEW MainAccountTreeQuery AS SELECT a.Id,a.ReferenceNum ,a.Name,a.ParentNameList,ParnetId FROM account_base a INNER JOIN     main_account m ON a.Id = m.Id where m.IsTotal = 1 and       a.Id  not in (select isnull(la.ParnetId,0)  from  account_base la inner join  main_account lm on la.Id = lm.Id   where lm.IsTotal = 1)"; } }
        public static string SELECT_SQL { get { return "SELECT M.Id,M.Name,M.ParentNameList,M.ParnetId,M.ReferenceNum FROM MainAccountTreeQuery m"; } }
        public long? Id { get; set; }
        public string ReferenceNum { get; set; }
        public string Name { get; set; }
        public string ParentNameList { get; set; }
        public long? ParnetId { get; set; }
        public string FullName { get { return $"{ReferenceNum} {Name}"; } }


    }
}
