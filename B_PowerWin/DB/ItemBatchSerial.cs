using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("item_batch_serial")]


    public class ItemBatchSerial:LineBase
    {
        public override bool IsBusinessObject()
        {
            return true;
        }
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.ItemBatchSerial;
        }
        public override void OnCreate(AppDbContext _db)
        {
            BaseType = (int)BaseTypeEnum.ItemBatchSerial;
            base.OnCreate(_db);
        }
        [StringLength(60)]
        public string SerialNum { get; set; }
        [StringLength(30)]
        public string SerialReference { get; set; }
        public ItemSerialStatusEnum ItemSerialStatus { get; set; }
        public long? ItemBatch { get; set; }
        public long? CustId { get; set; }
        [StringLength(100)]
        public string CustName { get; set; }
        public long? PosId { get; set; }


    }
}
