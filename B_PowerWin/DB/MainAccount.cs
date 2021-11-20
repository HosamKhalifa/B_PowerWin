using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;

namespace B_PowerWin.DB
{
    [Table("main_account")]
    public class MainAccount:AccountBase
    {
        #region ClassFieldNames
        [NotMapped]
        public static class MainAccountFields
        {
            public static string LedgerCOAId { get { return "LedgerCOAId"; } }
            public static string MainAccountType { get { return "MainAccountType"; } }
            public static string MainAccountGroupId { get { return "MainAccountGroupId"; } }
            public static string BalanceControl { get { return "BalanceControl"; } }
            public static string DisableManualEntry { get { return "DisableManualEntry"; } }
            public static string RequiredBusinessUnit { get { return "RequiredBusinessUnit"; } }
            public static string RequiredSite { get { return "RequiredSite"; } }
            public static string RequiredDept { get { return "RequiredDept"; } }
            public static string RequiredEquipment { get { return "RequiredEquipment"; } }
            public static string RequiredProject { get { return "RequiredProject"; } }
            public static string RequiredPurpose { get { return "RequiredPurpose"; } }
            public static string RequiredBank { get { return "RequiredBank"; } }
            public static string RequiredCash { get { return "RequiredCash"; } }
            public static string RequiredCustomer { get { return "RequiredCustomer"; } }
            public static string RequiredVendor { get { return "RequiredVendor"; } }
            public static string RequiredEmployee { get { return "RequiredEmployee"; } }
            public static string RequiredPos { get { return "RequiredPos"; } }
            public static string IsTotal { get { return "IsTotal"; } }

            }
            #endregion
public MainAccount():base()
        {
            this.BalanceControl = MainAccountBalanceControlEnum.None;
            this.DisableManualEntry = false;
            this.IsTotal = false;
            this.RequiredBusinessUnit = false;
            this.RequiredSite = false;
            this.RequiredDept = false;
            this.RequiredEquipment = false;
            this.RequiredProject = false;
            this.RequiredPurpose = false;
            this.RequiredBank = false;
            this.RequiredCash = false;
            this.RequiredCustomer = false;
            this.RequiredVendor = false;
            this.RequiredEmployee = false;
            this.RequiredPos = false;
            this.CompanyId = MySession.Session.Company.Id;
            this.LedgerCOAId = MySession.Session.Company.COA;



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
        public override bool IsBusinessObject()
        {
            return true;
        }
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.MainAccount;
        }
        public override void OnCreate(AppDbContext _db)
        {
            BaseType = (int)BaseTypeEnum.MainAccount;
            if (ParnetId.HasValue)
            {
                var parnet = _db.MainAccounts.Find(ParnetId);
                
                MainAccountType = parnet.MainAccountType;
                
            }
            base.OnCreate(_db);
        }
        [NotMapped]
        public string FullName { get { return $"{ReferenceNum} {Name}"; } }

        [Required,ForeignKey("LedgerCOA")]
        public int? LedgerCOAId { get; set; }
        public virtual LedgerCOA LedgerCOA { get; set; }
        public MainAccountTypeEnum MainAccountType { get; set; }
        [ForeignKey("MainAccountGroup")]
        public long? MainAccountGroupId { get; set; }

        public MainAccountBalanceControlEnum BalanceControl { get; set; }
        [Required]
        public bool DisableManualEntry { get; set; }
        public bool RequiredBusinessUnit { get; set; }
        public bool RequiredSite { get; set; }
        public bool RequiredDept { get; set; }
        public bool RequiredEquipment { get; set; }
        public bool RequiredProject { get; set; }
        public bool RequiredPurpose { get; set; }
        public bool RequiredBank { get; set; }
        public bool RequiredCash { get; set; }
        public bool RequiredCustomer { get; set; }
        public bool RequiredVendor { get; set; }
        public bool RequiredEmployee { get; set; }
        public bool RequiredPos { get; set; }
        public bool IsTotal { get; set; }
        
        public virtual MainAccountGroup MainAccountGroup { get; set; }
    }
}
