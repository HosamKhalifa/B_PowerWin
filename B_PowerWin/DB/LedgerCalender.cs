using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("ledger_calender")]
    public class LedgerCalender
    {
        [Key]
        public int? CalenderId { get; set; }
        [StringLength(100)]
        public string CalenderName { get; set; }
        public int? StartMonth { get; set; }
        public int? ClosingPeriods { get; set; }

        public List<LedgerYear> LedgerYears { get; set; }



    }
}
