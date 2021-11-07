namespace B_PowerWin.GL.Forms
{
    partial class PostingProfileSetupEditorFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.cVBC_profilePage = new DevExpress.XtraTab.XtraTabPage();
            this.cVBC_profileGC = new B_PowerWin.GUI.Grid.GridCtrlBase();
            this.ledgerPostingProfileSetupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.persistentRepository1 = new DevExpress.XtraEditors.Repository.PersistentRepository(this.components);
            this.accountOrGroupLookup = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.mainAccountLookup = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.mainAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.cVBC_profileGV = new B_PowerWin.GUI.Grid.GridViewBase();
            this.colProfileId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLineNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostingScope = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLineValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLineDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLedgerPostingProfile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLedgerPostingEntry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCVBC_MainAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInventoryControl_MainAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesRevenue_MainAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostOfGoodsSold_MainAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeferredRevenue_MainAcount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnInvoicedAR_MainAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnderInspectionInventory_MainAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnderInspectionVendor_MainAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.POS_SalesInvoicePage = new DevExpress.XtraTab.XtraTabPage();
            this.POS_SalesInvoiceGC = new B_PowerWin.GUI.Grid.GridCtrlBase();
            this.POS_SalesInvoiceGV = new B_PowerWin.GUI.Grid.GridViewBase();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.accGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.cVBC_profilePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cVBC_profileGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledgerPostingProfileSetupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountOrGroupLookup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountLookup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cVBC_profileGV)).BeginInit();
            this.POS_SalesInvoicePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.POS_SalesInvoiceGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.POS_SalesInvoiceGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 31);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.cVBC_profilePage;
            this.xtraTabControl1.Size = new System.Drawing.Size(766, 531);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.cVBC_profilePage,
            this.POS_SalesInvoicePage});
            // 
            // cVBC_profilePage
            // 
            this.cVBC_profilePage.Controls.Add(this.cVBC_profileGC);
            this.cVBC_profilePage.Name = "cVBC_profilePage";
            this.cVBC_profilePage.Size = new System.Drawing.Size(760, 503);
            // 
            // cVBC_profileGC
            // 
            this.cVBC_profileGC.DataSource = this.ledgerPostingProfileSetupBindingSource;
            this.cVBC_profileGC.dbContext = null;
            this.cVBC_profileGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cVBC_profileGC.ExternalRepository = this.persistentRepository1;
            this.cVBC_profileGC.Location = new System.Drawing.Point(0, 0);
            this.cVBC_profileGC.MainView = this.cVBC_profileGV;
            this.cVBC_profileGC.MenuManager = this.barManager1;
            this.cVBC_profileGC.Name = "cVBC_profileGC";
            this.cVBC_profileGC.Size = new System.Drawing.Size(760, 503);
            this.cVBC_profileGC.TabIndex = 0;
            this.cVBC_profileGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cVBC_profileGV});
            // 
            // ledgerPostingProfileSetupBindingSource
            // 
            this.ledgerPostingProfileSetupBindingSource.DataSource = typeof(B_PowerWin.DB.LedgerPostingProfileSetup);
            // 
            // persistentRepository1
            // 
            this.persistentRepository1.Items.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.accountOrGroupLookup,
            this.mainAccountLookup,
            this.allComboBox});
            // 
            // accountOrGroupLookup
            // 
            this.accountOrGroupLookup.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.accountOrGroupLookup.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", 10, "Id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", 90, "Name")});
            this.accountOrGroupLookup.DisplayMember = "FullName";
            this.accountOrGroupLookup.KeyMember = "Id";
            this.accountOrGroupLookup.Name = "accountOrGroupLookup";
            this.accountOrGroupLookup.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.accountOrGroupLookup.ValueMember = "Id";
            // 
            // mainAccountLookup
            // 
            this.mainAccountLookup.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mainAccountLookup.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ReferenceNum", "Num"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 60, "Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MainAccountType", "Type")});
            this.mainAccountLookup.DataSource = this.mainAccountBindingSource;
            this.mainAccountLookup.DisplayMember = "FullName";
            this.mainAccountLookup.KeyMember = "Id";
            this.mainAccountLookup.Name = "mainAccountLookup";
            this.mainAccountLookup.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.mainAccountLookup.ValueMember = "Id";
            // 
            // mainAccountBindingSource
            // 
            this.mainAccountBindingSource.DataSource = typeof(B_PowerWin.DB.MainAccount);
            // 
            // allComboBox
            // 
            this.allComboBox.AutoHeight = false;
            this.allComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.allComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("All", ((long)(0)), -1)});
            this.allComboBox.Name = "allComboBox";
            // 
            // cVBC_profileGV
            // 
            this.cVBC_profileGV.BaseTypeEnum = B_PowerWin.DB.BaseTypeEnum.LedgerPostingProfileSetup;
            this.cVBC_profileGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProfileId,
            this.colLineNum,
            this.colPostingScope,
            this.colLineValue,
            this.colLineDescription,
            this.colLedgerPostingProfile,
            this.colLedgerPostingEntry,
            this.colCVBC_MainAccount,
            this.colInventoryControl_MainAccount,
            this.colSalesRevenue_MainAccount,
            this.colCostOfGoodsSold_MainAccount,
            this.colDeferredRevenue_MainAcount,
            this.colUnInvoicedAR_MainAccount,
            this.colUnderInspectionInventory_MainAccount,
            this.colUnderInspectionVendor_MainAccount});
            this.cVBC_profileGV.EnableAutoFormat = false;
            this.cVBC_profileGV.GridControl = this.cVBC_profileGC;
            this.cVBC_profileGV.GridViewEditMode = B_PowerWin.GUI.Grid.GridViewEditModeEnum.SimpleEdit;
            this.cVBC_profileGV.Name = "cVBC_profileGV";
            this.cVBC_profileGV.OptionsView.ColumnAutoWidth = false;
            this.cVBC_profileGV.OptionsView.ShowAutoFilterRow = true;
            // 
            // colProfileId
            // 
            this.colProfileId.FieldName = "ProfileId";
            this.colProfileId.Name = "colProfileId";
            // 
            // colLineNum
            // 
            this.colLineNum.FieldName = "LineNum";
            this.colLineNum.Name = "colLineNum";
            this.colLineNum.Visible = true;
            this.colLineNum.VisibleIndex = 0;
            // 
            // colPostingScope
            // 
            this.colPostingScope.FieldName = "PostingScope";
            this.colPostingScope.Name = "colPostingScope";
            this.colPostingScope.Visible = true;
            this.colPostingScope.VisibleIndex = 1;
            this.colPostingScope.Width = 86;
            // 
            // colLineValue
            // 
            this.colLineValue.ColumnEdit = this.allComboBox;
            this.colLineValue.FieldName = "LineValue";
            this.colLineValue.Name = "colLineValue";
            this.colLineValue.Visible = true;
            this.colLineValue.VisibleIndex = 2;
            this.colLineValue.Width = 89;
            // 
            // colLineDescription
            // 
            this.colLineDescription.FieldName = "LineDescription";
            this.colLineDescription.Name = "colLineDescription";
            this.colLineDescription.Visible = true;
            this.colLineDescription.VisibleIndex = 3;
            this.colLineDescription.Width = 228;
            // 
            // colLedgerPostingProfile
            // 
            this.colLedgerPostingProfile.FieldName = "LedgerPostingProfile";
            this.colLedgerPostingProfile.Name = "colLedgerPostingProfile";
            // 
            // colLedgerPostingEntry
            // 
            this.colLedgerPostingEntry.FieldName = "LedgerPostingEntry";
            this.colLedgerPostingEntry.Name = "colLedgerPostingEntry";
            this.colLedgerPostingEntry.Visible = true;
            this.colLedgerPostingEntry.VisibleIndex = 4;
            this.colLedgerPostingEntry.Width = 112;
            // 
            // colCVBC_MainAccount
            // 
            this.colCVBC_MainAccount.ColumnEdit = this.mainAccountLookup;
            this.colCVBC_MainAccount.FieldName = "CVBC_MainAccount";
            this.colCVBC_MainAccount.Name = "colCVBC_MainAccount";
            this.colCVBC_MainAccount.Visible = true;
            this.colCVBC_MainAccount.VisibleIndex = 5;
            this.colCVBC_MainAccount.Width = 351;
            // 
            // colInventoryControl_MainAccount
            // 
            this.colInventoryControl_MainAccount.ColumnEdit = this.mainAccountLookup;
            this.colInventoryControl_MainAccount.FieldName = "InventoryControl_MainAccount";
            this.colInventoryControl_MainAccount.Name = "colInventoryControl_MainAccount";
            // 
            // colSalesRevenue_MainAccount
            // 
            this.colSalesRevenue_MainAccount.ColumnEdit = this.mainAccountLookup;
            this.colSalesRevenue_MainAccount.FieldName = "SalesRevenue_MainAccount";
            this.colSalesRevenue_MainAccount.Name = "colSalesRevenue_MainAccount";
            // 
            // colCostOfGoodsSold_MainAccount
            // 
            this.colCostOfGoodsSold_MainAccount.ColumnEdit = this.mainAccountLookup;
            this.colCostOfGoodsSold_MainAccount.FieldName = "CostOfGoodsSold_MainAccount";
            this.colCostOfGoodsSold_MainAccount.Name = "colCostOfGoodsSold_MainAccount";
            // 
            // colDeferredRevenue_MainAcount
            // 
            this.colDeferredRevenue_MainAcount.ColumnEdit = this.mainAccountLookup;
            this.colDeferredRevenue_MainAcount.FieldName = "DeferredRevenue_MainAcount";
            this.colDeferredRevenue_MainAcount.Name = "colDeferredRevenue_MainAcount";
            // 
            // colUnInvoicedAR_MainAccount
            // 
            this.colUnInvoicedAR_MainAccount.ColumnEdit = this.mainAccountLookup;
            this.colUnInvoicedAR_MainAccount.FieldName = "UnInvoicedAR_MainAccount";
            this.colUnInvoicedAR_MainAccount.Name = "colUnInvoicedAR_MainAccount";
            // 
            // colUnderInspectionInventory_MainAccount
            // 
            this.colUnderInspectionInventory_MainAccount.ColumnEdit = this.mainAccountLookup;
            this.colUnderInspectionInventory_MainAccount.FieldName = "UnderInspectionInventory_MainAccount";
            this.colUnderInspectionInventory_MainAccount.Name = "colUnderInspectionInventory_MainAccount";
            // 
            // colUnderInspectionVendor_MainAccount
            // 
            this.colUnderInspectionVendor_MainAccount.ColumnEdit = this.mainAccountLookup;
            this.colUnderInspectionVendor_MainAccount.FieldName = "UnderInspectionVendor_MainAccount";
            this.colUnderInspectionVendor_MainAccount.Name = "colUnderInspectionVendor_MainAccount";
            // 
            // POS_SalesInvoicePage
            // 
            this.POS_SalesInvoicePage.Controls.Add(this.POS_SalesInvoiceGC);
            this.POS_SalesInvoicePage.Name = "POS_SalesInvoicePage";
            this.POS_SalesInvoicePage.Size = new System.Drawing.Size(760, 503);
            this.POS_SalesInvoicePage.Text = "POS_SalesInvoice";
            // 
            // POS_SalesInvoiceGC
            // 
            this.POS_SalesInvoiceGC.DataSource = this.ledgerPostingProfileSetupBindingSource;
            this.POS_SalesInvoiceGC.dbContext = null;
            this.POS_SalesInvoiceGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.POS_SalesInvoiceGC.ExternalRepository = this.persistentRepository1;
            this.POS_SalesInvoiceGC.Location = new System.Drawing.Point(0, 0);
            this.POS_SalesInvoiceGC.MainView = this.POS_SalesInvoiceGV;
            this.POS_SalesInvoiceGC.MenuManager = this.barManager1;
            this.POS_SalesInvoiceGC.Name = "POS_SalesInvoiceGC";
            this.POS_SalesInvoiceGC.Size = new System.Drawing.Size(760, 503);
            this.POS_SalesInvoiceGC.TabIndex = 1;
            this.POS_SalesInvoiceGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.POS_SalesInvoiceGV});
            // 
            // POS_SalesInvoiceGV
            // 
            this.POS_SalesInvoiceGV.BaseTypeEnum = B_PowerWin.DB.BaseTypeEnum.LedgerPostingProfileSetup;
            this.POS_SalesInvoiceGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15});
            this.POS_SalesInvoiceGV.EnableAutoFormat = false;
            this.POS_SalesInvoiceGV.GridControl = this.POS_SalesInvoiceGC;
            this.POS_SalesInvoiceGV.GridViewEditMode = B_PowerWin.GUI.Grid.GridViewEditModeEnum.SimpleEdit;
            this.POS_SalesInvoiceGV.Name = "POS_SalesInvoiceGV";
            this.POS_SalesInvoiceGV.OptionsView.ColumnAutoWidth = false;
            this.POS_SalesInvoiceGV.OptionsView.RowAutoHeight = true;
            this.POS_SalesInvoiceGV.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "ProfileId";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "LineNum";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "PostingScope";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 86;
            // 
            // gridColumn4
            // 
            this.gridColumn4.ColumnEdit = this.allComboBox;
            this.gridColumn4.FieldName = "LineValue";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 89;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "LineDescription";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 228;
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "LedgerPostingProfile";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // gridColumn7
            // 
            this.gridColumn7.FieldName = "LedgerPostingEntry";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 4;
            this.gridColumn7.Width = 112;
            // 
            // gridColumn8
            // 
            this.gridColumn8.ColumnEdit = this.mainAccountLookup;
            this.gridColumn8.FieldName = "CVBC_MainAccount";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Width = 351;
            // 
            // gridColumn9
            // 
            this.gridColumn9.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn9.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn9.Caption = "Inventory control";
            this.gridColumn9.ColumnEdit = this.mainAccountLookup;
            this.gridColumn9.FieldName = "InventoryControl_MainAccount";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 5;
            // 
            // gridColumn10
            // 
            this.gridColumn10.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn10.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn10.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn10.Caption = "Sales revenue";
            this.gridColumn10.ColumnEdit = this.mainAccountLookup;
            this.gridColumn10.FieldName = "SalesRevenue_MainAccount";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 6;
            // 
            // gridColumn11
            // 
            this.gridColumn11.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn11.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn11.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn11.Caption = "Cost of goods sold";
            this.gridColumn11.ColumnEdit = this.mainAccountLookup;
            this.gridColumn11.FieldName = "CostOfGoodsSold_MainAccount";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 9;
            // 
            // gridColumn12
            // 
            this.gridColumn12.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn12.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn12.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn12.Caption = "Deferred revenue";
            this.gridColumn12.ColumnEdit = this.mainAccountLookup;
            this.gridColumn12.FieldName = "DeferredRevenue_MainAcount";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 7;
            // 
            // gridColumn13
            // 
            this.gridColumn13.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn13.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn13.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn13.Caption = "Un invoiced AR ";
            this.gridColumn13.ColumnEdit = this.mainAccountLookup;
            this.gridColumn13.FieldName = "UnInvoicedAR_MainAccount";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 8;
            this.gridColumn13.Width = 91;
            // 
            // gridColumn14
            // 
            this.gridColumn14.ColumnEdit = this.mainAccountLookup;
            this.gridColumn14.FieldName = "UnderInspectionInventory_MainAccount";
            this.gridColumn14.Name = "gridColumn14";
            // 
            // gridColumn15
            // 
            this.gridColumn15.ColumnEdit = this.mainAccountLookup;
            this.gridColumn15.FieldName = "UnderInspectionVendor_MainAccount";
            this.gridColumn15.Name = "gridColumn15";
            // 
            // accGroupBindingSource
            // 
            this.accGroupBindingSource.DataSource = typeof(B_PowerWin.DB.AccountGroup);
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataSource = typeof(B_PowerWin.DB.AccountBase);
            // 
            // PostingProfileSetupEditorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(766, 585);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "PostingProfileSetupEditorFrm";
            this.Controls.SetChildIndex(this.xtraTabControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.cVBC_profilePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cVBC_profileGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledgerPostingProfileSetupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountOrGroupLookup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountLookup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cVBC_profileGV)).EndInit();
            this.POS_SalesInvoicePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.POS_SalesInvoiceGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.POS_SalesInvoiceGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage cVBC_profilePage;
        private DevExpress.XtraTab.XtraTabPage POS_SalesInvoicePage;
        private GUI.Grid.GridCtrlBase cVBC_profileGC;
        private GUI.Grid.GridViewBase cVBC_profileGV;
        private System.Windows.Forms.BindingSource ledgerPostingProfileSetupBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colProfileId;
        private DevExpress.XtraGrid.Columns.GridColumn colLineNum;
        private DevExpress.XtraGrid.Columns.GridColumn colPostingScope;
        private DevExpress.XtraGrid.Columns.GridColumn colLineValue;
        private DevExpress.XtraGrid.Columns.GridColumn colLineDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colLedgerPostingProfile;
        private DevExpress.XtraGrid.Columns.GridColumn colLedgerPostingEntry;
        private DevExpress.XtraGrid.Columns.GridColumn colCVBC_MainAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colInventoryControl_MainAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesRevenue_MainAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colCostOfGoodsSold_MainAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colDeferredRevenue_MainAcount;
        private DevExpress.XtraGrid.Columns.GridColumn colUnInvoicedAR_MainAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colUnderInspectionInventory_MainAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colUnderInspectionVendor_MainAccount;
        private GUI.Grid.GridCtrlBase POS_SalesInvoiceGC;
        private GUI.Grid.GridViewBase POS_SalesInvoiceGV;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraEditors.Repository.PersistentRepository persistentRepository1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit accountOrGroupLookup;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit mainAccountLookup;
        private System.Windows.Forms.BindingSource mainAccountBindingSource;
        private System.Windows.Forms.BindingSource accGroupBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox allComboBox;
        private System.Windows.Forms.BindingSource accountsBindingSource;
    }
}
