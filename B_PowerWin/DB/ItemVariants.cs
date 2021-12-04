using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("item_variants")]
    public class ItemVariants:AccountBase
    {
        #region ClassFieldNames
        [NotMapped]
        public static class ItemVariantsFields
        {
            public static string PurchPrice { get { return "PurchPrice"; } }
            public static string SalesPrice { get { return "SalesPrice"; } }
            public static string SalesPriceMin { get { return "SalesPriceMin"; } }
            public static string BuyFromCustomer { get { return "BuyFromCustomer"; } }
            public static string ItemInventoryId { get { return "ItemInventoryId"; } }
            public static string ItemSizeId { get { return "ItemSizeId"; } }
            public static string ItemColorId { get { return "ItemColorId"; } }
           

}

#endregion
public ItemVariants():base()
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
                    SequValueStringFormat = "IIV####"

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
            return BaseTypeEnum.ItemVariants;
        }
        public override void OnCreate(AppDbContext _db)
        {
            BaseType = (int)BaseTypeEnum.ItemVariants;
            //string ls_SizeName  = this.ItemSize != null ? this.ItemSize.ItemSizeName : string.Empty;
            //string ls_ColorName = this.ItemColor != null ? this.ItemColor.ItemColorName : string.Empty;
            //Name should be always calculated from Item Name+Size Name + Color Name
            //string ls_VarName = $"{this.ItemInventory.Name} {ls_SizeName} {ls_ColorName}";
            this.Name = this.FullName;//ls_VarName;
            base.OnCreate(_db);
        }
        public override void OnUpdate(AppDbContext _db, DbEntityEntry _entryStatus)
        {
            //Prohibting any updates on varianys columns
            var li_ItemInventoryId  = _entryStatus.OriginalValues.GetValue<long?>(ItemVariantsFields.ItemInventoryId);
            var li_ItemSizeId       = _entryStatus.OriginalValues.GetValue<long?>(ItemVariantsFields.ItemSizeId);
            var li_ItemColorId      = _entryStatus.OriginalValues.GetValue<long?>(ItemVariantsFields.ItemColorId);

            var lt_ItemInventory    = _db.ItemInventorys.Find(li_ItemInventoryId);
            var lt_ItemSize         = _db.ItemInventorys.Find(li_ItemSizeId);
            var lt_ItemColor        = _db.ItemInventorys.Find(li_ItemColorId);

            this.ItemInventoryId    = li_ItemInventoryId;
            this.ItemSizeId         = li_ItemSizeId;
            this.ItemColorId        = li_ItemColorId;

            //Name should be always calculated from Item Name+Size Name + Color Name
            string ls_VarName = $"{lt_ItemInventory.Name} {lt_ItemSize.Name} {lt_ItemColor.Name}";
            this.Name = ls_VarName;
            base.OnUpdate(_db,_entryStatus);
        }
        public virtual ICollection<InventDimDefault> InventDimDefaults { get; set; }
        public virtual ICollection<ItemInventoryBarcode> ItemInventoryBarcodes { get; set; }
        public decimal? PurchPrice { get; set; }
        public decimal? SalesPrice { get; set; }
        public decimal? SalesPriceMin { get; set; }
        public bool BuyFromCustomer { get; set; }
        [ForeignKey("ItemInventory")]
        public long? ItemInventoryId { get; set; }
        [ForeignKey("ItemSize")]
        public long? ItemSizeId { get; set; }
        [ForeignKey("ItemColor")]
        public long? ItemColorId { get; set; }
        public virtual ItemInventory ItemInventory { get; set; }
        public virtual ItemSize ItemSize { get; set; }
        public virtual ItemColor ItemColor { get; set; }


    }
}
