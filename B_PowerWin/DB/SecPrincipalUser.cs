using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("sec_principal_user")]
    public class SecPrincipalUser:SecPrincipal
    {
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.SecPrincipalUser;
        }
        [Required]
        public int? UserKey { get; set; }
        public long? EmplId { get; set; }
        [StringLength(500)]
        public string Pwd { get; set; }
        public byte[] UserImage { get; set; }
        public int? DefaultCompany { get; set; }
        public long? LastUserJob { get; set; }
        public DateTime? EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }

    }
}
