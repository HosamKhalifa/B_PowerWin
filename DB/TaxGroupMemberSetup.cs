using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    [Table("tax_group_member_setup")]
    public class TaxGroupMemberSetup:LineBase
    {
        public long? TaxGroupId { get; set; }
        public long? TaxCodeId { get; set; }
        public bool IsDefault { get; set; }

    }
}
