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
    [Table("tax_group")]
    public class TaxGroup:LineBase
    {
        #region ClassFieldNames
        [NotMapped]
        public static class TaxGroupFields
        {
            public static string GroupNum { get { return "GroupNum"; } }
            public static string GroupName { get { return "GroupName"; } }
            
        }
        #endregion
        public override bool IsBusinessObject()
        {
            return true;
        }
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.TaxGroup;
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
            BaseType = (int)BaseTypeEnum.TaxGroup;
            base.OnCreate(_db);
        }
        [StringLength(30),Index("tax_grpup_group_num_uq",IsUnique =true)]
        public string GroupNum { get; set; }
        public int? CompanyId { get; set; }
        [StringLength(50)]
        public string GroupName { get; set; }
        public virtual ICollection<TaxGroupMemberSetup> Members { get; set; }
        public virtual ICollection<DocumentBase> Documents { get; set; }
        public string FullName { get { return $"{GroupNum} {GroupName}"; } }

    }
}
