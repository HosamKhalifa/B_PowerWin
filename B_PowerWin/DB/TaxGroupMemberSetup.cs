using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("tax_group_member_setup")]
    public class TaxGroupMemberSetup:LineBase
    {
        public override bool IsBusinessObject()
        {
            return true;
        }
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.TaxGroupMemberSetup;
        }
        public override void OnCreate(AppDbContext _db)
        {
            BaseType = (int)BaseTypeEnum.TaxGroupMemberSetup;
            base.OnCreate(_db);
        }
        public long? TaxGroupId { get; set; }
        public long? TaxCodeId { get; set; }
        public bool IsDefault { get; set; }

    }
}
