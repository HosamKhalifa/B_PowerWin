namespace B_PowerWin.Sales.Forms
{
    partial class CustomerListPageFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerListPageFrm));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.newBI = new DevExpress.XtraBars.BarButtonItem();
            this.editBI = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.customerListPageQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerGC = new B_PowerWin.GUI.Grid.GridCtrlBase();
            this.customerGV = new B_PowerWin.GUI.Grid.GridViewBase();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferenceNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisplayNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxGroup_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountry_IsoCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreditLimit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWFStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.refreshBI = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerListPageQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerGV)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.newBI,
            this.editBI,
            this.refreshBI});
            this.barManager1.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.newBI),
            new DevExpress.XtraBars.LinkPersistInfo(this.editBI),
            new DevExpress.XtraBars.LinkPersistInfo(this.refreshBI)});
            this.bar1.Text = "Tools";
            // 
            // newBI
            // 
            this.newBI.Caption = "New";
            this.newBI.Glyph = ((System.Drawing.Image)(resources.GetObject("newBI.Glyph")));
            this.newBI.Id = 0;
            this.newBI.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("newBI.LargeGlyph")));
            this.newBI.Name = "newBI";
            this.newBI.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // editBI
            // 
            this.editBI.Caption = "Edit..";
            this.editBI.Glyph = ((System.Drawing.Image)(resources.GetObject("editBI.Glyph")));
            this.editBI.Id = 1;
            this.editBI.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("editBI.LargeGlyph")));
            this.editBI.Name = "editBI";
            this.editBI.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(766, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 585);
            this.barDockControlBottom.Size = new System.Drawing.Size(766, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 554);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(766, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 554);
            // 
            // customerListPageQueryBindingSource
            // 
            this.customerListPageQueryBindingSource.DataSource = typeof(B_PowerWin.DB.Query.CustomerListPageQuery);
            // 
            // customerGC
            // 
            this.customerGC.DataSource = this.customerListPageQueryBindingSource;
            this.customerGC.dbContext = null;
            this.customerGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerGC.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.customerGC.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.customerGC.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.customerGC.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.customerGC.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.customerGC.Location = new System.Drawing.Point(0, 31);
            this.customerGC.MainView = this.customerGV;
            this.customerGC.MenuManager = this.barManager1;
            this.customerGC.Name = "customerGC";
            this.customerGC.Size = new System.Drawing.Size(766, 554);
            this.customerGC.TabIndex = 4;
            this.customerGC.UseEmbeddedNavigator = true;
            this.customerGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.customerGV});
            // 
            // customerGV
            // 
            this.customerGV.BaseTypeEnum = B_PowerWin.DB.BaseTypeEnum.None;
            this.customerGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colReferenceNum,
            this.colDisplayNum,
            this.colName,
            this.colCompanyId,
            this.colTaxGroup_Id,
            this.colCountry_IsoCode,
            this.colDescription,
            this.colGroupId,
            this.colGroupFullName,
            this.colCreditLimit,
            this.colCreatedBy,
            this.colCreatedAt,
            this.colModifiedBy,
            this.colModifiedAt,
            this.colWFStatus});
            this.customerGV.EnableAutoFormat = false;
            this.customerGV.GridControl = this.customerGC;
            this.customerGV.GridViewEditMode = B_PowerWin.GUI.Grid.GridViewEditModeEnum.FormEdit;
            this.customerGV.Name = "customerGV";
            this.customerGV.OptionsView.ColumnAutoWidth = false;
            this.customerGV.OptionsView.EnableAppearanceEvenRow = true;
            this.customerGV.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colId, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 1;
            this.colId.Width = 60;
            // 
            // colReferenceNum
            // 
            this.colReferenceNum.FieldName = "ReferenceNum";
            this.colReferenceNum.Name = "colReferenceNum";
            this.colReferenceNum.Visible = true;
            this.colReferenceNum.VisibleIndex = 2;
            // 
            // colDisplayNum
            // 
            this.colDisplayNum.FieldName = "DisplayNum";
            this.colDisplayNum.Name = "colDisplayNum";
            this.colDisplayNum.Visible = true;
            this.colDisplayNum.VisibleIndex = 3;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 4;
            this.colName.Width = 177;
            // 
            // colCompanyId
            // 
            this.colCompanyId.FieldName = "CompanyId";
            this.colCompanyId.Name = "colCompanyId";
            // 
            // colTaxGroup_Id
            // 
            this.colTaxGroup_Id.FieldName = "TaxGroup_Id";
            this.colTaxGroup_Id.Name = "colTaxGroup_Id";
            this.colTaxGroup_Id.Width = 86;
            // 
            // colCountry_IsoCode
            // 
            this.colCountry_IsoCode.FieldName = "Country_IsoCode";
            this.colCountry_IsoCode.Name = "colCountry_IsoCode";
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            // 
            // colGroupId
            // 
            this.colGroupId.FieldName = "GroupId";
            this.colGroupId.Name = "colGroupId";
            // 
            // colGroupFullName
            // 
            this.colGroupFullName.FieldName = "GroupFullName";
            this.colGroupFullName.Name = "colGroupFullName";
            this.colGroupFullName.Visible = true;
            this.colGroupFullName.VisibleIndex = 5;
            this.colGroupFullName.Width = 180;
            // 
            // colCreditLimit
            // 
            this.colCreditLimit.FieldName = "CreditLimit";
            this.colCreditLimit.Name = "colCreditLimit";
            this.colCreditLimit.Visible = true;
            this.colCreditLimit.VisibleIndex = 6;
            this.colCreditLimit.Width = 86;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.FieldName = "CreatedBy";
            this.colCreatedBy.Name = "colCreatedBy";
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.FieldName = "CreatedAt";
            this.colCreatedAt.Name = "colCreatedAt";
            // 
            // colModifiedBy
            // 
            this.colModifiedBy.FieldName = "ModifiedBy";
            this.colModifiedBy.Name = "colModifiedBy";
            this.colModifiedBy.Visible = true;
            this.colModifiedBy.VisibleIndex = 7;
            // 
            // colModifiedAt
            // 
            this.colModifiedAt.FieldName = "ModifiedAt";
            this.colModifiedAt.Name = "colModifiedAt";
            this.colModifiedAt.Visible = true;
            this.colModifiedAt.VisibleIndex = 8;
            this.colModifiedAt.Width = 96;
            // 
            // colWFStatus
            // 
            this.colWFStatus.FieldName = "WFStatus";
            this.colWFStatus.Name = "colWFStatus";
            this.colWFStatus.Visible = true;
            this.colWFStatus.VisibleIndex = 0;
            // 
            // refreshBI
            // 
            this.refreshBI.Caption = "Refresh";
            this.refreshBI.Glyph = ((System.Drawing.Image)(resources.GetObject("refreshBI.Glyph")));
            this.refreshBI.Id = 2;
            this.refreshBI.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("refreshBI.LargeGlyph")));
            this.refreshBI.Name = "refreshBI";
            this.refreshBI.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // CustomerListPageFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(766, 585);
            this.Controls.Add(this.customerGC);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "CustomerListPageFrm";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerListPageQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem newBI;
        private System.Windows.Forms.BindingSource customerListPageQueryBindingSource;
        private GUI.Grid.GridCtrlBase customerGC;
        private GUI.Grid.GridViewBase customerGV;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colReferenceNum;
        private DevExpress.XtraGrid.Columns.GridColumn colDisplayNum;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyId;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxGroup_Id;
        private DevExpress.XtraGrid.Columns.GridColumn colCountry_IsoCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupId;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colCreditLimit;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colWFStatus;
        private DevExpress.XtraBars.BarButtonItem editBI;
        private DevExpress.XtraBars.BarButtonItem refreshBI;
    }
}
