using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using DevExpress.XtraGrid.Views.Grid;
using B_PowerWin.DB;

namespace B_PowerWin.GL.Forms
{
    public partial class PostingProfileSetupFrm : B_PowerWin.GUI.EditFormBase
    {
        DB.LedgerPostingModuleEnum postingModeule;
        public PostingProfileSetupFrm(DB.LedgerPostingModuleEnum _module):base()
        {
            InitializeComponent();
            postingModeule = _module;
            initData();
        }

        private void initData()
        {
            dbContext = new AppDbContext();
            FormGridManager = new GUI.Grid.GridManager();
            FormGridManager.Attach(profileGC, setupLinesGC);
            profileGC.DataSource = dbContext.LedgerPostingProfiles.Local;
            ledgerPostingProfileSetupBindingSource.DataSource = dbContext.LedgerPostingProfileSetups.Local;
            profileGV.RowClick += (s, e) => {
                if(e.Clicks > 1)
                {
                    var currObj = ((s as GridView).GetFocusedRow() as LedgerPostingProfile);
                    var frm = new PostingProfileSetupEditorFrm(currObj) { StartPosition = FormStartPosition.CenterParent };
                    frm.ShowDialog();

                }

            };
            RefreshData();
        }

        public override void RefreshData()
        {
            
            dbContext.LedgerPostingProfiles.Where(x => x.PostingModule == postingModeule).Load();
            dbContext.LedgerPostingProfileSetups.Load();

            base.RefreshData();
        }

    }
}
