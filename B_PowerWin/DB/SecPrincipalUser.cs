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
    [Table("sec_principal_user")]
    public class SecPrincipalUser:SecPrincipal
    {
        public SecPrincipalUser()
        {
            
        }
        private string fPwd;

        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.SecPrincipalUser;
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
            UserKey = _db.Database.SqlQuery<int?>("SELECT Max(UserKey) + 1 FROM sec_principal_user").FirstOrDefault();
            RoleType = SecAccessTypeTypeEnum.User;
            Pwd = "";
            base.OnCreate(_db);
        }
        public override void OnUpdate(AppDbContext _db)
        {
            Pwd = Cryptography.Encrypt(Pwd);
            base.OnUpdate(_db);
        }
       
        public int? UserKey { get; set; }
        public long? EmplId { get; set; }
        [StringLength(500)]
        public string Pwd { get { return fPwd; } set { fPwd = value; } }
        public byte[] UserImage { get; set; }
        public int? DefaultCompany { get; set; }
        public long? LastUserJob { get; set; }
        [Required]
        public DateTime? EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
        [StringLength(50)]
        public string SkinName { get; set; }
        [StringLength(10)]
        public string  LangId { get; set; }


    }
}
