using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("item_inventory_barcode")]
   public class ItemInventoryBarcode:LineBase
    {
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.ItemInventoryBarcode;
        }
        public override bool IsBusinessObject()
        {
            return true;
        }
        public override void OnCreate(AppDbContext _db)
        {

            base.OnCreate(_db);
        }

        #region Fileds
        [Key,StringLength(60)]
        public string BarCode { get; set; }
        [Required,ForeignKey("ItemVariants")]
        public long? ItemVariantsId { get; set; }
        [ForeignKey("Vendor")]
        public long? VendId { get; set; }
        [ForeignKey("ItemBatch"), Index("item_inventory_barcode_ItemBatchId_UQ", IsUnique = true)]
        public long? ItemBatchId { get; set; }

        public virtual ItemVariants ItemVariants { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual ItemBatch ItemBatch { get; set; }

        #endregion

    }
}
