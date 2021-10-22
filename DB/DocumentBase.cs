using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DB
{
    [Table("doc_base")]
   public class DocumentBase:LineBase
    {
        public int? CompanyId { get; set; }
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
        public Country Country { get; set; }
        public City City { get; set; }
        public long? TaxGroup { get; set; }
        public string TaxFileNum { get; set; }
        public string TaxCardNum { get; set; }
        public string TaxCommRegisterNum { get; set; }

    }
}
