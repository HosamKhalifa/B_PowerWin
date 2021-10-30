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
    [Table("sys_sequence")]
    public class SysSequence:LineBase, INotifyPropertyChanged
    {
        const char DIGIT_SYMBOL = '#';
        private string fSequNum;
        private string fSequName;
        private DateTime? fStartDate;
        private SysSequRecycleEnum fSysSequRecycle;
        private string fSequValueStringFormat;
        private int fStartValue;

        public event PropertyChangedEventHandler PropertyChanged;
        
        [NotMapped]
        public string DisplayTitle { get { return $"{SequNum} {SequName}"; } }
        private string FormatValue(int _Value)
        {
            string ls_Return = SequValueStringFormat;
            int li_Length = SequValueStringFormat.Count(x => x == DIGIT_SYMBOL);
            string ls_HashesToReplace = new string(DIGIT_SYMBOL, li_Length);
            string ls_Value = _Value.ToString().PadLeft(li_Length,'0');

            ls_Return = ls_Return.Replace(ls_HashesToReplace, ls_Value);
            return ls_Return;
        }
        public string NextVal(AppDbContext _context,DateTime? _date)
        {
            string ls_Ret = "";
            DateTime ld_Date = _date.HasValue ? _date.Value : DateTime.Today;
            SysSequenceValue lo_ValueLineSearch = new SysSequenceValue() { SequNum = this.SequNum };
            int li_Value = this.StartValue;
            switch (this.SysSequRecycle)
            {
                case SysSequRecycleEnum.Continuous:
                    lo_ValueLineSearch.CurrentRecycleValue = 0;
                    break;
                case SysSequRecycleEnum.Daily:
                    lo_ValueLineSearch.CurrentRecycleValue = (ld_Date.Year * 100) + ld_Date.Month;
                    break;
                case SysSequRecycleEnum.Yearly:
                    lo_ValueLineSearch.CurrentRecycleValue = (ld_Date.Year * 100);
                    break;
                default:
                    break;
            }
            var lo_SequLine = _context.SysSequenceValues.Find(lo_ValueLineSearch.SequNum, lo_ValueLineSearch.CurrentRecycleValue);
            if(lo_SequLine == null)
            {
                lo_ValueLineSearch.CurrentValue = this.StartValue;
                _context.SysSequenceValues.Add(lo_ValueLineSearch);
                _context.SaveChanges();
                ls_Ret = FormatValue(lo_ValueLineSearch.CurrentValue);
                return ls_Ret;
            }
            else
            {
                lo_SequLine.CurrentValue += 1;
                _context.Database.ExecuteSqlCommand($" UPDATE sys_sequence_value SET CurrentValue = CurrentValue + 1 WHERE ");

            }

            return ls_Ret;
        }
        public virtual ICollection<JournalType> JournalTypeLines { get; set; }

        public override bool IsBusinessObject()
        {
            return true;
        }
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.SysSequence;
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
            BaseType = (int)BaseTypeEnum.SysSequence;
            base.OnCreate(_db);
        }

        [StringLength(20),Index("sys_sequence_SequNum_uq",IsUnique =true)]
        public string SequNum { get { return fSequNum; } set { fSequNum = value; OnPropertyChanged(); } }
        [StringLength(100),Required]
        public string SequName { get { return fSequName; } set { fSequName = value;OnPropertyChanged(); } }
        [Required]
        public DateTime? StartDate { get { return fStartDate; } set { fStartDate = value;OnPropertyChanged(); } }
        
        public SysSequRecycleEnum SysSequRecycle { get { return fSysSequRecycle; } set { fSysSequRecycle = value;OnPropertyChanged(); } }
        [Required]
        public int StartValue { get { return fStartValue; } set { fStartValue = value;OnPropertyChanged(); } }
        [StringLength(30)]
        public string SequValueStringFormat { get { return fSequValueStringFormat; } set { fSequValueStringFormat = value;OnPropertyChanged(); } }
        
        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


    }
}
