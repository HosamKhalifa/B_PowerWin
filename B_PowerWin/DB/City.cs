using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("city")]
    public class City
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long? CityId { get; set; }
        [StringLength(50),Required]
        public string CityName { get; set; }
        [Required]
        public Country Country { get; set; }
        public virtual ICollection<Employee> Employees{ get; set; }

    }
}
