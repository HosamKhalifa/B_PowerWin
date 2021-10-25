using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("main_account")]
    public class MainAccount:AccountBase
    {
        public override bool IsBusinessObject()
        {
            return true;
        }
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.MainAccount;
        }
        public override void OnCreate(AppDbContext _db)
        {
            BaseType = (int)BaseTypeEnum.MainAccount;
            base.OnCreate(_db);
        }
        public MainAccountTypeEnum MainAccountType { get; set; }
        [ForeignKey("MainAccountGroup")]
        public long? MainAccountGroupId { get; set; }
        public bool IsTotal { get; set; }
        
        public virtual MainAccountGroup MainAccountGroup { get; set; }
    }
}
