using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("dim_default")]
    public class DimDefault
    {
        [Key]
        public long? Id { get; set; }/*The reference Document or JournalType Cust,Vend,Employee*/
        public long? BusinessUnit { get; set; }
        public long? SiteId { get; set; }
        public long? DeptId { get; set; }
        public long? EqupId { get; set; }
        public long? ProjectId { get; set; }
        public long? PurposeId { get; set; }

        public long? BankId { get; set; }
        public long? CustId { get; set; }
        public long? VendId { get; set; }
        public long? EmplId { get; set; }
        public long? PosId { get; set; }
    }
}
