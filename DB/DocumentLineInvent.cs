using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    [Table("doc_line_invent")]
    public class DocumentLineInvent:DocumentLine
    {
        public long? WarehouseId { get; set; }
        public long? ItemId { get; set; }
        public long? ItemGroupId { get; set; }
        public long? ItemSizeId { get; set; }
        public long? ItemColorId { get; set; }
        public long? ItemVariantId { get; set; }
        public long? ItemBatchId { get; set; }
        public string SerialList { get; set; }
        [StringLength(250)]
        public string ItemDesc { get; set; }
        public decimal? PurchPrice { get; set; }
        public decimal? SalesPrice { get; set; }

        public long? TargetWarehouseId { get; set; }






    }
}
