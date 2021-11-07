using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using B_PowerWin.DB;
using DevExpress.XtraTab;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using System.Linq;
using System.Data.Entity;
using DevExpress.XtraGrid.Views.Grid;

namespace B_PowerWin.GL.Forms
{
    public partial class PostingProfileSetupEditorFrm : B_PowerWin.GUI.EditFormBase
    {
        public LedgerPostingProfile PostingProfile { get; set; }
        public PostingProfileSetupEditorFrm(LedgerPostingProfile _profile)
        {
            PostingProfile = _profile;
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            dbContext = new AppDbContext();
            FormGridManager = new GUI.Grid.GridManager();
            FormGridManager.Attach(cVBC_profileGC, POS_SalesInvoiceGC);
            cVBC_profileGV.CellValueChanging += Scope_CellValueChanged;
            POS_SalesInvoiceGV.CellValueChanging += Scope_CellValueChanged;
            foreach (var page in xtraTabControl1.TabPages)
            {
                (page as XtraTabPage).PageVisible = false;
            }
            switch (PostingProfile.ProfileType)
            {
                case LedgerLineTypeEnum.Ledger:
                    switch (PostingProfile.LedgerPostingEntry)
                    {
                        
                        case LedgerPostingEntryEnum.POS_SalesInvoice:
                            POS_SalesInvoicePage.PageVisible = true;

                            break;
                        case LedgerPostingEntryEnum.PurchaseBill:
                            break;
                        
                        default:
                            break;
                    }
                    break;
                case LedgerLineTypeEnum.Cust:
                case LedgerLineTypeEnum.Vend:
                case LedgerLineTypeEnum.Bank:
                case LedgerLineTypeEnum.Cash:
                case LedgerLineTypeEnum.FixedAsset:
                    cVBC_profilePage.PageVisible = true;
                    cVBC_profilePage.Text = PostingProfile.ProfileId;
                    break;
                default:
                    break;
            }

        }

        private void Scope_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == colPostingScope.FieldName)
            {
                var valueCol = (sender as GridView).Columns.ColumnByFieldName("LineValue");
                if(valueCol != null)
                {
                    LookupSetup(valueCol, (LedgerPostingScopeEnum)e.Value);
                }
                
            }
        }

        public override void RefreshData()
        {
            dbContext.Accounts.Where(x => x.BaseType == (int)PostingProfile.AccountBaseType).Load();
            dbContext.AccountGroups.Where(x => x.GroupedBaseTypeId == (int)PostingProfile.AccountBaseType).Load();
            dbContext.LedgerPostingProfileSetups.Where(x => x.ProfileId == PostingProfile.ProfileId).Load();
            accGroupBindingSource.DataSource = dbContext.AccountGroups.Local;
            accountsBindingSource.DataSource = dbContext.Accounts.Local;

            base.RefreshData();
        }

        public void LookupSetup(GridColumn _grdCol,DB.LedgerPostingScopeEnum _scope)
        {
            var lookup = _grdCol.ColumnEdit as RepositoryItemLookUpEdit;
            switch (_scope)
            {
                case LedgerPostingScopeEnum.All:
                    _grdCol.ColumnEdit = allComboBox;
                    break;
                case LedgerPostingScopeEnum.Group:
                    accountOrGroupLookup.DataSource = accGroupBindingSource;
                    accGroupBindingSource.ResetBindings(true);
                    _grdCol.ColumnEdit = accountOrGroupLookup;
                    break;
                case LedgerPostingScopeEnum.Specific:
                    accountOrGroupLookup.DataSource = accountsBindingSource;
                    accountsBindingSource.ResetBindings(true);
                    _grdCol.ColumnEdit = accountOrGroupLookup;
                    break;
                default:
                    break;
            }
        }

    }
}
