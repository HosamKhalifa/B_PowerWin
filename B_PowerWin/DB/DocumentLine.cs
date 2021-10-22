using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("doc_line")]
    public class DocumentLine:LineBase
    {
        public long? DocumentId { get; set; }
        public int? LineNum { get; set; }

        public LedgerLineTypeEnum LedgerActType { get; set; }
        public long? LedgerActId { get; set; }

        #region Main Dimensions
        public long? MainAccount { get; set; }
        public long? BusinessUnit { get; set; }
        public long? SiteId { get; set; }
        public long? DeptId { get; set; }
        public long? EqupId { get; set; }
        public long? ProjectId { get; set; }
        public long? PurposeId { get; set; }
        public long? BankId { get; set; }
        public long? CustId { get; set; }
        public long? VendId { get; set; }
        public long? EmplId { get; set; }
        public long? PosId { get; set; }

        #endregion

        #region Offset Dimensions
        public long? OffsetMainAccount { get; set; }
        public long? OffsetBusinessUnit { get; set; }
        public long? OffsetSiteId { get; set; }
        public long? OffsetDeptId { get; set; }
        public long? OffsetEqupId { get; set; }
        public long? OffsetProjectId { get; set; }
        public long? OffsetPurposeId { get; set; }
        public long? OffsetBankId { get; set; }
        public long? OffsetCustId { get; set; }
        public long? OffsetVendId { get; set; }
        public long? OffsetEmplId { get; set; }
        public long? OffsetPosId { get; set; }

        #endregion

        [StringLength(200)]
        public string LineTxt { get; set; }
        public decimal? Qty { get; set; }
        public decimal Price { get; set; }
        public decimal InitValueFC { get; set; }
        [StringLength(5)]
        public string  CurrencyCode { get; set; }
        public decimal? ExchRate { get; set; }
        public decimal? InitValue { get; set; }
        
        public long? DiscountId { get; set; }
        public decimal? DiscountRate { get; set; }
        public decimal?DiscountValue  { get; set; }
        public decimal? BeforeTaxValue { get; set; }
        public long? TaxGroupId { get; set; }
        public long? TaxCodeId { get; set; }

        public decimal? TaxAmount { get; set; }
        public decimal? LineValue { get; set; }
        public LineTotalEffectEnum LineTotalEffect { get; set; }
        public decimal? CostPrice { get; set; }




    }
}
