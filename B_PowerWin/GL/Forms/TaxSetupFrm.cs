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
    public partial class TaxSetupFrm : B_PowerWin.GUI.EditFormBase
    {
        public TaxSetupFrm():base()
        {
            InitializeComponent();
            InitData();
            InitEvents();
        }

        private void InitEvents()
        {
            taxGroupGV.FocusedRowObjectChanged += (s, e) => {
                CurrentTaxGroup = (e.Row as TaxGroup );
            };
            taxGroupMemberSetupBindingSource.AddingNew += (s, e) => {
                e.NewObject = new TaxGroupMemberSetup() {TaxGroupId = CurrentTaxGroup.Id };
            };
            taxCodeGV.FocusedRowObjectChanged += (s, e) => {
                CurrentTaxCode = (e.Row as TaxCode);
            };
            taxCodeValueSetupBindingSource.AddingNew += (s, e) => {
                e.NewObject = new TaxCodeValueSetup() { TaxCodeId = CurrentTaxCode.Id };
            };
        }

        public TaxGroup CurrentTaxGroup { get; set; }
        public TaxCode CurrentTaxCode { get; set; }
        private void InitData()
        {
            dbContext = new AppDbContext();

            GridManager.SetupEditForm(taxGroupGV, new List<string>() {
                                      TaxGroup.TaxGroupFields.GroupNum,
                                      TaxGroup.TaxGroupFields.GroupName          
                                      });
            GridManager.SetupEditForm(taxGroupMemsGV, new List<string>() {
                                      TaxGroupMemberSetup.TaxGroupMemberSetupFields.TaxGroupId,
                                      TaxGroupMemberSetup.TaxGroupMemberSetupFields.TaxCodeId,
                                      TaxGroupMemberSetup.TaxGroupMemberSetupFields.IsDefault
                                      });
            GridManager.SetupEditForm(taxCodeGV, new List<string>() {
                                      TaxCode.TaxCodeFields.TaxCodeId,
                                      TaxCode.TaxCodeFields.TaxCodeName,
                                      TaxCode.TaxCodeFields.ApTaxAccountId,
                                      TaxCode.TaxCodeFields.ArTaxAccountId,
                                      TaxCode.TaxCodeFields.SettlementTaxAccountId
                                      });

            GridManager.SetupEditForm(taxCodeValuesGV, new List<string>() {
                                      TaxCodeValueSetup.TaxCodeValueSetupFields.TaxCodeId,
                                      TaxCodeValueSetup.TaxCodeValueSetupFields.FromDate,
                                      TaxCodeValueSetup.TaxCodeValueSetupFields.ToDate,
                                      TaxCodeValueSetup.TaxCodeValueSetupFields.FromAmount,
                                      TaxCodeValueSetup.TaxCodeValueSetupFields.ToAmount,
                                      TaxCodeValueSetup.TaxCodeValueSetupFields.TaxValueType,
                                      TaxCodeValueSetup.TaxCodeValueSetupFields.TaxValue
                                      });

            FormGridManager = new GridManager();
            FormGridManager.Attach(taxGroupGC,taxGroupMemsGC,taxCodeGC,taxCodeValuesGC);
            LookupManager.MainAccount(dbContext, taxCodeGV, colArTaxAccountId, LookupSuspendedWhereEnum.NonSuspended);
            LookupManager.MainAccount(dbContext, taxCodeGV, colApTaxAccountId, LookupSuspendedWhereEnum.NonSuspended);
            LookupManager.MainAccount(dbContext, taxCodeGV, colSettlementTaxAccountId, LookupSuspendedWhereEnum.NonSuspended);

            taxGroupBindingSource.DataSource = dbContext.TaxGroups.Local;
            taxGroupMemberSetupBindingSource.DataSource = dbContext.TaxGroupMemberSetups.Local;
            taxCodeBindingSource.DataSource = dbContext.TaxCodes.Local;
            taxCodeValueSetupBindingSource.DataSource = dbContext.TaxCodeValueSetups.Local;

            RefreshData();

        }
        public override void RefreshData()
        {
            dbContext.TaxGroups.Load();
            dbContext.TaxGroupMemberSetups.Load();
            dbContext.TaxCodes.Load();
            dbContext.TaxCodeValueSetups.Load();
            base.RefreshData();

        }

    }
}
