using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    [Table("item_size")]
  public  class ItemSize:LineBase
    {
        public Item Item { get; set; }
        public ItemSizeEnum SizeEnum { get; set; }
        [StringLength(60)]
        public string ItemSizeName { get; set; }
        public decimal? BasicSizeConvertFactor { get; set; }

    }
}
