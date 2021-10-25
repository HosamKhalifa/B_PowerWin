using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace B_PowerWin.DB
{
    [Table("ui_grid_layout_line")]
    public class UIGridLayoutLine
    {
        [Key, Column(Order = 0)]
        public long? LayoutKey { get; set; }
        [Key, Column(Order = 1)]
        public UIGridLayoutVersionEnum VersionId { get; set; }
        [StringLength(100)]
        public string   Comment { get; set; }
        
        public string LayoutXml { get; set; }
        public virtual UIGridLayoutHeader LayoutHeader { get; set; }


    }
}
