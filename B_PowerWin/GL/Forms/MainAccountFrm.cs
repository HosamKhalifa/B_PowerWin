using B_PowerWin.DB;
using B_PowerWin.DB.Query;
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
    public partial class MainAccountFrm : B_PowerWin.GUI.EditFormBase
    {
        List<DB.Query.MainAccountTreeQuery> mainAccountTreeList;
        AppDbContext lookupContext;
        public MainAccountFrm()
        {
            InitializeComponent();
            InitData();
        }
        public override void RefreshData()
        {
            
            base.RefreshData();
            dbContext.MainAccounts.Where(x => x.IsTotal == false).Load();
            lookupContext.MainAccounts.Where(x => x.IsTotal == true ).Load();
            mainAccountTreeList = lookupContext.Database.SqlQuery<MainAccountTreeQuery>(MainAccountTreeQuery.SELECT_SQL).ToList();
            mainAccountLookup.DataSource = mainAccountTreeList;
            mainAccountLookup.ResetBindings(true);
            mainAccountBindingSource.ResetBindings(true);


        }
        private void InitData()
        {
            dbContext = new AppDbContext();
            lookupContext = new AppDbContext();

            FormGridManager = new GUI.Grid.GridManager();
            FormGridManager.Attach(mainAccountGC);

            mainAccountBindingSource.DataSource = dbContext.MainAccounts.Local;
            mainAccountLookup.DataSource = lookupContext.MainAccounts.Local;
            mainAccountGC.DataSource = mainAccountBindingSource;

            mainAccountBindingSource.AddingNew += (s, e) => {
                e.NewObject = new MainAccount()
                {
                    IsTotal = false,
                    Id = DB_Util.LineBaseSequNextVal(dbContext)
                };

            };
            RefreshData();
        }
    }
}
