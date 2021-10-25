using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("ledger_period")]
    public class LedgerPeriod
    {
        [Key]
        public int? PeriodId { get; set; }
        public string PeriodName { get; set; }
        public int? PeriodNum { get; set; }
        public int? Quarter { get; set; }
        public int? PeriodClass { get; set; }
        [ForeignKey("LedgerYear")]
        public int? YearId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public LedgerPeriodStatusEnum Status { get; set; }

        public virtual LedgerYear LedgerYear { get; set; }


        public virtual ICollection<LedgerJournal> LedgerJournals { get; set; }
    }
}
