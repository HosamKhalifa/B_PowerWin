using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
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
        public int? YearId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public LedgerPeriodStatusEnum Status { get; set; }
    }
}
