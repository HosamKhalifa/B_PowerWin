using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("tax_group")]
    public class TaxGroup:LineBase
    {
        public override bool IsBusinessObject()
        {
            return true;
        }
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.TaxGroup;
        }
        public override void OnCreate(AppDbContext _db)
        {
            BaseType = (int)BaseTypeEnum.TaxGroup;
            base.OnCreate(_db);
        }
        public int? CompanyId { get; set; }
        [StringLength(50)]
        public string GroupName { get; set; }

    }
}
