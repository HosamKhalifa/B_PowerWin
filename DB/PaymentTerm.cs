using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    [Table("payment_term")]
    public class PaymentTerm:LineBase
    {
        [StringLength(30)]
        public string PaymTermCode { get; set; }
        [StringLength(60)]
        public string PaymTermName { get; set; }
        [Range(0,100)]
        public decimal? DownPaymentPercentage { get; set; }
        public int? PaymentsCount { get; set; }
        public int? DaysBetweenPayments { get; set; }


    }
}
