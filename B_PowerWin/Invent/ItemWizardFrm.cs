using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using B_PowerWin.DB;
using B_PowerWin.GUI.CustomLookup;
using B_PowerWin.GUI.Grid;
using DevExpress.XtraEditors;
using B_PowerWin.SharedExt;
using System.Data.Entity.Migrations;

namespace B_PowerWin.Invent
{
    public partial class ItemWizardFrm : Form
    {
        AppDbContext dbContext;
        GridManager formGridManager;
        public ItemInventory ItemInventory { get; set; }
        public List<ItemSize> ItemSizeList { get; set; }
        public List<ItemColor> ItemColorList { get; set; }

        public List<ItemVariants> ItemVariantList { get; set; }
        public bool PersistChanges()
        {
            bool lb_Success = true;
            try
            {

                var lcontxt = new AppDbContext();

                lcontxt.ItemInventorys.AddOrUpdate(ItemInventory);
                lcontxt.ItemSizes.AddOrUpdate(ItemSizeList.ToArray());
                lcontxt.ItemColors.AddOrUpdate(ItemColorList.ToArray());
                lcontxt.ItemVariants.AddOrUpdate(ItemVariantList.ToArray());
                lcontxt.SaveChanges();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.GetFullExceptionErrMessage());
                lb_Success = false;
            }
            return lb_Success;
        }
        public ItemWizardFrm()
        {
            InitializeComponent();
            InitData();
            InitEvents();
        }
        private void BuildItemVariants()
        {
            ItemVariantList = dbContext.ItemVariants.Where(x => x.ItemInventoryId == this.ItemInventory.Id).ToList();
            //Build item vars
            var la_itemSizeArray  = ItemSizeList.Count  > 0 ? ItemSizeList.Select(x => x.Id).ToList():new List<long?>() { null};
            var la_itemColorArray = ItemColorList.Count > 0 ? ItemColorList.Select(x => x.Id).ToList(): new List<long?>() { null};
            var ls_SizeName = "";
            var ls_ColorName = "";        
            foreach (var sizeLine in la_itemSizeArray)
            {
                ls_SizeName  = sizeLine != null ? this.ItemSizeList.Single(x => x.Id == sizeLine).ItemSizeName : "";
                

                foreach (var colorLine in la_itemColorArray)
                {
                    ls_ColorName = colorLine != null ? this.ItemColorList.Single(x => x.Id == colorLine).ItemColorName:"";
                    var lb_IsExisted = ItemVariantList.Exists(x => x.ItemSizeId == sizeLine && x.ItemColorId == colorLine);
                    if (!lb_IsExisted)
                    {
                            ItemVariantList.Add(new ItemVariants() {
                            Id = DB_Util.LineBaseSequNextVal(dbContext),
                            ItemInventoryId = this.ItemInventory.Id,
                            ItemSizeId = sizeLine,
                            ItemColorId=colorLine,
                            Name = $"{ItemInventory.Name} {ls_SizeName} {ls_ColorName}",
                            ReferenceNum = ItemInventory.ReferenceNum,
                            PurchPrice =ItemInventory.PurchPrice,
                            SalesPrice = ItemInventory.SalesPrice,
                            SalesPriceMin = ItemInventory.SalesPriceMin,
                            BuyFromCustomer = false
                            
                        });
                    }
                }
            }
            itemVariantsBindingSource.DataSource = ItemVariantList;
        }
        private void InitEvents()
        {
            wizardControl1.CancelClick += (s, e) => {
                this.Close();
            };
            itemSizeBindingSource.AddingNew += (s, e) => {
                e.NewObject = new ItemSize() { Id = DB_Util.LineBaseSequNextVal(dbContext), ItemInventoryId = ItemInventory.Id };
            };
            itemColorBindingSource.AddingNew+=(s, e)=>{
                e.NewObject = new ItemColor() { Id = DB_Util.LineBaseSequNextVal(dbContext), ItemInventoryId = ItemInventory.Id };
            };
            itemVariantsBindingSource.AddingNew += (s, e) => {
                e.NewObject = new ItemVariants() { Id = DB_Util.LineBaseSequNextVal(dbContext), ItemInventoryId = ItemInventory.Id };
            };
            wizardControl1.FinishClick += (s, e) => {
               
                if (PersistChanges())
                {
                    e.Cancel = false;
                    this.Close();
                }
                else
                {
                    e.Cancel = true;
                }
            };
        }

        private void InitData()
        {
            dbContext = new AppDbContext();
            formGridManager = new GridManager();
            formGridManager.Attach(itemSizeGC, itemColorGC, itemVarsGC);
            ItemInventory = new ItemInventory() { Id = DB_Util.LineBaseSequNextVal(dbContext) };

            itemInventoryBindingSource.DataSource = new List<ItemInventory>() { ItemInventory };
            itemInventoryBindingSource.ResetBindings(true);

            ItemSizeList = new List<ItemSize>();
            itemSizeBindingSource.DataSource = ItemSizeList;
            itemSizeBindingSource.ResetBindings(true);
            GridManager.SetupEditForm(itemSizeGV, new List<string>() {
                ItemSize.ItemSizeFields.SizeEnum,
                ItemSize.ItemSizeFields.ItemSizeName,
                ItemSize.ItemSizeFields.BasicSizeConvertFactor
            });

            ItemColorList = new List<ItemColor>();
            itemColorBindingSource.DataSource = ItemColorList;
            itemColorBindingSource.ResetBindings(true);
            GridManager.SetupEditForm(itemColorGV, new List<string>() {
                ItemColor.ItemColorFields.ColorEnum,
                ItemColor.ItemColorFields.ItemColorName
            });
            itemVariantsBindingSource.DataSource = ItemVariantList;
            itemVariantsBindingSource.ResetBindings(true);

            LookupManager.AccountGroup(dbContext, GroupIdLookUpEdit, BaseTypeEnum.ItemInventory);
            LookupManager.TaxGroup(dbContext, TaxGroupLookUpEdit);


        }

        private void wizardControl1_SelectedPageChanging(object sender, DevExpress.XtraWizard.WizardPageChangingEventArgs e)
        {
            if(e.Direction == DevExpress.XtraWizard.Direction.Forward)
            {
                if(e.PrevPage.Name == itemInventoryPage.Name)
                {
                    e.Cancel = !itemInventoryPageValidation.Validate();
                }
                else if(e.PrevPage.Name == itemSizePage.Name)
                {
                    e.Cancel = !itemSizeValidatePage();
                }
                else if (e.PrevPage.Name == itemColorPage.Name)
                {
                    e.Cancel = !itemColorValidatePage();

                    if (!e.Cancel)
                    {
                        BuildItemVariants();
                        itemVariantsBindingSource.ResetBindings(true);
                        itemVarsGC.DataSource = itemVariantsBindingSource;
                    }
                }
                else if (e.PrevPage.Name == itemVarsPage.Name)
                {

                }
            }
        }

        private bool itemSizeValidatePage()
        {
            bool lb_Valid = true;
            itemSizeBindingSource.EndEdit();
            lb_Valid = lb_Valid && ItemSizeList.Where(x => x.SizeEnum == ItemSizeEnum.Basic).Count() == 1;


            return lb_Valid;
        }
        private bool itemColorValidatePage()
        {
            bool lb_Valid = true;

            return lb_Valid;
        }
    }
}
