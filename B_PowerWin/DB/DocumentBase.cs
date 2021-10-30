using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace B_PowerWin.DB
{
    [Table("doc_base")]
   public class DocumentBase:LineBase
    {
        [Required]
        public int? CompanyId { get; set; }
        [Required,ForeignKey("JournalType")]
        public long? JournalTypeId { get; set; }
        public virtual JournalType JournalType { get; set; }//Reference 
        [StringLength(50), Required]
        public string DisplayNum { get; set; }
        [StringLength(50)]
        public string ReferenceNum { get; set; }
        [Required]
        public DateTime? TransDate { get; set; }
        
        public int? TransDayId { get; set; }
        public int HeadAccountBaseTypeId { get; set; }/*Ledger,Customer,Vendor,Bank,Cash*/
        public long? HeadAccountId { get; set; }
        [StringLength(250)]
        public string HeadAccountName { get; set; }
        public long? HeadLedgerAccountId { get; set; }
        public long? PostingPeriod { get; set; }
     
        [StringLength(250)]
        public string Address { get; set; }
        [StringLength(150)]
        public string ContactName { get; set; }
        [StringLength(5),ForeignKey("Country")]
        public string CountryId { get; set; }
        public virtual Country Country { get; set; }
        [ForeignKey("City")]
        public long? CityId { get; set; }
        public virtual City City { get; set; }
        public long? TaxGroup { get; set; }
        public string TaxFileNum { get; set; }
        public string TaxCardNum { get; set; }
        public string TaxCommRegisterNum { get; set; }


        
        public virtual ICollection<LedgerJournal> LedgerJournals { get; set; }

    }
}
