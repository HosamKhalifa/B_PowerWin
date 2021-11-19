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
    [Table("Employee")]
  public class Employee:AccountBase
    {
        public static class EmployeeBaseFields
        {
            public static string IdentityCard { get { return "IdentityCard"; } }
            public static string InsuranceNum { get { return "InsuranceNum"; } }
            public static string Gender { get { return "Gender"; } }
            public static string MaritalState { get { return "MaritalState"; } }
            public static string Religion { get { return "Religion"; } }
            public static string BirthDate { get { return "BirthDate"; } }
            public static string StartDate { get { return "StartDate"; } }
            public static string EndDate { get { return "EndDate"; } }
            public static string BankAccountNum { get { return "BankAccountNum"; } }
            public static string BankId { get { return "BankId"; } }
            public static string Address { get { return "Address"; } }
            public static string Mob { get { return "Mob"; } }
            public static string Email { get { return "Email"; } }
            public static string CountryId { get { return "CountryId"; } }
            public static string CityId { get { return "CityId"; } }

}
public Employee():base()
        {

        }
        public override void BuildMetaData(AppDbContext _db)
        {
            //Base entity
            var le_BaseType = GetBaseTypeEnum();
            var lt_BaseType = new BaseType() { SequenceRequired=true,BaseTypeId = (int)le_BaseType, BaseTypeName = le_BaseType.ToString(), RecordTypeType = BaseTypeTypeEnum.Account };
            _db.BaseTypes.AddOrUpdate(lt_BaseType);

            //Security role
            var lt_Role = new SecPrincipalRoleMaster() { ObjectId = (int)le_BaseType, PrincipalId = $"{lt_BaseType.BaseTypeName}{lt_BaseType.RecordTypeType.ToString()}", PrincipalName = lt_BaseType.BaseTypeName, RoleType = SecAccessTypeTypeEnum.Master };
            _db.SecPrincipalRoleMasters.AddOrUpdate(lt_Role);
            //Sequence
            //Find if Sequence already existed
            string ls_sequLogicalKey = le_BaseType.ToString().ToUpper() + "_SEQU";
            var lt_DBTBaseType = _db.BaseTypes.Find((int)le_BaseType);
            var lt_DBSequ = _db.SysSequences.Where(x => x.SequNum == ls_sequLogicalKey).FirstOrDefault();
            if (lt_DBSequ == null && lt_DBTBaseType.SysSequenceId == null)
            {
                var lt_Sequ = new SysSequence()
                {
                    SysSequRecycle = SysSequRecycleEnum.Continuous,
                    SequNum = ls_sequLogicalKey,
                    SequName = le_BaseType.ToString() + " Sequence",
                    StartDate = new DateTime(DateTime.Today.Year, 1, 1),
                    StartValue = 1,
                    SequValueStringFormat = le_BaseType.ToString().ToUpper().Substring(0, 2) + "####"

                };
                _db.SysSequences.AddOrUpdate(lt_Sequ);
                _db.SaveChanges();
                _db.BaseTypes.Attach(lt_DBTBaseType);
                lt_DBTBaseType.SysSequenceId = lt_Sequ.Id;
                _db.Entry(lt_DBTBaseType).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();

            }
            base.BuildMetaData(_db);
        }
        public override bool IsBusinessObject()
        {
            return true;
        }
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.Employee;
        }
        public override void OnCreate(AppDbContext _db)
        {
            BaseType = (int)BaseTypeEnum.Employee;
            base.OnCreate(_db);
        }

        public virtual ICollection<DimDefault> DimDefaults { get; set; }

        [StringLength(30)]
        public string IdentityCard { get; set; }
        [StringLength(30)]
        public string InsuranceNum { get; set; }
        public EmployeeGenderEnum Gender { get; set; }
        public EmployeeMaritalStateEnum MaritalState { get; set; }
        public EmployeeReligionEnum Religion { get; set; }
        [Required]
        public DateTime? BirthDate { get; set; }
        [Required]
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        [StringLength(40)]
        public string BankAccountNum { get; set; }
        [ForeignKey("Bank")]
        public long?  BankId   { get; set; }
        [StringLength(200)]
        public string Address { get; set; }
        [StringLength(30)]
        public string Mob { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(5),ForeignKey("Country")]
        public string CountryId { get; set; }
        [ForeignKey("City")]
        public long? CityId { get; set; }
        [NotMapped]
        public bool IsRetired { get {return !EndDate.HasValue || (EndDate.HasValue && EndDate.Value < DateTime.Today.Date); }  }

        public virtual Bank Bank { set; get; }
        public virtual Country Country { set; get; }
        public virtual City City { set; get; }



    }
}
