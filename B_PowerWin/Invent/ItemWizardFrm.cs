﻿using System;
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

        public ItemWizardFrm()
        {
            InitializeComponent();
            InitData();
            InitEvents();
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
