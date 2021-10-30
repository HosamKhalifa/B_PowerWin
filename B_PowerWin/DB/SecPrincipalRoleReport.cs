using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    public class SecPrincipalRoleReport:SecPrincipalRole
    {
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.SecPrincipalRoleReport;
        }
        public override void OnCreate(AppDbContext _db)
        {
            RoleType = SecAccessTypeTypeEnum.SysOutputReport;
            base.OnCreate(_db);
        }
    }
}
