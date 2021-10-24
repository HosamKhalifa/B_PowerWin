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
        public MainAccountTypeEnum MainAccountType { get; set; }
        public NoYesEnum IsTotal { get; set; }
        //[ForeignKey("MainAccountGroup")]
        public MainAccountGroup MainAccountGroup { get; set; }
    }
}
