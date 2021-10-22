using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    [Table("Customer")]
    public class Customer:AccountBase
    {
        [Required]
        public decimal? CreditLimit { get; set; }

    }
}
