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
        public override void OnCreate(AppDbContext _db)
        {
            BaseType = (int)BaseTypeEnum.Pos;
            base.OnCreate(_db);
        }
        public virtual ICollection<DimDefault> DimDefaults { get; set; }
        public virtual ICollection<InventDimDefault> InventDimDefaults { get; set; }
        [ForeignKey("ArAccount")]
        public long? ArAccountId { get; set; }
        [ForeignKey("CashAccount")]
        public long? CashAccountId { get; set; }
        [ForeignKey("PosManager")]
        public long? PosManagerId { get; set; }
        [ForeignKey("SalesJournal")]
        public long? SalesJournalId { get; set; }
        [ForeignKey("ExpenseJournal")]
        public long? ExpenseJournalId { get; set; }
        [ForeignKey("InventTransferJournal")]
        public long? InventTransferJournalId { get; set; }

        public virtual MainAccount ArAccount { get; set; }
        public virtual MainAccount CashAccount { get; set; }
        public virtual  Employee PosManager { get; set; }
        public virtual  JournalType SalesJournal { get; set; }
        public virtual  JournalType ExpenseJournal { get; set; }
        public virtual  JournalType InventTransferJournal { get; set; }
    }
}
