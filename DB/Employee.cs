using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    [Table("Employee")]
  public class Employee:AccountBase
    {
        [StringLength(30)]
        public string IdentityCard { get; set; }
        [StringLength(30)]
        public string InsuranceNum { get; set; }



    }
}
