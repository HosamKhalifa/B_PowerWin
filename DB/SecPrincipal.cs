using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    [Table("sec_principal")]
    public class SecPrincipal
    {
        [Key,StringLength(120)]
        public string PrincipalId { get; set; }
        [StringLength(120)]
        public string PrincipalName { get; set; }
       


    }
}
