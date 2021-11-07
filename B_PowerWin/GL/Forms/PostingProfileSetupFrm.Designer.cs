namespace B_PowerWin.GL.Forms
{
    partial class PostingProfileSetupFrm
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
            this.profileGC = new B_PowerWin.GUI.Grid.GridCtrlBase();
            this.ledgerPostingProfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profileGV = new B_PowerWin.GUI.Grid.GridViewBase();
            this.colProfileId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProfileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProfileType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountBaseType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLedgerPostingEntry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostingModule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSetupLines = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.ledgerPostingProfileSetupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setupLinesGV = new B_PowerWin.GUI.Grid.GridViewBase();
            this.colProfileId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLineNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostingScope = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLineValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLineDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLedgerPostingProfile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLedgerPostingEntry1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCVBC_MainAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInventoryControl_MainAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesRevenue_MainAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostOfGoodsSold_MainAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeferredRevenue_MainAcount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnInvoicedAR_MainAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnderInspectionInventory_MainAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnderInspectionVendor_MainAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.setupLinesGC = new B_PowerWin.GUI.Grid.GridCtrlBase();
            ((System.ComponentModel.ISupportInitialize)(this.profileGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledgerPostingProfileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledgerPostingProfileSetupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupLinesGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupLinesGC)).BeginInit();
            this.SuspendLayout();
            // 
            // profileGC
            // 
            this.profileGC.DataSource = this.ledgerPostingProfileBindingSource;
            this.profileGC.dbContext = null;
            this.profileGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileGC.Location = new System.Drawing.Point(0, 0);
            this.profileGC.MainView = this.profileGV;
            this.profileGC.MenuManager = this.barManager1;
            this.profileGC.Name = "profileGC";
            this.profileGC.Size = new System.Drawing.Size(272, 531);
            this.profileGC.TabIndex = 4;
            this.profileGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.profileGV});
            // 
            // ledgerPostingProfileBindingSource
            // 
            this.ledgerPostingProfileBindingSource.DataSource = typeof(B_PowerWin.DB.LedgerPostingProfile);
            // 
            // profileGV
            // 
            this.profileGV.BaseTypeEnum = B_PowerWin.DB.BaseTypeEnum.LedgerPostingProfile;
            this.profileGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProfileId,
            this.colProfileName,
            this.colProfileType,
            this.colAccountBaseType,
            this.colLedgerPostingEntry,
            this.colPostingModule,
            this.colSetupLines});
            this.profileGV.EnableAutoFormat = false;
            this.profileGV.GridControl = this.profileGC;
            this.profileGV.GridViewEditMode = B_PowerWin.GUI.Grid.GridViewEditModeEnum.ReadOnly;
            this.profileGV.Name = "profileGV";
            this.profileGV.OptionsView.ColumnAutoWidth = false;
            this.profileGV.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colProfileId, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colProfileId
            // 
            this.colProfileId.FieldName = "ProfileId";
            this.colProfileId.Name = "colProfileId";
            this.colProfileId.Visible = true;
            this.colProfileId.VisibleIndex = 0;
            this.colProfileId.Width = 108;
            // 
            // colProfileName
            // 
            this.colProfileName.FieldName = "ProfileName";
            this.colProfileName.Name = "colProfileName";
            this.colProfileName.Visible = true;
            this.colProfileName.VisibleIndex = 1;
            this.colProfileName.Width = 128;
            // 
            // colProfileType
            // 
            this.colProfileType.FieldName = "ProfileType";
            this.colProfileType.Name = "colProfileType";
            this.colProfileType.Visible = true;
            this.colProfileType.VisibleIndex = 2;
            this.colProfileType.Width = 127;
            // 
            // colAccountBaseType
            // 
            this.colAccountBaseType.FieldName = "AccountBaseType";
            this.colAccountBaseType.Name = "colAccountBaseType";
            this.colAccountBaseType.Visible = true;
            this.colAccountBaseType.VisibleIndex = 3;
            this.colAccountBaseType.Width = 128;
            // 
            // colLedgerPostingEntry
            // 
            this.colLedgerPostingEntry.FieldName = "LedgerPostingEntry";
            this.colLedgerPostingEntry.Name = "colLedgerPostingEntry";
            this.colLedgerPostingEntry.Visible = true;
            this.colLedgerPostingEntry.VisibleIndex = 4;
            this.colLedgerPostingEntry.Width = 133;
            // 
            // colPostingModule
            // 
            this.colPostingModule.FieldName = "PostingModule";
            this.colPostingModule.Name = "colPostingModule";
            this.colPostingModule.Visible = true;
            this.colPostingModule.VisibleIndex = 5;
            this.colPostingModule.Width = 124;
            // 
            // colSetupLines
            // 
            this.colSetupLines.FieldName = "SetupLines";
            this.colSetupLines.Name = "colSetupLines";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 31);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.profileGC);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.setupLinesGC);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(766, 531);
            this.splitContainerControl1.SplitterPosition = 272;
            this.splitContainerControl1.TabIndex = 5;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // ledgerPostingProfileSetupBindingSource
            // 
            this.ledgerPostingProfileSetupBindingSource.DataSource = typeof(B_PowerWin.DB.LedgerPostingProfileSetup);
            // 
            // setupLinesGV
            // 
            this.setupLinesGV.BaseTypeEnum = B_PowerWin.DB.BaseTypeEnum.LedgerPostingProfileSetup;
            this.setupLinesGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProfileId1,
            this.colLineNum,
            this.colPostingScope,
            this.colLineValue,
            this.colLineDescription,
            this.colLedgerPostingProfile,
            this.colLedgerPostingEntry1,
            this.colCVBC_MainAccount,
            this.colInventoryControl_MainAccount,
            this.colSalesRevenue_MainAccount,
            this.colCostOfGoodsSold_MainAccount,
            this.colDeferredRevenue_MainAcount,
            this.colUnInvoicedAR_MainAccount,
            this.colUnderInspectionInventory_MainAccount,
            this.colUnderInspectionVendor_MainAccount});
            this.setupLinesGV.EnableAutoFormat = false;
            this.setupLinesGV.GridControl = this.setupLinesGC;
            this.setupLinesGV.GridViewEditMode = B_PowerWin.GUI.Grid.GridViewEditModeEnum.FormEdit;
            this.setupLinesGV.Name = "setupLinesGV";
            this.setupLinesGV.OptionsView.ColumnAutoWidth = false;
            // 
            // colProfileId1
            // 
            this.colProfileId1.FieldName = "ProfileId";
            this.colProfileId1.Name = "colProfileId1";
            this.colProfileId1.Visible = true;
            this.colProfileId1.VisibleIndex = 0;
            // 
            // colLineNum
            // 
            this.colLineNum.FieldName = "LineNum";
            this.colLineNum.Name = "colLineNum";
            this.colLineNum.Visible = true;
            this.colLineNum.VisibleIndex = 1;
            // 
            // colPostingScope
            // 
            this.colPostingScope.FieldName = "PostingScope";
            this.colPostingScope.Name = "colPostingScope";
            this.colPostingScope.Visible = true;
            this.colPostingScope.VisibleIndex = 2;
            this.colPostingScope.Width = 91;
            // 
            // colLineValue
            // 
            this.colLineValue.FieldName = "LineValue";
            this.colLineValue.Name = "colLineValue";
            this.colLineValue.Visible = true;
            this.colLineValue.VisibleIndex = 3;
            this.colLineValue.Width = 77;
            // 
            // colLineDescription
            // 
            this.colLineDescription.FieldName = "LineDescription";
            this.colLineDescription.Name = "colLineDescription";
            this.colLineDescription.Visible = true;
            this.colLineDescription.VisibleIndex = 4;
            this.colLineDescription.Width = 202;
            // 
            // colLedgerPostingProfile
            // 
            this.colLedgerPostingProfile.FieldName = "LedgerPostingProfile";
            this.colLedgerPostingProfile.Name = "colLedgerPostingProfile";
            this.colLedgerPostingProfile.Visible = true;
            this.colLedgerPostingProfile.VisibleIndex = 5;
            this.colLedgerPostingProfile.Width = 126;
            // 
            // colLedgerPostingEntry1
            // 
            this.colLedgerPostingEntry1.FieldName = "LedgerPostingEntry";
            this.colLedgerPostingEntry1.Name = "colLedgerPostingEntry1";
            this.colLedgerPostingEntry1.Visible = true;
            this.colLedgerPostingEntry1.VisibleIndex = 6;
            this.colLedgerPostingEntry1.Width = 112;
            // 
            // colCVBC_MainAccount
            // 
            this.colCVBC_MainAccount.FieldName = "CVBC_MainAccount";
            this.colCVBC_MainAccount.Name = "colCVBC_MainAccount";
            this.colCVBC_MainAccount.Visible = true;
            this.colCVBC_MainAccount.VisibleIndex = 7;
            this.colCVBC_MainAccount.Width = 101;
            // 
            // colInventoryControl_MainAccount
            // 
            this.colInventoryControl_MainAccount.FieldName = "InventoryControl_MainAccount";
            this.colInventoryControl_MainAccount.Name = "colInventoryControl_MainAccount";
            this.colInventoryControl_MainAccount.Visible = true;
            this.colInventoryControl_MainAccount.VisibleIndex = 8;
            // 
            // colSalesRevenue_MainAccount
            // 
            this.colSalesRevenue_MainAccount.FieldName = "SalesRevenue_MainAccount";
            this.colSalesRevenue_MainAccount.Name = "colSalesRevenue_MainAccount";
            this.colSalesRevenue_MainAccount.Visible = true;
            this.colSalesRevenue_MainAccount.VisibleIndex = 9;
            // 
            // colCostOfGoodsSold_MainAccount
            // 
            this.colCostOfGoodsSold_MainAccount.FieldName = "CostOfGoodsSold_MainAccount";
            this.colCostOfGoodsSold_MainAccount.Name = "colCostOfGoodsSold_MainAccount";
            this.colCostOfGoodsSold_MainAccount.Visible = true;
            this.colCostOfGoodsSold_MainAccount.VisibleIndex = 10;
            // 
            // colDeferredRevenue_MainAcount
            // 
            this.colDeferredRevenue_MainAcount.FieldName = "DeferredRevenue_MainAcount";
            this.colDeferredRevenue_MainAcount.Name = "colDeferredRevenue_MainAcount";
            this.colDeferredRevenue_MainAcount.Visible = true;
            this.colDeferredRevenue_MainAcount.VisibleIndex = 11;
            // 
            // colUnInvoicedAR_MainAccount
            // 
            this.colUnInvoicedAR_MainAccount.FieldName = "UnInvoicedAR_MainAccount";
            this.colUnInvoicedAR_MainAccount.Name = "colUnInvoicedAR_MainAccount";
            this.colUnInvoicedAR_MainAccount.Visible = true;
            this.colUnInvoicedAR_MainAccount.VisibleIndex = 12;
            // 
            // colUnderInspectionInventory_MainAccount
            // 
            this.colUnderInspectionInventory_MainAccount.FieldName = "UnderInspectionInventory_MainAccount";
            this.colUnderInspectionInventory_MainAccount.Name = "colUnderInspectionInventory_MainAccount";
            this.colUnderInspectionInventory_MainAccount.Visible = true;
            this.colUnderInspectionInventory_MainAccount.VisibleIndex = 13;
            // 
            // colUnderInspectionVendor_MainAccount
            // 
            this.colUnderInspectionVendor_MainAccount.FieldName = "UnderInspectionVendor_MainAccount";
            this.colUnderInspectionVendor_MainAccount.Name = "colUnderInspectionVendor_MainAccount";
            this.colUnderInspectionVendor_MainAccount.Visible = true;
            this.colUnderInspectionVendor_MainAccount.VisibleIndex = 14;
            // 
            // setupLinesGC
            // 
            this.setupLinesGC.DataSource = this.ledgerPostingProfileSetupBindingSource;
            this.setupLinesGC.dbContext = null;
            this.setupLinesGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setupLinesGC.Location = new System.Drawing.Point(0, 0);
            this.setupLinesGC.MainView = this.setupLinesGV;
            this.setupLinesGC.MenuManager = this.barManager1;
            this.setupLinesGC.Name = "setupLinesGC";
            this.setupLinesGC.Size = new System.Drawing.Size(489, 531);
            this.setupLinesGC.TabIndex = 0;
            this.setupLinesGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.setupLinesGV});
            // 
            // PostingProfileSetupFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(766, 585);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "PostingProfileSetupFrm";
            this.Controls.SetChildIndex(this.splitContainerControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.profileGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledgerPostingProfileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ledgerPostingProfileSetupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupLinesGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupLinesGC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GUI.Grid.GridCtrlBase profileGC;
        private GUI.Grid.GridViewBase profileGV;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.BindingSource ledgerPostingProfileBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colProfileId;
        private DevExpress.XtraGrid.Columns.GridColumn colProfileName;
        private DevExpress.XtraGrid.Columns.GridColumn colProfileType;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountBaseType;
        private DevExpress.XtraGrid.Columns.GridColumn colLedgerPostingEntry;
        private DevExpress.XtraGrid.Columns.GridColumn colPostingModule;
        private DevExpress.XtraGrid.Columns.GridColumn colSetupLines;
        private System.Windows.Forms.BindingSource ledgerPostingProfileSetupBindingSource;
        private GUI.Grid.GridCtrlBase setupLinesGC;
        private GUI.Grid.GridViewBase setupLinesGV;
        private DevExpress.XtraGrid.Columns.GridColumn colProfileId1;
        private DevExpress.XtraGrid.Columns.GridColumn colLineNum;
        private DevExpress.XtraGrid.Columns.GridColumn colPostingScope;
        private DevExpress.XtraGrid.Columns.GridColumn colLineValue;
        private DevExpress.XtraGrid.Columns.GridColumn colLineDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colLedgerPostingProfile;
        private DevExpress.XtraGrid.Columns.GridColumn colLedgerPostingEntry1;
        private DevExpress.XtraGrid.Columns.GridColumn colCVBC_MainAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colInventoryControl_MainAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesRevenue_MainAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colCostOfGoodsSold_MainAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colDeferredRevenue_MainAcount;
        private DevExpress.XtraGrid.Columns.GridColumn colUnInvoicedAR_MainAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colUnderInspectionInventory_MainAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colUnderInspectionVendor_MainAccount;
    }
}
