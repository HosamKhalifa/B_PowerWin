using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    [Table("pos")]
    public class Pos:AccountBase
    {
        public MainAccount ArAccount { get; set; }
        public MainAccount CashAccount { get; set; }
        public Employee PosManager { get; set; }
        public JournalType SalesJournal { get; set; }
        public JournalType ExpenseJournal { get; set; }
        public JournalType InventTransferJournal { get; set; }


    }
}
