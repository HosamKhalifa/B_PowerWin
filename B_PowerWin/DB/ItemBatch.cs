using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("item_batch")]
  public class ItemBatch:LineBase
    {
        public override bool IsBusinessObject()
        {
            return true;
        }
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.ItemBatch;
        }
        public override void OnCreate(AppDbContext _db)
        {
            BaseType = (int)BaseTypeEnum.ItemBatch;
            base.OnCreate(_db);
        }
        public virtual ICollection<InventDimDefault> InventDimDefaults { get; set; }
        [StringLength(60)]
        public string BatchNum { get; set; }
        [StringLength(60)]
        public string BatchName { get; set; }
        public DateTime? ExpireDate { get; set; }
        public Vendor GuaranteeVendorId { get; set; }
        public int? GuaranteeMonths { get; set; }
        public ItemBatchTypeEnum ItemBatchType { get; set; }


    }
}
