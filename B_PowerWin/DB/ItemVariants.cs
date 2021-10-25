using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("item_variants")]
    public class ItemVariants:AccountBase
    {
        public override bool IsBusinessObject()
        {
            return true;
        }
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.ItemVariants;
        }
        public override void OnCreate(AppDbContext _db)
        {
            BaseType = (int)BaseTypeEnum.ItemVariants;
            base.OnCreate(_db);
        }
        public virtual ICollection<InventDimDefault> InventDimDefaults { get; set; }
        [StringLength(50), Index("item_variants_barcode_uq", IsUnique = true)]
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
