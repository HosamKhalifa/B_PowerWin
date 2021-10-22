using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    [Table("doc_gl")]
   public class DocumentGL:DocumentBase
    {
        public decimal? DocTotalCC { get; set; }
        [StringLength(5)]
        public string CurrencyCode { get; set; }
        [Required]
        public decimal? CurrencyExch { get; set; }
        public decimal? DocTotalFC { get; set; }

        

    }
}
