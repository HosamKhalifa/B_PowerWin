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
        public JournalType Journal { get; set; }
        public JournalTypeEnum JourType { get; set; }
        
        public JournalTypeDetailSummaryEnum DetailSummary { get; set; }
        public DocumentBase Document { get; set; }
        public PostingLayerEnum PostingLayer { get; set; }
        public DateTime? PostingDate { get; set; }
        public LedgerPeriod PostingPeriod { get; set; }
        public DateTime? DocumentDate { get; set; }
        [StringLength(30)]
        public string VoucherNum { get; set; }
        [StringLength(200)]
        public string Txt { get; set; }
        
        

    }
}
