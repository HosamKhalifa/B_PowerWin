using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_PowerWin.GL.Forms
{
    public partial class CompanySetupFrm : GUI.EditFormBase
    {
        public CompanySetupFrm():base()
        {
            InitializeComponent();
            InitData();
        }

        public override void RefreshData()
        {
            dbContext.Companies.Load();
            dbContext.LedgerCalenders.Load();
            dbContext.LedgerCOAs.Load();
            dbContext.Currencies.Load();
            dbContext.Countries.Load();
            dbContext.Cities.Load();

            companyBindingSource.DataSource     = dbContext.Companies.Local;
            calenderBindingSource.DataSource    = dbContext.LedgerCalenders.Local;
            ledgerCOABindingSource.DataSource   = dbContext.LedgerCOAs.Local;
            currencyBindingSource.DataSource    = dbContext.Currencies.Local;
            countryBindingSource.DataSource     = dbContext.Countries.Local;
            cityBindingSource.DataSource        = dbContext.Cities.Local;

            companyBindingSource.ResetBindings(false);
            calenderBindingSource.ResetBindings(false);
            ledgerCOABindingSource.ResetBindings(false);
            currencyBindingSource.ResetBindings(false);
            countryBindingSource.ResetBindings(false);
            cityBindingSource.ResetBindings(false);

            base.RefreshData();
        }
        private void InitData()
        {
            dbContext = new AppDbContext();

            FormGridManager = new GUI.Grid.GridManager();
            FormGridManager.Attach(companyGC, calenderGC, cOAGC,currencyGC,countryGC,cityGC);

            companyGC.DataSource = companyBindingSource;
            calenderGC.DataSource = calenderBindingSource;
            cOAGC.DataSource = ledgerCOABindingSource;
            currencyGC.DataSource = currencyBindingSource;
            countryGC.DataSource = countryBindingSource;
            cityGC.DataSource = cityBindingSource;
           
            RefreshData();

        }
    }
}
