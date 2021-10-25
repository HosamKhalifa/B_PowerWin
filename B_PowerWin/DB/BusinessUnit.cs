using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("business_unit")]
    public class BusinessUnit:LineBase
    {
        public override bool IsBusinessObject()
        {
            return true;
        }
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.BusinessUnit;
        }
        public override void OnCreate(AppDbContext _db)
        {
            this.BaseType = (int)BaseTypeEnum.BusinessUnit;
            base.OnCreate(_db);
        }

       

        [StringLength(10),Index("business_unit_code_uq",IsUnique =true)]
        public string BusinessUnitCode { get; set; }
        [StringLength(50), Index("business_unit_name_uq", IsUnique = true)]
        public string BusinessUnitName { get; set; }
        public virtual ICollection<DimDefault> DimDefaults { get; set; }
        public virtual ICollection<InventDimDefault> InventDimDefaults { get; set; }


    }
}
