using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace B_PowerWin.DB
{
    [Table("base_type")]
    public class BaseType
    {
        public BaseType()
        {
            SequenceRequired = false;
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BaseTypeId { get; set; }
        [StringLength(100)]
        public string BaseTypeName { get; set; }
       
        public BaseTypeTypeEnum RecordTypeType { get; set; }
        public bool SequenceRequired { get; set; }

        [ForeignKey("SysSequence")]
        public long? SysSequenceId { get; set; }
        public virtual SysSequence SysSequence { get; set; }
        public List<LineBase> Lines { get; set; }
        
       
    }
}
