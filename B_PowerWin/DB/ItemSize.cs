using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("item_size")]
  public  class ItemSize:LineBase
    {
        public override bool IsBusinessObject()
        {
            return true;
        }
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.ItemSize;
        }
        public override void OnCreate(AppDbContext _db)
        {
            BaseType = (int)BaseTypeEnum.ItemSize;
            base.OnCreate(_db);
        }
        public virtual ICollection<InventDimDefault> InventDimDefaults { get; set; }

        public Item Item { get; set; }
        public ItemSizeEnum SizeEnum { get; set; }
        [StringLength(60)]
        public string ItemSizeName { get; set; }
        public decimal? BasicSizeConvertFactor { get; set; }

    }
}
