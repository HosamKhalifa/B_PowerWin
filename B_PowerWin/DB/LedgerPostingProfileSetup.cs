using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("ledger_posting_profile_setup")]
    public class LedgerPostingProfileSetup
    {
        [Key,Column(Order = 1),StringLength(100),ForeignKey("LedgerPostingProfile")]
        public string ProfileId { get; set; }
        [Key, Column(Order = 2)]
        public int LineNum { get; set; }
        [Required]
        public LedgerPostingScopeEnum PostingScope { get; set; }
        [Required]
        public long? LineValue { get; set; }
        [StringLength(250)]
        [Required]
        public string LineDescription { get; set; }
        public virtual LedgerPostingProfile LedgerPostingProfile { get; set; }
        public LedgerPostingEntryEnum LedgerPostingEntry { get; set; }
        public long? CVBC_MainAccount { get; set; }/*Customer,Vendor,Bank,Cash*/
        public long? InventoryControl_MainAccount { get; set; }//اصول
        public long? SalesRevenue_MainAccount { get; set; }//ايرادات 
        public long? CostOfGoodsSold_MainAccount { get; set; }//مصروف
        public long? DeferredRevenue_MainAcount { get; set; }//ايرادات مؤجلة خصوم
        public long? UnInvoicedAR_MainAccount { get; set; }//مدينون مبيعات غير مفوترة	اصول
        public long? UnderInspectionInventory_MainAccount { get; set; }//مشتريات اصناف تحت الفحص والاستلام	اصول
        public long? UnderInspectionVendor_MainAccount { get; set; }//موردين بضاعة تحت الفحص والاستلام	خصوم




    }
}
