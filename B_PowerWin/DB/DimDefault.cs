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
        [ForeignKey("BusinessUnit")]
        public long? BusinessUnitId { get; set; }
        [ForeignKey("Site")]
        public long? SiteId { get; set; }
        [ForeignKey("Department")]
        public long? DeptId { get; set; }
        [ForeignKey("Equipment")]
        public long? EqupId { get; set; }
        [ForeignKey("Project")]
        public long? ProjectId { get; set; }
        [ForeignKey("Purpose")]
        public long? PurposeId { get; set; }
        [ForeignKey("Bank")]
        public long? BankId { get; set; }
        [ForeignKey("Cash")]
        public long? CashId { get; set; }
        [ForeignKey("Customer")]
        public long? CustId { get; set; }
        [ForeignKey("Vendor")]
        public long? VendId { get; set; }
        [ForeignKey("Employee")]
        public long? EmplId { get; set; }
        [ForeignKey("Pos")]
        public long? PosId { get; set; }

        #region Virtuales
        public virtual BusinessUnit BusinessUnit { get; set; }
        public virtual Site Site { get; set; }

        public virtual Department Department { get; set; }
        public virtual Equipment Equipment { get; set; }
        public virtual Project Project { get; set; }
        public virtual Purpose Purpose { get; set; }

        public virtual Bank Bank{ get; set; }
        public virtual Cash Cash { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Pos Pos { get; set; }

        #endregion

    }
}
