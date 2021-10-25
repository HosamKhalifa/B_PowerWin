using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("department")]
    public class Department:AccountBase
    {
        public override bool IsBusinessObject()
        {
            return true;
        }
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.Department;
        }

        public override void OnCreate(AppDbContext _db)
        {
            BaseType = (int)BaseTypeEnum.Department;
            base.OnCreate(_db);
        }
        public virtual ICollection<DimDefault> DimDefaults { get; set; }
    }
}
