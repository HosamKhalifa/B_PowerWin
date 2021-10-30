using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    public class SecPrincipalRoleAction: SecPrincipalRole
    {
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.SecPrincipalRoleAction;
        }
        public override void OnCreate(AppDbContext _db)
        {
            RoleType = SecAccessTypeTypeEnum.SysAction;
            base.OnCreate(_db);
        }
    }
}
