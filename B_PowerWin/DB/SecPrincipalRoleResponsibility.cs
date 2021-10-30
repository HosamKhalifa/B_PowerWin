using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    public class SecPrincipalRoleResponsibility:SecPrincipalRole
    {
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.SecPrincipalRoleResponsibility;
        }
        public override void OnCreate(AppDbContext _db)
        {
            RoleType = SecAccessTypeTypeEnum.Responsibility; 
            base.OnCreate(_db);
        }
        public override void OnUpdate(AppDbContext _db)
        {
            RoleType = SecAccessTypeTypeEnum.Responsibility;
            base.OnUpdate(_db);
        }
    }
}
