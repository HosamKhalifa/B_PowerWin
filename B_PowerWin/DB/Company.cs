using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("company")]
    public class Company
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None),Range(1001,9999)]
        public int? Id { get; set; }
        [StringLength(100), Required]
        public string CompanyName { get; set; }
        [StringLength(250), Required]
        public string Address { get; set; }
        [StringLength(50), Required]
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        [StringLength(50), Required]
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
        [StringLength(5)]
        public string Currency { get; set; }
        public int? Calender { get; set; }
        public int? COA { get; set; }
      
    }
}
