using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace B_PowerWin.GL.Forms
{
    public partial class MainAccountFrm : B_PowerWin.GUI.EditFormBase
    {
        public MainAccountFrm()
        {
            InitializeComponent();
            InitData();
        }
        public override void RefreshData()
        {
            dbContext = new AppDbContext();
            dbContext.MainAccounts.Load();
            mainAccountBindingSource.DataSource = dbContext.MainAccounts.Local;
            mainAccountBindingSource.ResetBindings(true);
            base.RefreshData();
        }
        private void InitData()
        {
            FormGridManager = new GUI.Grid.GridManager();
            FormGridManager.Attach(mainAccountGC);
            RefreshData();
        }
    }
}
