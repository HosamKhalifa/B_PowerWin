using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    [Table("sec_principal_role")]
    public class SecPrincipalRole:SecPrincipal
    {
        public SecAccessTypeTypeEnum RoleType { get; set; }
        public long? ObjectId { get; set; }



    }
}
