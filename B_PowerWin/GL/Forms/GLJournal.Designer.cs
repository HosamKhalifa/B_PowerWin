namespace B_PowerWin.GL.Forms
{
    partial class GLJournal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GLJournal));
            this.documentGLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newBI = new DevExpress.XtraBars.BarButtonItem();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.gLJournalLinesPage = new DevExpress.XtraTab.XtraTabPage();
            this.gLJournalPage = new DevExpress.XtraTab.XtraTabPage();
            this.gLJournalGC = new B_PowerWin.GUI.Grid.GridCtrlBase();
            this.gLJournalGV = new B_PowerWin.GUI.Grid.GridViewBase();
            this.colDocTotalCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyExch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocTotalFC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJournalType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisplayNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferenceNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHeadAccountBaseTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostingPeriod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCityId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxGroupId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxFileNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxCardNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxCommRegisterNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLedgerJournals = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastErrorMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaseType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWFStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.documentGLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.gLJournalPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gLJournalGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gLJournalGV)).BeginInit();
            this.SuspendLayout();
            // 
            // documentGLBindingSource
            // 
            this.documentGLBindingSource.DataSource = typeof(B_PowerWin.DB.DocumentGL);
            // 
            // newBI
            // 
            this.newBI.Caption = "New";
            this.newBI.Glyph = ((System.Drawing.Image)(resources.GetObject("newBI.Glyph")));
            this.newBI.Id = 2;
            this.newBI.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("newBI.LargeGlyph")));
            this.newBI.Name = "newBI";
            this.newBI.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 31);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.gLJournalPage;
            this.xtraTabControl1.Size = new System.Drawing.Size(766, 531);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.gLJournalPage,
            this.gLJournalLinesPage});
            // 
            // gLJournalLinesPage
            // 
            this.gLJournalLinesPage.Name = "gLJournalLinesPage";
            this.gLJournalLinesPage.Size = new System.Drawing.Size(760, 503);
            this.gLJournalLinesPage.Text = "Entry lines";
            // 
            // gLJournalPage
            // 
            this.gLJournalPage.Controls.Add(this.gLJournalGC);
            this.gLJournalPage.Name = "gLJournalPage";
            this.gLJournalPage.Size = new System.Drawing.Size(760, 503);
            this.gLJournalPage.Text = "Entries";
            // 
            // gLJournalGC
            // 
            this.gLJournalGC.DataSource = this.documentGLBindingSource;
            this.gLJournalGC.dbContext = null;
            this.gLJournalGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gLJournalGC.Location = new System.Drawing.Point(0, 0);
            this.gLJournalGC.MainView = this.gLJournalGV;
            this.gLJournalGC.MenuManager = this.barManager1;
            this.gLJournalGC.Name = "gLJournalGC";
            this.gLJournalGC.Size = new System.Drawing.Size(760, 503);
            this.gLJournalGC.TabIndex = 0;
            this.gLJournalGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gLJournalGV});
            // 
            // gLJournalGV
            // 
            this.gLJournalGV.BaseTypeEnum = B_PowerWin.DB.BaseTypeEnum.DocumentGL;
            this.gLJournalGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDocTotalCC,
            this.colCurrencyCode,
            this.colCurrencyExch,
            this.colDocTotalFC,
            this.colJournalType,
            this.colDisplayNum,
            this.colReferenceNum,
            this.colTransDate,
            this.colHeadAccountBaseTypeId,
            this.colPostingPeriod,
            this.colAddress,
            this.colContactName,
            this.colCountryId,
            this.colCountry,
            this.colCityId,
            this.colCity,
            this.colTaxGroupId,
            this.colTaxGroup,
            this.colTaxFileNum,
            this.colTaxCardNum,
            this.colTaxCommRegisterNum,
            this.colLedgerJournals,
            this.colLastErrorMessage,
            this.colId,
            this.colCreatedBy,
            this.colCreatedAt,
            this.colModifiedBy,
            this.colModifiedAt,
            this.colBaseType,
            this.colWFStatus});
            this.gLJournalGV.EnableAutoFormat = false;
            this.gLJournalGV.GridControl = this.gLJournalGC;
            this.gLJournalGV.GridViewEditMode = B_PowerWin.GUI.Grid.GridViewEditModeEnum.FormEdit;
            this.gLJournalGV.Name = "gLJournalGV";
            this.gLJournalGV.OptionsView.ColumnAutoWidth = false;
            this.gLJournalGV.OptionsView.EnableAppearanceEvenRow = true;
            this.gLJournalGV.OptionsView.ShowFooter = true;
            // 
            // colDocTotalCC
            // 
            this.colDocTotalCC.FieldName = "DocTotalCC";
            this.colDocTotalCC.Name = "colDocTotalCC";
            this.colDocTotalCC.Visible = true;
            this.colDocTotalCC.VisibleIndex = 0;
            // 
            // colCurrencyCode
            // 
            this.colCurrencyCode.FieldName = "CurrencyCode";
            this.colCurrencyCode.Name = "colCurrencyCode";
            this.colCurrencyCode.Visible = true;
            this.colCurrencyCode.VisibleIndex = 1;
            // 
            // colCurrencyExch
            // 
            this.colCurrencyExch.FieldName = "CurrencyExch";
            this.colCurrencyExch.Name = "colCurrencyExch";
            this.colCurrencyExch.Visible = true;
            this.colCurrencyExch.VisibleIndex = 2;
            // 
            // colDocTotalFC
            // 
            this.colDocTotalFC.FieldName = "DocTotalFC";
            this.colDocTotalFC.Name = "colDocTotalFC";
            this.colDocTotalFC.Visible = true;
            this.colDocTotalFC.VisibleIndex = 3;
            // 
            // colJournalType
            // 
            this.colJournalType.FieldName = "JournalType.JourName";
            this.colJournalType.Name = "colJournalType";
            this.colJournalType.Visible = true;
            this.colJournalType.VisibleIndex = 4;
            // 
            // colDisplayNum
            // 
            this.colDisplayNum.FieldName = "DisplayNum";
            this.colDisplayNum.Name = "colDisplayNum";
            this.colDisplayNum.Visible = true;
            this.colDisplayNum.VisibleIndex = 5;
            // 
            // colReferenceNum
            // 
            this.colReferenceNum.FieldName = "ReferenceNum";
            this.colReferenceNum.Name = "colReferenceNum";
            this.colReferenceNum.Visible = true;
            this.colReferenceNum.VisibleIndex = 6;
            // 
            // colTransDate
            // 
            this.colTransDate.FieldName = "TransDate";
            this.colTransDate.Name = "colTransDate";
            this.colTransDate.Visible = true;
            this.colTransDate.VisibleIndex = 7;
            // 
            // colHeadAccountBaseTypeId
            // 
            this.colHeadAccountBaseTypeId.FieldName = "HeadAccountBaseTypeId";
            this.colHeadAccountBaseTypeId.Name = "colHeadAccountBaseTypeId";
            // 
            // colPostingPeriod
            // 
            this.colPostingPeriod.FieldName = "PostingPeriod";
            this.colPostingPeriod.Name = "colPostingPeriod";
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            // 
            // colContactName
            // 
            this.colContactName.FieldName = "ContactName";
            this.colContactName.Name = "colContactName";
            // 
            // colCountryId
            // 
            this.colCountryId.FieldName = "CountryId";
            this.colCountryId.Name = "colCountryId";
            // 
            // colCountry
            // 
            this.colCountry.FieldName = "Country";
            this.colCountry.Name = "colCountry";
            // 
            // colCityId
            // 
            this.colCityId.FieldName = "CityId";
            this.colCityId.Name = "colCityId";
            // 
            // colCity
            // 
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            // 
            // colTaxGroupId
            // 
            this.colTaxGroupId.FieldName = "TaxGroupId";
            this.colTaxGroupId.Name = "colTaxGroupId";
            // 
            // colTaxGroup
            // 
            this.colTaxGroup.FieldName = "TaxGroup";
            this.colTaxGroup.Name = "colTaxGroup";
            // 
            // colTaxFileNum
            // 
            this.colTaxFileNum.FieldName = "TaxFileNum";
            this.colTaxFileNum.Name = "colTaxFileNum";
            // 
            // colTaxCardNum
            // 
            this.colTaxCardNum.FieldName = "TaxCardNum";
            this.colTaxCardNum.Name = "colTaxCardNum";
            // 
            // colTaxCommRegisterNum
            // 
            this.colTaxCommRegisterNum.FieldName = "TaxCommRegisterNum";
            this.colTaxCommRegisterNum.Name = "colTaxCommRegisterNum";
            // 
            // colLedgerJournals
            // 
            this.colLedgerJournals.FieldName = "LedgerJournals";
            this.colLedgerJournals.Name = "colLedgerJournals";
            // 
            // colLastErrorMessage
            // 
            this.colLastErrorMessage.FieldName = "LastErrorMessage";
            this.colLastErrorMessage.Name = "colLastErrorMessage";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
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
            // 
            // colModifiedAt
            // 
            this.colModifiedAt.FieldName = "ModifiedAt";
            this.colModifiedAt.Name = "colModifiedAt";
            // 
            // colBaseType
            // 
            this.colBaseType.FieldName = "BaseType";
            this.colBaseType.Name = "colBaseType";
            // 
            // colWFStatus
            // 
            this.colWFStatus.FieldName = "WFStatus";
            this.colWFStatus.Name = "colWFStatus";
            this.colWFStatus.Visible = true;
            this.colWFStatus.VisibleIndex = 8;
            // 
            // GLJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(766, 585);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "GLJournal";
            this.Text = " ";
            this.Controls.SetChildIndex(this.xtraTabControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.documentGLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.gLJournalPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gLJournalGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gLJournalGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource documentGLBindingSource;
        private DevExpress.XtraBars.BarButtonItem newBI;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage gLJournalLinesPage;
        private DevExpress.XtraTab.XtraTabPage gLJournalPage;
        private GUI.Grid.GridCtrlBase gLJournalGC;
        private GUI.Grid.GridViewBase gLJournalGV;
        private DevExpress.XtraGrid.Columns.GridColumn colDocTotalCC;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyExch;
        private DevExpress.XtraGrid.Columns.GridColumn colDocTotalFC;
        private DevExpress.XtraGrid.Columns.GridColumn colJournalType;
        private DevExpress.XtraGrid.Columns.GridColumn colDisplayNum;
        private DevExpress.XtraGrid.Columns.GridColumn colReferenceNum;
        private DevExpress.XtraGrid.Columns.GridColumn colTransDate;
        private DevExpress.XtraGrid.Columns.GridColumn colHeadAccountBaseTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colPostingPeriod;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colContactName;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryId;
        private DevExpress.XtraGrid.Columns.GridColumn colCountry;
        private DevExpress.XtraGrid.Columns.GridColumn colCityId;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxGroupId;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxFileNum;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxCardNum;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxCommRegisterNum;
        private DevExpress.XtraGrid.Columns.GridColumn colLedgerJournals;
        private DevExpress.XtraGrid.Columns.GridColumn colLastErrorMessage;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseType;
        private DevExpress.XtraGrid.Columns.GridColumn colWFStatus;
    }
}
