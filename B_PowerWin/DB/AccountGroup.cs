using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("account_group")]
    public class AccountGroup:AccountBase
    {
        public override bool IsBusinessObject()
        {
            return true;
        }
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.AccountGroup;
        }
        public override void OnCreate(AppDbContext _db)
        {
            BaseType = (int)BaseTypeEnum.AccountGroup;
            base.OnCreate(_db);
        }
        public virtual ICollection<InventDimDefault> InventDimDefaults { get; set; }
        
        [Required]
        public BaseType GroupedBaseType { get; set; }


    }
}
