using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    [Table("tax_code")]
    public class TaxCode:LineBase
    {
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
