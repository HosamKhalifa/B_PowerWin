using B_PowerWin.DB;
using B_PowerWin.GUI.CustomLookup;
using B_PowerWin.GUI.Grid;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace B_PowerWin.Invent
{
    public partial class ItemFrm : B_PowerWin.GUI.EditFormBase
    {
        public ItemFrm()
        {
            InitializeComponent();
            InitData();
        }
        public override void RefreshData()
        {
            dbContext.ItemInventorys.Load();
            dbContext.ItemServices.Load();
            dbContext.ItemVariants.Load();
            dbContext.ItemSizes.Load();
            dbContext.ItemColors.Load();


            base.RefreshData();
        }
        private void InitData()
        {
            dbContext = new AppDbContext();
            bar2.AddItem(newBI);
            newBI.ItemClick += (s, e) => {
                var frm = new ItemWizardFrm() { StartPosition = FormStartPosition.CenterScreen };
                frm.Show();
            };
            itemBindingSource.DataSource            = dbContext.ItemInventorys.Local;
            itemVariantsBindingSource.DataSource    = dbContext.ItemVariants.Local;
            itemServiceBindingSource.DataSource     = dbContext.ItemServices.Local;
            itemSizeBindingSource.DataSource        = dbContext.ItemSizes.Local;
            itemColorBindingSource.DataSource       = dbContext.ItemColors.Local;

            itemBindingSource.ResetBindings(true);
            itemVariantsBindingSource.ResetBindings(true);
            itemServiceBindingSource.ResetBindings(true);


            FormGridManager = new GUI.Grid.GridManager();

            FormGridManager.Attach(itemGC,itemVarsGC,serviceGC);
            GridManager.SetupEditForm(itemGV, new List<string>() {
                ItemInventory.AccountBaseFields.ReferenceNum,
                ItemInventory.AccountBaseFields.Name,
                ItemInventory.AccountBaseFields.Description,
                ItemInventory.AccountBaseFields.Suspended,
                ItemInventory.AccountBaseFields.GroupId,
                ItemInventory.AccountBaseFields.TaxGroupId,
                ItemInventory.ItemFields.ItemMode,
                ItemInventory.ItemFields.PurchPrice,
                ItemInventory.ItemFields.SalesPrice,
                ItemInventory.ItemFields.SalesPriceMin
            });

            GridManager.SetupEditForm(itemVarGV,new List<string>(){
                ItemVariants.AccountBaseFields.ReferenceNum,
                ItemVariants.AccountBaseFields.Name,
                ItemVariants.ItemVariantsFields.ItemInventoryId,
                ItemVariants.ItemVariantsFields.ItemSizeId,
                ItemVariants.ItemVariantsFields.ItemColorId,
                ItemVariants.ItemVariantsFields.PurchPrice,
                ItemVariants.ItemVariantsFields.SalesPrice,
                ItemVariants.ItemVariantsFields.SalesPriceMin,
                ItemVariants.ItemVariantsFields.BuyFromCustomer

            });

            //Lookups setup
            LookupManager.AccountGroup(dbContext, itemGV, colGroupId, DB.BaseTypeEnum.ItemInventory);
            LookupManager.AccountGroup(dbContext, serviceGV, colGroupId_Services, DB.BaseTypeEnum.ItemService);

            LookupManager.TaxGroup(dbContext, itemGV, colTaxGroupId);
            LookupManager.TaxGroup(dbContext, serviceGV, colTaxGroup_Services);
            //Cascade lookup filters 
            itemVarGV.EditFormShowing += (s, e) =>
            {
                ColumnView view = (ColumnView)s;
                var sizeEditor = (RepositoryItemLookUpEdit)view.Columns.ColumnByFieldName(ItemVariants.ItemVariantsFields.ItemSizeId).ColumnEdit;
                var colorEditor = (RepositoryItemLookUpEdit)view.Columns.ColumnByFieldName(ItemVariants.ItemVariantsFields.ItemColorId).ColumnEdit;
                long? itemInventoryId = Convert.ToInt64(view.GetFocusedRowCellValue(ItemVariants.ItemVariantsFields.ItemInventoryId));
                sizeEditor.DataSource = dbContext.ItemSizes.Where(x => x.ItemInventoryId == itemInventoryId).ToList();
                colorEditor.DataSource = dbContext.ItemColors.Where(x => x.ItemInventoryId == itemInventoryId).ToList();
                

            };
            itemVarGV.InitNewRow += (s, e) => {
                
            };
            //itemVar_ItemInventLookup.EditValueChanged += (s, e) => {
            //    this.itemVarGV.PostEditor();
            //    this.itemVarGV.SetFocusedRowCellValue(ItemVariants.ItemVariantsFields.ItemSizeId, null);
            //    this.itemVarGV.SetFocusedRowCellValue(ItemVariants.ItemVariantsFields.ItemColorId, null);
            //};
        
            RefreshData();
        }
    }
}
