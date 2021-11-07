using B_PowerWin.DB;
using DevExpress.XtraBars.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace B_PowerWin.GL.Forms
{
    public partial class MainAccountTreeFrm : B_PowerWin.GUI.EditFormBase
    {
       
        public MainAccountTreeFrm()
        {
            InitializeComponent();
            InitData();
        }
        public override void RefreshData()
        {
            base.RefreshData();
            dbContext.MainAccounts.Where(x => x.IsTotal == true).Load();
            accountTotalsLookupBS.ResetBindings(true);

            
        }
        private void InitData()
        {
            dbContext = new AppDbContext();
            
            FormGridManager = new GUI.Grid.GridManager();
            
            accountTotalsLookupBS.DataSource = dbContext.MainAccounts.Local;
            treeList1.DataSource = accountTotalsLookupBS;

            accountTotalsLookupBS.AddingNew += (s, e) => {
                e.NewObject = new MainAccount() {
                    IsTotal = true,
                    Id = DB_Util.LineBaseSequNextVal(dbContext) 
                };

            };
            RefreshData();
        }
    }
}
