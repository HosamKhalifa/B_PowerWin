using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("vendor")]
    public class Vendor:AccountBase
    {
        public override void OnCreate(AppDbContext _db)
        {
            BaseType = (int)BaseTypeEnum.Vendor;
            base.OnCreate(_db);
        }
        public override bool IsBusinessObject()
        {
            return true;
        }
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.Vendor;
        }

        public virtual ICollection<DimDefault> DimDefaults { get; set; }
        public virtual ICollection<InventDimDefault> InventDimDefaults { get; set; }
    }
}
