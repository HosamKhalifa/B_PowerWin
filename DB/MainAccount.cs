using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    [Table("main_account")]
    public class MainAccount:AccountBase
    {
        public MainAccountTypeEnum MainAccountType { get; set; }
        public NoYesEnum IsTotal { get; set; }
        //[ForeignKey("MainAccountGroup")]
        public MainAccountGroup MainAccountGroup { get; set; }
    }
}
