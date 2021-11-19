using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("country")]
   public class Country
    {
        [Key,StringLength(5)]
        public string IsoCode { get; set; }
        [StringLength(50),Required]
        public string Name { get; set; }
        public virtual ICollection<City> Cites { get; set; }
        public virtual ICollection<AccountBase> Accounts { get; set; }
        public virtual ICollection<DocumentBase> Documents { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
