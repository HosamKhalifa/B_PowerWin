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
    public class SysSequenceValue
    {

        [StringLength(20)]
        public string SequNum { get; set; }
        public SysSequRecycleEnum SysSequRecycle { get; set; }
        public int CurrentRecycleValue { get; set; }
        [Required]
        public int CurrentValue { get; set; }
        

    }
}
