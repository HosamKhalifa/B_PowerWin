using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("pos")]
    public class Pos:AccountBase
    {
        public override bool IsBusinessObject()
        {
            return true;
        }
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.Pos;
        }
        public MainAccount ArAccount { get; set; }
        public MainAccount CashAccount { get; set; }
        public Employee PosManager { get; set; }
        public JournalType SalesJournal { get; set; }
        public JournalType ExpenseJournal { get; set; }
        public JournalType InventTransferJournal { get; set; }


    }
}
