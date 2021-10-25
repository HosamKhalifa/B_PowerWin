using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("tax_code")]
    public class TaxCode:LineBase
    {
        public override bool IsBusinessObject()
        {
            return true;
        }
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.TaxCode;
        }
        public override void OnCreate(AppDbContext _db)
        {
            BaseType = (int)BaseTypeEnum.TaxCode;
            base.OnCreate(_db);
        }
        public int? CompanyId { get; set; }
        [StringLength(10)]
        public string TaxCodeId { get; set; }
        [StringLength(100)]
        public string TaxCodeName { get; set; }
        public MainAccount ArTaxAccount { get; set; }
        public MainAccount ApTaxAccount { get; set; }
        public MainAccount SettlementTaxAccount { get; set; }


    }
}
