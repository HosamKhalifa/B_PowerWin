using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    [Table("sec_access_type")]
    public class SecAccessType
    {
        [Key]
        public int? AccessType { get; set; }
        [StringLength(100)]
        public string AccessTypeName { get; set; }
        [StringLength(100)]
        public string AccessTypeDescription { get; set; }
        public SecAccessTypeTypeEnum AccessTypeType { get; set; }
        public NoYesEnum AllowRead { get; set; }
        public NoYesEnum AllowCreate { get; set; }
        public NoYesEnum AllowRemove { get; set; }
        public NoYesEnum AllowApprove { get; set; }
        public NoYesEnum AllowReject { get; set; }
        public NoYesEnum AllowPost { get; set; }
        public NoYesEnum AllowUnpost { get; set; }


    }
}
