using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("invent_dim_default")]
    public class InventDimDefault
    {
        [Key]
        public long? Id { get; set; }/*The reference Document or JournalType Cust,Vend,Employee*/
        [ForeignKey("BusinessUnit")]
        public long? BusinessUnitId { get; set; }
        [ForeignKey("Site")]
        public long? SiteId { get; set; }
        [ForeignKey("Pos")]
        public long? PosId { get; set; }
        [ForeignKey("InventStore")]
        public long? InventStoreId { get; set; }
        [ForeignKey("Vendor")]
        public long? VendId { get; set; }
        [ForeignKey("Item")]
        public long? ItemId { get; set; }
        [ForeignKey("ItemGroup")]
        public long? ItemGroupId { get; set; }
        [ForeignKey("ItemSize")]
        public long? ItemSizeId { get; set; }
        [ForeignKey("ItemColor")]
        public long? ItemColorId { get; set; }
        [ForeignKey("ItemVariants")]
        public long? ItemVariantId { get; set; }
        [ForeignKey("ItemBatch")]
        public long? ItemBatchId { get; set; }

        public virtual BusinessUnit BusinessUnit { get; set; }
        public virtual Site Site { get;set;}
        public virtual  Pos Pos { get; set; }
        public virtual InventStore InventStore { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual Item Item { get; set; }
        public virtual AccountGroup ItemGroup { get; set; }
        public virtual ItemSize ItemSize { get; set; }
        public virtual ItemColor ItemColor { get; set; }
        public virtual ItemVariants ItemVariants { get; set; }
        public virtual ItemBatch ItemBatch { get; set; }




    }
}
