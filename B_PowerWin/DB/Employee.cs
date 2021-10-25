using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("Employee")]
  public class Employee:AccountBase
    {
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



    }
}
