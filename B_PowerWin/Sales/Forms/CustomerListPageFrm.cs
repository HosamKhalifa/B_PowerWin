using B_PowerWin.DB.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace B_PowerWin.Sales.Forms
{
    public partial class CustomerListPageFrm : B_PowerWin.GUI.ListPageFormBase
    {
        public List<CustomerListPageQuery> RowsList { get; set; }
        public CustomerListPageFrm()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            dbContext = new AppDbContext();
            FormGridManager = new GUI.Grid.GridManager();
            FormGridManager.Attach(customerGC);
            RowsList = dbContext.Database.SqlQuery<CustomerListPageQuery>(CustomerListPageQuery.SELECT_SQL).ToList();
            customerListPageQueryBindingSource.DataSource = RowsList;

            newBI.ItemClick += (s, e) => {
                FormArgs.CallingMenuItemName = newBI.Name;
                var custFrm = new CustomerEditFrm(FormArgs) { MdiParent = this.MdiParent,StartPosition = FormStartPosition.CenterParent };
                custFrm.Show();
            };
            editBI.ItemClick += (s, e) => {
                FormArgs.CallingMenuItemName = editBI.Name;
                var custFrm = new CustomerEditFrm(FormArgs) { MdiParent = this.MdiParent, StartPosition = FormStartPosition.CenterParent };
                custFrm.Show();
            };

            refreshBI.ItemClick += (s, e) => {
                FormArgs.CallingMenuItemName = refreshBI.Name;
                RowsList = dbContext.Database.SqlQuery<CustomerListPageQuery>(CustomerListPageQuery.SELECT_SQL).ToList();
                customerListPageQueryBindingSource.DataSource = RowsList;

            };

        }
        public override void RefreshData()
        {
            RowsList = dbContext.Database.SqlQuery<CustomerListPageQuery>(CustomerListPageQuery.SELECT_SQL).ToList();

        }
    }
}
