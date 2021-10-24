using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("enum_table")]
   public class EnumTable
    {
        [StringLength(120)]
        public string SysName { get; set; }
        public int? ValueId { get; set; }
        [StringLength(120)]
        public string ValueName { get; set; }
    }
}
