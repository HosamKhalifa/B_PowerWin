using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    [Table("item_variants")]
    public class ItemVariants:AccountBase
    {
        public string BarCode { get; set; }
        public decimal? PurchPrice { get; set; }
        public decimal? SalesPrice { get; set; }
        public decimal? SalesPriceMin { get; set; }
        public bool BuyFromCustomer { get; set; }

        public long? Item { get; set; }

        public long? ItemSizeId { get; set; }
        public long? ItemColorId { get; set; }

    }
}
