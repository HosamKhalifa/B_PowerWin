using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
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
            itemBindingSource.DataSource = dbContext.ItemInventorys.Local;
            itemVariantsBindingSource.DataSource = dbContext.ItemVariants.Local;

            itemBindingSource.ResetBindings(true);
            itemVariantsBindingSource.ResetBindings(true);


            FormGridManager = new GUI.Grid.GridManager();

            FormGridManager.Attach(itemGC,itemVarsGC);
            RefreshData();
        }
    }
}
