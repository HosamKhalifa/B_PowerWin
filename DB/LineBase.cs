using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DB
{
    [Table("line_base")]
    public class LineBase
    {
        public LineBase()
        {
            //New line 
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long? Id { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        [StringLength(50)]
        public string MofifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public BaseType BaseType { get; set; }
        public long? ParnetId { get; set; }
    }
}
