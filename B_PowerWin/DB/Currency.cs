using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("currency")]
    public class Currency
    {
        [Key,StringLength(5)]
        public string CurrCode { get; set; }
        [StringLength(30)]
        public string CurrName { get; set; }
    }
}
