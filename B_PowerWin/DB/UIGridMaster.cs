using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("ui_grid_master")]
    public class UIGridMaster
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long? GridKey { get; set; }
        [StringLength(300),Required,Index("ui_grid_master_csharpcodename_uq",IsUnique =true)]
        public string GridCSharpCodeName { get; set; }
        [StringLength(300)]
        public string GridCSharpCodeCaption{ get; set; }
        public virtual ICollection<UIGridLayoutHeader> Lines { get; set; }


    }
}
