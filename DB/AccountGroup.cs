using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    [Table("account_group")]
    public class AccountGroup:AccountBase
    {
        [Required]
        public BaseType GroupedBaseType { get; set; }
    }
}
