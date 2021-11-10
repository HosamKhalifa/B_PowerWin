using B_PowerWin.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;
using B_PowerWin.GUI.CustomLookup;
using B_PowerWin.GUI.Grid;
using B_PowerWin.DB.Query;

namespace B_PowerWin.Sales.Forms
{
    public partial class CustomerEditFrm : B_PowerWin.GUI.EditFormBase
    {
        public CustomerEditFrm()
        {
            InitializeComponent();
        }
        public CustomerEditFrm(FormArgs _callerArgs) : base(_callerArgs)
        {

            InitializeComponent();
            InitData(FormArgs);
        }

        private void InitData(FormArgs formArgs)
        {
            dbContext = new AppDbContext();

            LookupManager.AccountGroup(dbContext, GroupIdLookUpEdit, DB.BaseTypeEnum.Customer);
            if(formArgs.CallerFormArgs.CallingMenuItemName.ToUpper() == "NEWBI")
            {
                customerBindingSource.DataSource = dbContext.Customers.Local;
                customerBindingSource.AddNew();
            }
            else if(formArgs.CallerFormArgs.CallingMenuItemName.ToUpper() == "EDITBI" && formArgs.CallerFormArgs.CurrentObject != null)
            {
                RefreshData();
                //var accountLine = formArgs.CallerFormArgs.CurrentAccount;
                //dbContext.Customers.Where(x => x.Id == accountLine.Id).Load();
                //customerBindingSource.DataSource = dbContext.Customers.Local;
            }
        }

        public override void RefreshData()
        {
            var accountLine = this.FormArgs.CallerFormArgs.CurrentObject as CustomerListPageQuery;
            dbContext.Customers.Where(x => x.Id == accountLine.Id).Load();
            customerBindingSource.DataSource = dbContext.Customers.Local;
            base.RefreshData();
        }
    }
}
