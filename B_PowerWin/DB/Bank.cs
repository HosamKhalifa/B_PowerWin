using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("bank")]
    public class Bank:AccountBase
    {
        public override bool IsBusinessObject()
        {
            return true;
        }
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.Bank;
        }


        public override void OnCreate(AppDbContext _db)
        {
            this.BaseType = _db.BaseTypes.Find((int)BaseTypeEnum.Bank);
            base.OnCreate(_db);
        }
    }
}
