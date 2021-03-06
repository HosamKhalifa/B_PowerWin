using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    [Table("item_color")]
    public class ItemColor:LineBase
    {
        #region ClassFieldNames
        [NotMapped]
        public static class ItemColorFields
        {
            public static string ItemInventoryId { get { return "ItemInventoryId"; } }
            public static string ColorEnum { get { return "ColorEnum"; } }
            public static string ItemColorName { get { return "ItemColorName"; } }
            
        }
        #endregion
        public ItemColor():base()
        {

        }
        public override void BuildMetaData(AppDbContext _db)
        {
            //Base entity
            var le_BaseType = GetBaseTypeEnum();
            var lt_BaseType = new BaseType() { BaseTypeId = (int)le_BaseType, BaseTypeName = le_BaseType.ToString(), RecordTypeType = BaseTypeTypeEnum.Account };
            _db.BaseTypes.AddOrUpdate(lt_BaseType);

            //Security role
            var lt_Role = new SecPrincipalRoleMaster() { ObjectId = (int)le_BaseType, PrincipalId = $"{lt_BaseType.BaseTypeName}{lt_BaseType.RecordTypeType.ToString()}", PrincipalName = lt_BaseType.BaseTypeName, RoleType = SecAccessTypeTypeEnum.Master };
            _db.SecPrincipalRoleMasters.AddOrUpdate(lt_Role);
            base.BuildMetaData(_db);
        }
        public override bool IsBusinessObject()
        {
            return true;
        }
        public override BaseTypeEnum GetBaseTypeEnum()
        {
            return BaseTypeEnum.ItemColor;
        }
        public override void OnCreate(AppDbContext _db)
        {
            BaseType = (int)BaseTypeEnum.ItemColor;
            base.OnCreate(_db);
        }
        public virtual ICollection<InventDimDefault> InventDimDefaults { get; set; }
        public virtual ICollection<ItemVariants> ItemVariants { get; set; }

        [Required, ForeignKey("ItemInventory")]
        public long? ItemInventoryId { get; set; }
        public virtual ItemInventory ItemInventory { get; set; }
        public ItemColorEnum ColorEnum { get; set; }
        [StringLength(60)]
        public string ItemColorName { get; set; }
        
    }
}
