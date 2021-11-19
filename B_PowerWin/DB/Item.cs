using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("item")]
   public class Item:AccountBase
    {
        public Item():base()
        {

        }
        public virtual ICollection<InventDimDefault> InventDimDefaults { get; set; }
        public decimal? PurchPrice { get; set; }
        public decimal? SalesPrice { get; set; }
        public decimal? SalesPriceMin { get; set; }
        [Required]
        public ItemModeEnum ItemMode { get; set; }

    }
}
