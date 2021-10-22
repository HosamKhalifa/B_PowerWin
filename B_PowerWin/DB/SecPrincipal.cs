using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("sec_principal")]
    public class SecPrincipal
    {
        public virtual bool IsBusinessObject()
        {
            /*Business object is an Entity class which represent securable, updatable and displayed to user
               Eeach Entity class which will be BO need to override this method to return true
               Each enity has true value will be creating securable mapping record */
            return false;
        }
        public virtual BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.None;
        }
        [Key,StringLength(120)]
        public string PrincipalId { get; set; }
        [StringLength(120)]
        public string PrincipalName { get; set; }
       


    }
}
