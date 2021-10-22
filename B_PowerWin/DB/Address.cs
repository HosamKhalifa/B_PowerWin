using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("account_address")]
    public class Address :LineBase
    {
        [StringLength(250)]
        public string Addr { get; set; }
        [StringLength(150)]
        public string ContactName { get; set; }
        public Country Country { get; set; }
        public City City { get; set; }
        public long? TaxGroup { get; set; }
        [StringLength(50)]
        public string TaxFileNum { get; set; }
        [StringLength(50)]
        public string TaxCardNum { get; set; }
        [StringLength(50)]
        public string TaxCommRegisterNum { get; set; }
    }
}
