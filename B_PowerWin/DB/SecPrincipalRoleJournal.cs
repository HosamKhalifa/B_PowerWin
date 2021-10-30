using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    public class SecPrincipalRoleJournal:SecPrincipalRole
    {
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.SecPrincipalRoleJournal;
        }
        public override void OnCreate(AppDbContext _db)
        {
            RoleType = SecAccessTypeTypeEnum.Journal;
            base.OnCreate(_db);
        }
    }
}
