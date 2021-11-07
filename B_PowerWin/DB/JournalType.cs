using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("journal_type")]
    public class JournalType:LineBase,INotifyPropertyChanged
    {
        private JournalTypeEnum fJourType;
        private string fJourName;
        private PostingLayerEnum fPostingLayer;
        private long? fSequId;
        private bool fSequGenerateAtPosting;
        private bool fAmountsInclueTax;
        private JournalTypeDetailSummaryEnum fDetailSummary;
        private SysSequence fSysSequence;

        public event PropertyChangedEventHandler PropertyChanged;

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
            return BaseTypeEnum.JournalType;
        }
        public override void OnCreate(AppDbContext _db)
        {
            BaseType = (int)BaseTypeEnum.JournalType;
            base.OnCreate(_db);
        }

        
        public virtual ICollection<LedgerJournal> LedgerJournals { get; set; }
        public virtual ICollection<DocumentBase>  Documents { get; set; }

        public string JourDocumentNextValue(AppDbContext _dbContext,DateTime? _date, out long? _SequVersionId)
        {
            string ls_Ret;
            var Seq = _dbContext.SysSequences.Find(fSequId);
            if (Seq == null)
            {
                _SequVersionId = null;
                return "";
            }
            ls_Ret = Seq.NextVal(_dbContext, _date, out _SequVersionId);
            return ls_Ret;
        }

        public int? CompanyId { get; set; }
        [Required]
        public JournalTypeEnum JourType { get { return fJourType; } set { fJourType = value;OnPropertyChanged(); } }
        [StringLength(100), Required]
        public string JourName { get { return fJourName; } set { fJourName = value;OnPropertyChanged(); } }
        public PostingLayerEnum PostingLayer { get { return fPostingLayer; } set { fPostingLayer = value;OnPropertyChanged(); } }
      //  [ForeignKey("SysSequence")]
        public long? SequId { get { return fSequId; } set { fSequId = value;OnPropertyChanged(); } }
        
        public virtual SysSequence SysSequence { get { return fSysSequence; } set { fSysSequence = value;OnPropertyChanged(); } }
        public bool SequGenerateAtPosting { get { return fSequGenerateAtPosting; } set { fSequGenerateAtPosting = value;OnPropertyChanged(); } }

        public JournalTypeDetailSummaryEnum DetailSummary { get { return fDetailSummary; } set { fDetailSummary = value;OnPropertyChanged(); } }
        public bool AmountsInclueTax { get { return fAmountsInclueTax; } set { fAmountsInclueTax = value;OnPropertyChanged(); } }

        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }



    }
}
