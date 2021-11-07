using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("pos")]
    public class Pos:AccountBase
    {
        public override void BuildMetaData(AppDbContext _db)
        {
            //Base entity
            var le_BaseType = GetBaseTypeEnum();
            var lt_BaseType = new BaseType() {SequenceRequired=true, BaseTypeId = (int)le_BaseType, BaseTypeName = le_BaseType.ToString(), RecordTypeType = BaseTypeTypeEnum.Account };
            _db.BaseTypes.AddOrUpdate(lt_BaseType);

            //Security role
            var lt_Role = new SecPrincipalRoleMaster() { ObjectId = (int)le_BaseType, PrincipalId = $"{lt_BaseType.BaseTypeName}{lt_BaseType.RecordTypeType.ToString()}", PrincipalName = lt_BaseType.BaseTypeName, RoleType = SecAccessTypeTypeEnum.Master };
            _db.SecPrincipalRoleMasters.AddOrUpdate(lt_Role);
            //Sequence
            //Find if Sequence already existed
            string ls_sequLogicalKey = le_BaseType.ToString().ToUpper() + "_SEQU";
            var lt_DBTBaseType = _db.BaseTypes.Find((int)le_BaseType);
            var lt_DBSequ = _db.SysSequences.Where(x => x.SequNum == ls_sequLogicalKey).FirstOrDefault();
            if (lt_DBSequ == null && lt_DBTBaseType.SysSequenceId == null)
            {
                var lt_Sequ = new SysSequence()
                {
                    SysSequRecycle = SysSequRecycleEnum.Continuous,
                    SequNum = ls_sequLogicalKey,
                    SequName = le_BaseType.ToString() + " Sequence",
                    StartDate = new DateTime(DateTime.Today.Year, 1, 1),
                    StartValue = 1,
                    SequValueStringFormat =  "POS####"

                };
                _db.SysSequences.AddOrUpdate(lt_Sequ);
                _db.SaveChanges();
                _db.BaseTypes.Attach(lt_DBTBaseType);
                lt_DBTBaseType.SysSequenceId = lt_Sequ.Id;
                _db.Entry(lt_DBTBaseType).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();

            }


            base.BuildMetaData(_db);
        }
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
