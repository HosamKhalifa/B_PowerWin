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

namespace B_PowerWin.Sales.Forms
{
    public partial class CustomerFrm : B_PowerWin.GUI.EditFormBase
    {
        public CustomerFrm()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            dbContext = new AppDbContext();
            GridManager.SetupEditForm(customerGV, new List<string>() {
                                      Customer.AccountBaseFields.ReferenceNum,
                                      Customer.AccountBaseFields.Name,
                                      Customer.AccountBaseFields.GroupId,
                                      Customer.AccountBaseFields.Suspended,
                                      Customer.CustomerFields.CreditLimit,
                                      Customer.AccountBaseFields.Description
                                      });
            FormGridManager = new GridManager();
            FormGridManager.Attach(customerGC);

            LookupManager.AccountGroup(dbContext, customerGV, colGroupId, DB.BaseTypeEnum.Customer);
            customerBindingSource.DataSource = dbContext.Customers.Local;
            RefreshData();

        }
        public override void RefreshData()
        {
            dbContext.Customers.Load();
            base.RefreshData();

        }

    }
}
