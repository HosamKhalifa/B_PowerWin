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
        #region ClassFieldNames
        [NotMapped]
        public static class ItemFields
        {
            public static string PurchPrice { get { return "PurchPrice"; } }
            public static string SalesPrice { get { return "SalesPrice"; } }
            public static string SalesPriceMin { get { return "SalesPriceMin"; } }
            public static string ItemMode { get { return "ItemMode"; } }


        }
        #endregion
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
