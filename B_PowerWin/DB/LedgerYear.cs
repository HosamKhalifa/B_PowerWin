using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("ledger_year")]
    public class LedgerYear
    {
        [Key]
        public int? YearId { get; set; }
        [StringLength(100)]
        public string YearName { get; set; }
        public bool IsOpen { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        [ForeignKey("LedgerCalender")]
        public int? CalenderId { get; set; }
        public virtual LedgerCalender LedgerCalender { get; set; }
        public virtual ICollection<LedgerPeriod> LedgerPeriods { get; set; }


    }
}
