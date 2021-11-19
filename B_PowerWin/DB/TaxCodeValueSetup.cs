using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("tax_code_value_setup")]
    public class TaxCodeValueSetup:LineBase
    {
        #region ClassFieldNames
        [NotMapped]
        public static class TaxCodeValueSetupFields
        {
            public static string TaxCodeId { get { return "TaxCodeId"; } }
            public static string FromDate { get { return "FromDate"; } }
            public static string ToDate { get { return "ToDate"; } }
            public static string FromAmount { get { return "FromAmount"; } }
            public static string ToAmount { get { return "ToAmount"; } }
            public static string TaxValueType { get { return "TaxValueType"; } }
            public static string TaxValue { get { return "TaxValue"; } }

        }
        #endregion
public override bool IsBusinessObject()
        {
            return true;
        }
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.TaxCodeValueSetup;
        }
        public override void OnCreate(AppDbContext _db)
        {
            BaseType = (int)BaseTypeEnum.TaxCodeValueSetup;
            base.OnCreate(_db);
        }
        [ForeignKey("TaxCode"),Required]
        public long? TaxCodeId { get; set; }
        [Required]
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        [Required ,Range(0, 9999999999)]
        public decimal? FromAmount { get; set; }
        [Required,Range(0, 9999999999)]
        public decimal? ToAmount { get; set; }
        public TaxValueTypeEnum TaxValueType { get; set; }
        [Required]
        public decimal? TaxValue { get; set; }
        public virtual TaxCode TaxCode { get; set; }

    }
}
