using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("ledger_journal")]
    public class LedgerJournal:LineBase
    {
        public long? CompanyId { get; set; }
        [ForeignKey("Journal")]
        public  long? JournalId { get; set; }
        [ForeignKey("Document")]
        public long? DocumentId { get; set; }
        public JournalTypeEnum JourType { get; set; }
        
        public JournalTypeDetailSummaryEnum DetailSummary { get; set; }
        
        public PostingLayerEnum PostingLayer { get; set; }
        public DateTime? PostingDate { get; set; }
        [ForeignKey("PostingPeriod")]
        public int? PostingPeriodId { get; set; }
        public DateTime? DocumentDate { get; set; }
        [StringLength(30)]
        public string VoucherNum { get; set; }
        [StringLength(200)]
        public string Txt { get; set; }

        public virtual JournalType Journal { get; set; }
        public virtual DocumentBase Document { get; set; }
        public virtual LedgerPeriod PostingPeriod { get; set; }
    }
}
