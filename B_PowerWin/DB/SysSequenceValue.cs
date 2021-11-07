using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("sys_sequence_value")]
    public class SysSequenceValue:ILineBase
    {



        [StringLength(20)]
        public string SequNum { get; set; }
        public SysSequRecycleEnum SysSequRecycle { get; set; }
        public int CurrentRecycleValue { get; set; }
        [Required]
        public int CurrentValue { get; set; }
        
        public long? SequValueVersion { get; set; }
        
        private long? NewSequValueVersion(AppDbContext _db)
        {
            long? li_Return = 0;
            var li_DBLastVer = _db.Database.SqlQuery<long?>($"select IsNull(Max(SequValueVersion),0) from sys_sequence_value ").FirstOrDefault();
            if(li_DBLastVer.HasValue && li_DBLastVer > 0)
            {
                li_Return = li_DBLastVer + 1;
            }
            else
            {
                li_Return = 1;
            }

            return li_Return;
        }


        #region ILineBaseImpl

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

            ls_expName = $"Error when {_CRUDType.ToString()} SysSequenceValue  SequId:{this.SequNum}  ";
            var exp = new Exception(ls_expName);
            exp.Data.Add("EntityObject", this);


            return exp;
        }

        public bool ValidateLine(AppDbContext _db, LineBaseCRUDEnum _CRUDType)
        {
            return this.SequValueVersion > 0 && string.IsNullOrEmpty(SequNum);
        }

        public void OnCreate(AppDbContext _db)
        {
            SequValueVersion = NewSequValueVersion(_db);
        }

        public void OnUpdate(AppDbContext _db)
        {

        }

        public void OnDelete(AppDbContext _db)
        {

        }


        #endregion

    }
}
