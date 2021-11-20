using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;

namespace B_PowerWin.DB
{
    [Table("account_base")]
   public class AccountBase:LineBase
    {
        #region CalssFieldNames
        [NotMapped]
        public static class AccountBaseFields
        {
            
            public static string CompanyId { get { return "CompanyId"; } }
            public static string Description { get { return "Description"; } }
            public static string DimDefaults { get { return "DimDefaults"; } }
            public static string DisplayNum { get { return "DisplayNum"; } }
            public static string DisplayNumSequ { get { return "DisplayNumSequ"; } }
            public static string DisplayNumSequVersion { get { return "DisplayNumSequVersion"; } }
            public static string GroupId { get { return "GroupId"; } }
            public static string MainAccount { get { return "MainAccount"; } }
            public static string MainAccountId { get { return "MainAccountId"; } }
            public static string MainAccountSetManually { get { return "MainAccountSetManually"; } }
            public static string Name { get { return "Name"; } }
            public static string ParnetId { get { return "ParnetId"; } }
            public static string ReferenceNum { get { return "ReferenceNum"; } }
            public static string Suspended { get { return "Suspended"; } }
            public static string TaxGroupId { get { return "TaxGroupId"; } }
        }

        #endregion
        public AccountBase():base()
        {
            
            DisplayNumSequVersion = 0;
            DisplayNum = "0";
            MainAccountSetManually = false;
            Suspended = false;
            CompanyId = MySession.Session.Company.Id;
            
        }
        public virtual void ApplyWFAction(AppDbContext _db,WorkflowStep _action)
        {
            if(this.DisplayNumSequVersion == 0 && _action == WorkflowStep.Approve)
            {
                SysSequence.NextValAccountBase(_db, this);
            }
        }
        public override void OnCreate(AppDbContext _db)
        {
            string ls_ParentIds = "";
            string ls_ParentNames = "";

            base.OnCreate(_db);
           
            if (ParnetId.HasValue && ParnetId != 0)
            {
                    var parentLine = _db.Accounts.Find(ParnetId);
                    if (parentLine != null)
                    {
                        ls_ParentIds = $"{parentLine.ParentIdList}-{Id}";
                        ls_ParentNames = $"{parentLine.ParentNameList}-{(Name.Substring(0, Math.Min(50, Name.Length )))}";
                    }

            }
            else
            {
                ls_ParentIds = $"{Id}-";
                ls_ParentNames = $"{(Name.Substring(0, Math.Min(50, Name.Length )))}-";
            }

            ParentIdList = ls_ParentIds;
            ParentNameList = ls_ParentNames;


        }
        public override void OnUpdate(AppDbContext _db, DbEntityEntry _entryStatus)
        {
            string ls_ParentIds = "";
            string ls_ParentNames = "";

            base.OnUpdate(_db,_entryStatus);

            if (ParnetId.HasValue && ParnetId != 0)
            {
                var parentLine = _db.Accounts.Find(ParnetId);
                if (parentLine != null)
                {
                    ls_ParentIds = $"{parentLine.ParentIdList}-{Id}";
                    ls_ParentNames = $"{parentLine.ParentNameList}-{(Name.Substring(0, Math.Min(50, Name.Length )))}";
                }

            }
            else
            {
                ls_ParentIds = $"{Id}-";
                ls_ParentNames = $"{(Name.Substring(0, Math.Min(50, Name.Length )))}-";
            }

            ParentIdList = ls_ParentIds;
            ParentNameList = ls_ParentNames;


        }
        [NotMapped]
        public virtual string FullName { get { return $"{ReferenceNum} {Name} {(GroupId.HasValue?AccountGroup.FullName:"") }"; } }
        public int? CompanyId { get; set; }
        [StringLength(250), Required]
        
        public string Name { get; set; }
        [StringLength(50)]
        public string DisplayNum { get; set; }
        [StringLength(50)]
        public string ReferenceNum { get; set; }
        [StringLength(250), ]
        public string Description { get; set; }
        [ForeignKey("AccountGroup")]
        public long? GroupId { get; set; }
        [ForeignKey("TaxGroup")]
        public long? TaxGroupId { get; set; }

        public long DisplayNumSequVersion { get; set; }

        public bool MainAccountSetManually { get; set; }
        [ForeignKey("MainAccount")]
        public long? MainAccountId { get; set; }/*Item,Item Var will inherits from Group or From */
        public bool Suspended { get; set; }

        long? fParnetId;
        public long? ParnetId
        {
            get { return fParnetId; }
            set
            {
                fParnetId = value;


            }
        }
        [StringLength(500)]
        public string ParentIdList { get; private set; }
        [StringLength(1000)]
        public string ParentNameList { get; private set; }

        public virtual MainAccount MainAccount { get; set; }
        public virtual AccountGroup AccountGroup { get; set; }
        public virtual TaxGroup TaxGroup { get; set; }

    }
}
