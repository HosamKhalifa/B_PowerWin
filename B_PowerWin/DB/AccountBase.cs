using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace B_PowerWin.DB
{
    [Table("account_base")]
   public class AccountBase:LineBase
    {
      

        public int? CompanyId { get; set; }
        [StringLength(250), Required]
        public string Name { get; set; }
        [StringLength(50), Required]
        public string DisplayNum { get; set; }
        [StringLength(50)]
        public string ReferenceNum { get; set; }
        [StringLength(250), ]
        public string Description { get; set; }
        public long? GroupId { get; set; }
        public TaxGroup TaxGroup { get; set; }
        public long DisplayNumSequ { get; set; }
        public bool MainAccountSetManually { get; set; }
        public MainAccount MainAccount { get; set; }/*Item,Item Var will inherits from Group or From */
        public bool Suspended { get; set; }


    }
}
