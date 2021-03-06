using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("sec_principal_role_mem")]
    public class SecPrincipalRoleMem:LineBase
    {
        public override bool IsBusinessObject()
        {
            return true;
        }
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.SecPrincipalRoleMem;
        }
        public override void OnCreate(AppDbContext _db)
        {
            BaseType = (int)BaseTypeEnum.SecPrincipalRoleMem;
            base.OnCreate(_db);
        }
        [StringLength(120),ForeignKey("RoleRef")]
        public string RolePrincipalId { get; set; }
        [StringLength(120),ForeignKey("MemberRef")]
        public string MemberPrincipalId { get; set; }
        [ForeignKey("AccessTypeRef")]
        public int? AccessType { get; set; }
        public DateTime? EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }

        public virtual SecPrincipal MemberRef { get; set; }
        public virtual SecPrincipalRole RoleRef { get; set; }
        public virtual SecAccessType AccessTypeRef { get; set; }

    }
}
