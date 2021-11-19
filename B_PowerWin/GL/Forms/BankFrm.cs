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
    public partial class BankFrm : B_PowerWin.GUI.EditFormBase
    {
        public BankFrm()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            dbContext = new AppDbContext();
            GridManager.SetupEditForm(bankGV,new List<string>() {
                                      Bank.AccountBaseFields.ReferenceNum,
                                      Bank.AccountBaseFields.Name,
                                      Bank.AccountBaseFields.Suspended,
                                      Bank.AccountBaseFields.GroupId,
                                      Bank.AccountBaseFields.Description
                                      });
            FormGridManager = new GridManager();
            FormGridManager.Attach(bankGC);

            LookupManager.AccountGroup(dbContext, bankGV, colGroupId, DB.BaseTypeEnum.Bank);
            bankBindingSource.DataSource = dbContext.Banks.Local;
            RefreshData();

        }
        public override void RefreshData()
        {
            dbContext.Banks.Load();
            base.RefreshData();

        }


    }
}
