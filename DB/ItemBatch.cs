using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    [Table("item_batch")]
  public class ItemBatch:LineBase
    {
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
