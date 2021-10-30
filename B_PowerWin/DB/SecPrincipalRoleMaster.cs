using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
   public class SecPrincipalRoleMaster:SecPrincipalRole
    {
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.SecPrincipalRoleMaster;
        }
        public override void OnCreate(AppDbContext _db)
        {
            RoleType = SecAccessTypeTypeEnum.Master;
            base.OnCreate(_db);
        }
    }
}
