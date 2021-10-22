using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    [Table("tax_code_value_setup")]
    public class TaxCodeValueSetup:LineBase
    {
        public long? TaxCodeId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public decimal? FromAmount { get; set; }
        public decimal? ToAmount { get; set; }
        public TaxValueTypeEnum TaxValueType { get; set; }
        public decimal? TaxValue { get; set; }

    }
}
