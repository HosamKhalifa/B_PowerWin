using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("site")]
   public class Site:AccountBase
    {
        public override bool IsBusinessObject()
        {
            return true;
        }
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.Site;
        }

        public override void OnCreate(AppDbContext _db)
        {
            BaseType = (int)BaseTypeEnum.Site;
            base.OnCreate(_db);
        }
        public virtual ICollection<DimDefault> DimDefaults { get; set; }
        public virtual ICollection<InventDimDefault> InventDimDefaults { get; set; }

    }
}
