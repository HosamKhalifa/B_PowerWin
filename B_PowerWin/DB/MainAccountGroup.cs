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
    [Table("main_account_group")]
    public class MainAccountGroup:LineBase
    {
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
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.MainAccountGroup;
        }
        public override void OnCreate(AppDbContext _db)
        {
            BaseType = (int)BaseTypeEnum.MainAccountGroup;
            base.OnCreate(_db);
        }
        [StringLength(50),/*Display(ResourceType =typeof(Labels),Name ="GroupId")*/]
        public string GroupNum { get; set; }
        [Required,StringLength(100),/* Display(ResourceType = typeof(Labels), Name = "GroupName")*/]
        
        public string GroupName { get; set; }
        /*Display(ResourceType = typeof(Labels), Name = "MainAccountType")*/
        [StringLength(100)]
        public string GroupDescription { get; set; }
        [Required]
        public MainAccountTypeEnum MainAccountType { get; set; }
        public ICollection<MainAccount> MainAccounts { get; set; }
        [NotMapped]
        public string FullName { get { return $"{GroupNum} {GroupName}"; } }

    }
}
