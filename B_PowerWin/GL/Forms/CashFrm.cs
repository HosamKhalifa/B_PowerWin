using B_PowerWin.DB;
using B_PowerWin.GUI.CustomLookup;
using B_PowerWin.GUI.Grid;
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
    public partial class CashFrm : B_PowerWin.GUI.EditFormBase
    {
        public CashFrm()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            dbContext = new AppDbContext();
            GridManager.SetupEditForm(cashGV, new List<string>() {
                                      Cash.AccountBaseFields.ReferenceNum,
                                      Cash.AccountBaseFields.Name,
                                      Cash.AccountBaseFields.Suspended,
                                      Cash.CashFields.Employee,
                                      Cash.AccountBaseFields.GroupId,
                                      Cash.AccountBaseFields.Description
                                      });
            FormGridManager = new GridManager();
            FormGridManager.Attach(cashGC);

            LookupManager.AccountGroup(dbContext, cashGV, colGroupId, DB.BaseTypeEnum.Cash);
            cashBindingSource.DataSource = dbContext.Cashes.Local;
            RefreshData();

        }
        public override void RefreshData()
        {
            dbContext.Cashes.Load();
            base.RefreshData();

        }


    }
}
