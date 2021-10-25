using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("ui_grid_layout_header")]
  public  class UIGridLayoutHeader
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long? LayoutKey { get; set; }
        [Index("ui_grid_layout_header_gridkey_userid_uq", 1, IsUnique = true)]
        public long? GridKey { get; set; }
        [Index("ui_grid_layout_header_gridkey_userid_uq", 2, IsUnique = true)]
        [StringLength(120)]
        public string UserId { get; set; }
        public virtual ICollection<UIGridLayoutLine> Lines { get; set; }
        public virtual UIGridMaster GridMaster { get; set; }



    }
}
