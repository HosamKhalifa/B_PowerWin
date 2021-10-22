using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
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
        public LedgerCalender CalenderId { get; set; }


    }
}
