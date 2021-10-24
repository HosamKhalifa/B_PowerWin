using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("main_account_group")]
    public class MainAccountGroup:LineBase
    {
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.MainAccountGroup;
        }
        [StringLength(50),/*Display(ResourceType =typeof(Labels),Name ="GroupId")*/]
        public string GroupNum { get; set; }
        [Required,StringLength(100),/* Display(ResourceType = typeof(Labels), Name = "GroupName")*/]
        
        public string GroupName { get; set; }
        /*Display(ResourceType = typeof(Labels), Name = "MainAccountType")*/
        public MainAccountTypeEnum MainAccountType { get; set; }
        public ICollection<MainAccount> MainAccounts { get; set; }

    }
}
