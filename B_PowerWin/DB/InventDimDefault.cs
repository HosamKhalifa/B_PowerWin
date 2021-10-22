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
        public long? BusinessUnit { get; set; }
        public long? SiteId { get; set; }
        public long? PosId { get; set; }
        public long? WarehouseId { get; set; }
        public long? VendId { get; set; }
        public long? ItemId { get; set; }
        public long? ItemGroupId { get; set; }
        public long? ItemSizeId { get; set; }
        public long? ItemColorId { get; set; }
        public long? ItemVariantId { get; set; }
        public long? ItemBatchId { get; set; }




    }
}
