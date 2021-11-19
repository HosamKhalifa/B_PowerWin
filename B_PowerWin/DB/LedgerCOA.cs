using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("ledger_coa")]
    public class LedgerCOA:ILineBase

    {
        [Key,Range(11,99)]
        public int? COAId { get; set; }
        [StringLength(60)]
        public string COAName { get; set; }

        [Range(4,20)]
        public int? AccountNumLength { get; set; }
       
        
        public virtual ICollection<MainAccount> MainAccounts { get; set; }

        #region ILinBaseImpl

        
        public BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.None;
        }

        public void BuildMetaData(AppDbContext _db)
        {
           
        }

        public bool IsBusinessObject()
        {
            return false;
        }

        public Exception GetLineExceptionDetails(AppDbContext _db, LineBaseCRUDEnum _CRUDType)
        {
            string ls_expName;
            
            ls_expName = $"Error when {_CRUDType.ToString()} LedgerCOA  Id:{this.COAId} Name {COAName} ";
            var exp = new Exception(ls_expName);
            exp.Data.Add("EntityObject", this);
            

            return exp;
        }

        public bool ValidateLine(AppDbContext _db, LineBaseCRUDEnum _CRUDType)
        {
            return true;

        }

        public void OnCreate(AppDbContext _db)
        {
           
        }

        public void OnUpdate(AppDbContext _db, DbEntityEntry _entryStatus)
        {
            
        }

        public void OnDelete(AppDbContext _db)
        {
           
        }
        #endregion

    }
}
