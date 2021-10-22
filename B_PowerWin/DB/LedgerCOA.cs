using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("ledger_coa")]
    public class LedgerCOA
    {
        [Key]
        public int? COAId { get; set; }
        [StringLength(60)]
        public string COAName { get; set; }
        [Range(4,20)]
        public int? AccountNumLength { get; set; }
    }
}
