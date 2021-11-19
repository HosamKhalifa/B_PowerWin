using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("tax_group_member_setup")]
    public class TaxGroupMemberSetup:LineBase
    {
        #region ClassFieldNames
        [NotMapped]
        public static class TaxGroupMemberSetupFields
        {
            public static string TaxGroupId { get { return "TaxGroupId"; } }
            public static string TaxCodeId { get { return "TaxCodeId"; } }
            public static string IsDefault { get { return "IsDefault"; } }

        }
       #endregion
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
        [ForeignKey("TaxGroup"),Required]
        public long? TaxGroupId { get; set; }
        [ForeignKey("TaxCode"),Required]
        public long? TaxCodeId { get; set; }
        public bool IsDefault { get; set; }
        public virtual TaxGroup TaxGroup { get; set; }
        public virtual TaxCode TaxCode { get; set; }

    }
}
