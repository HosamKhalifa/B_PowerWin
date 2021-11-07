using B_PowerWin.DB;
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
        public MainAccountFrm()
        {
            InitializeComponent();
            InitData();
        }
        public override void RefreshData()
        {
            base.RefreshData();
            dbContext.MainAccounts.Where(x => x.IsTotal == false).Load();
            mainAccountBindingSource.ResetBindings(true);


        }
        private void InitData()
        {
            dbContext = new AppDbContext();

            FormGridManager = new GUI.Grid.GridManager();

            mainAccountBindingSource.DataSource = dbContext.MainAccounts.Local;
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
