using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    [Table("tax_group")]
    public class TaxGroup:LineBase
    {
        public int? CompanyId { get; set; }
        [StringLength(50)]
        public string GroupName { get; set; }

    }
}
