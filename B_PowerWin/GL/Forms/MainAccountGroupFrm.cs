using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Helpers;
using B_PowerWin.GUI;

namespace B_PowerWin.GL.Forms
{
    public partial class MainAccountGroupFrm : B_PowerWin.GUI.EditFormBase
    {
        
        public MainAccountGroupFrm():base()
        {
            InitializeComponent();
            InitData();
          
        }
        public MainAccountGroupFrm(FormArgs _callerArgs):base(_callerArgs)
        {

        }
        public override void RefreshData()
        {
            dbContext = new AppDbContext();
            dbContext.MainAccountGroups.Load();
            mainAccountGroupBindingSource.DataSource = dbContext.MainAccountGroups.Local;
            mainAccountGroupBindingSource.ResetBindings(true);
            base.RefreshData();
        }
        private void InitData()
        {
            FormGridManager = new GUI.Grid.GridManager();
            FormGridManager.Attach(mainAccountGroupGC);
            
            RefreshData();

       }
        


    }
}
