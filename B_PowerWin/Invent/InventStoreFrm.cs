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
    public partial class InventStoreFrm : B_PowerWin.GUI.EditFormBase
    {
        public InventStoreFrm()
        {
            InitializeComponent();
            InitData();
        }
        public override void RefreshData()
        {
            dbContext = new AppDbContext();
            dbContext.InventStores.Load();
            inventStoreBS.DataSource = dbContext.InventStores.Local;
            inventStoreBS.ResetBindings(true);
            base.RefreshData();
        }
        private void InitData()
        {
            FormGridManager = new GUI.Grid.GridManager();
            
            FormGridManager.Attach(inventStoreGC);
            RefreshData();
        }
    }
}
