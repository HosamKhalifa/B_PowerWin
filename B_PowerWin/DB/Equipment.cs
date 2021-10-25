using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("equipment")]
  public  class Equipment:AccountBase
    {
        public override bool IsBusinessObject()
        {
            return true;
        }
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.Equipment;
        }

        

        public override void OnCreate(AppDbContext _db)
        {
            BaseType = (int)BaseTypeEnum.Equipment;
            base.OnCreate(_db);
        }
        public virtual ICollection<DimDefault> DimDefaults { get; set; }
    }
}
