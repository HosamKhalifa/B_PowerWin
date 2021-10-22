using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    [Table("cash")]
    public class Cash:AccountBase
    {
        public long? Employee { get; set; }

    }
}
