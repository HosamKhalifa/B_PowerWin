using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("tax_code")]
    public class TaxCode:LineBase
    {
        #region ClassFieldNames
        [NotMapped]
        public static class TaxCodeFields
        {
            public static string CompanyId { get { return "CompanyId"; } }
            public static string TaxCodeId { get { return "TaxCodeId"; } }
            public static string TaxCodeName { get { return "TaxCodeName"; } }
            public static string ArTaxAccount { get { return "ArTaxAccount"; } }
            public static string ApTaxAccount { get { return "ApTaxAccount"; } }
            public static string SettlementTaxAccount { get { return "SettlementTaxAccount"; } }

        }
        #endregion
        public override bool IsBusinessObject()
        {
            return true;
        }
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.TaxCode;
        }
        public override void BuildMetaData(AppDbContext _db)
        {
            //Base entity
            var le_BaseType = GetBaseTypeEnum();
            var lt_BaseType = new BaseType() { BaseTypeId = (int)le_BaseType, BaseTypeName = le_BaseType.ToString(), RecordTypeType = BaseTypeTypeEnum.Account };
            _db.BaseTypes.AddOrUpdate(lt_BaseType);

            //Security role
            var lt_Role = new SecPrincipalRoleMaster() { ObjectId = (int)le_BaseType, PrincipalId = $"{lt_BaseType.BaseTypeName}{lt_BaseType.RecordTypeType.ToString()}", PrincipalName = lt_BaseType.BaseTypeName, RoleType = SecAccessTypeTypeEnum.Master };
            _db.SecPrincipalRoleMasters.AddOrUpdate(lt_Role);
            base.BuildMetaData(_db);
        }
        public override void OnCreate(AppDbContext _db)
        {
            BaseType = (int)BaseTypeEnum.TaxCode;
            base.OnCreate(_db);
        }
        public int? CompanyId { get; set; }
        [StringLength(10)]
        public string TaxCodeId { get; set; }
        [StringLength(100)]
        public string TaxCodeName { get; set; }
        public MainAccount ArTaxAccount { get; set; }
        public MainAccount ApTaxAccount { get; set; }
        public MainAccount SettlementTaxAccount { get; set; }
        public virtual ICollection<TaxGroupMemberSetup> Members { get; set; }
        public virtual ICollection<TaxCodeValueSetup> Values { get; set; }
        public string FullName { get { return $"{TaxCodeId} {TaxCodeName}"; } }
    }
}
