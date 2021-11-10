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
    public class AccountGroup:LineBase
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
            BaseType = (int)GetBaseTypeEnum();
            base.OnCreate(_db);
        }
        public virtual ICollection<InventDimDefault> InventDimDefaults { get; set; }
        public virtual ICollection<AccountBase> Accounts { get; set; }

      
      
        [StringLength(30),Required,Index(name:"AccountGroup_ReferenceNum_UQ",IsUnique =true,Order =0)]
        public string ReferenceNum { get; set; }
        [StringLength(100), Required, Index(name: "AccountGroup_Name_UQ", IsUnique = true, Order = 0)]
        public string Name { get; set; }
        [Required,Index(name: "AccountGroup_ReferenceNum_UQ", IsUnique = true, Order = 1), Index(name: "AccountGroup_Name_UQ", IsUnique = true, Order = 1)]
        public int GroupedBaseTypeId { get; set; }
        [NotMapped]
        public virtual BaseType GroupedBaseType { get; set; }
        [NotMapped]
        public string FullName { get { return $"{ReferenceNum} {Name}"; } }



    }
}
