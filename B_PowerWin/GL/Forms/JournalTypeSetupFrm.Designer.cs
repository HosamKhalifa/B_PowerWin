namespace B_PowerWin.GL.Forms
{
    partial class JournalTypeSetupFrm
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
            this.jourTypeGC = new B_PowerWin.GUI.Grid.GridCtrlBase();
            this.jourTypeBS = new System.Windows.Forms.BindingSource(this.components);
            this.jourTypeGV = new B_PowerWin.GUI.Grid.GridViewBase();
            this.colLedgerJournals = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocuments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJourType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJourName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostingLayer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSequId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSysSequence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSequGenerateAtPosting = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetailSummary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmountsInclueTax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastErrorMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaseType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWFStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.jourTypeGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jourTypeBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jourTypeGV)).BeginInit();
            this.SuspendLayout();
            // 
            // jourTypeGC
            // 
            this.jourTypeGC.DataSource = this.jourTypeBS;
            this.jourTypeGC.dbContext = null;
            this.jourTypeGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jourTypeGC.Location = new System.Drawing.Point(0, 31);
            this.jourTypeGC.MainView = this.jourTypeGV;
            this.jourTypeGC.MenuManager = this.barManager1;
            this.jourTypeGC.Name = "jourTypeGC";
            this.jourTypeGC.Size = new System.Drawing.Size(854, 531);
            this.jourTypeGC.TabIndex = 4;
            this.jourTypeGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.jourTypeGV});
            // 
            // jourTypeBS
            // 
            this.jourTypeBS.DataSource = typeof(B_PowerWin.DB.JournalType);
            // 
            // jourTypeGV
            // 
            this.jourTypeGV.BaseTypeEnum = B_PowerWin.DB.BaseTypeEnum.JournalType;
            this.jourTypeGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLedgerJournals,
            this.colDocuments,
            this.colCompanyId,
            this.colJourType,
            this.colJourName,
            this.colPostingLayer,
            this.colSequId,
            this.colSysSequence,
            this.colSequGenerateAtPosting,
            this.colDetailSummary,
            this.colAmountsInclueTax,
            this.colLastErrorMessage,
            this.colId,
            this.colCreatedBy,
            this.colCreatedAt,
            this.colModifiedBy,
            this.colModifiedAt,
            this.colBaseType,
            this.colWFStatus});
            this.jourTypeGV.EnableAutoFormat = false;
            this.jourTypeGV.GridControl = this.jourTypeGC;
            this.jourTypeGV.GridViewEditMode = B_PowerWin.GUI.Grid.GridViewEditModeEnum.FormEdit;
            this.jourTypeGV.Name = "jourTypeGV";
            this.jourTypeGV.OptionsView.ColumnAutoWidth = false;
            this.jourTypeGV.OptionsView.EnableAppearanceEvenRow = true;
            this.jourTypeGV.OptionsView.ShowAutoFilterRow = true;
            this.jourTypeGV.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colId, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colLedgerJournals
            // 
            this.colLedgerJournals.FieldName = "LedgerJournals";
            this.colLedgerJournals.Name = "colLedgerJournals";
            // 
            // colDocuments
            // 
            this.colDocuments.FieldName = "Documents";
            this.colDocuments.Name = "colDocuments";
            // 
            // colCompanyId
            // 
            this.colCompanyId.FieldName = "CompanyId";
            this.colCompanyId.Name = "colCompanyId";
            // 
            // colJourType
            // 
            this.colJourType.FieldName = "JourType";
            this.colJourType.Name = "colJourType";
            this.colJourType.Visible = true;
            this.colJourType.VisibleIndex = 3;
            // 
            // colJourName
            // 
            this.colJourName.FieldName = "JourName";
            this.colJourName.Name = "colJourName";
            this.colJourName.Visible = true;
            this.colJourName.VisibleIndex = 2;
            this.colJourName.Width = 138;
            // 
            // colPostingLayer
            // 
            this.colPostingLayer.FieldName = "PostingLayer";
            this.colPostingLayer.Name = "colPostingLayer";
            this.colPostingLayer.Visible = true;
            this.colPostingLayer.VisibleIndex = 4;
            // 
            // colSequId
            // 
            this.colSequId.FieldName = "SequId";
            this.colSequId.Name = "colSequId";
            this.colSequId.Visible = true;
            this.colSequId.VisibleIndex = 5;
            // 
            // colSysSequence
            // 
            this.colSysSequence.FieldName = "SysSequence";
            this.colSysSequence.Name = "colSysSequence";
            // 
            // colSequGenerateAtPosting
            // 
            this.colSequGenerateAtPosting.FieldName = "SequGenerateAtPosting";
            this.colSequGenerateAtPosting.Name = "colSequGenerateAtPosting";
            this.colSequGenerateAtPosting.Visible = true;
            this.colSequGenerateAtPosting.VisibleIndex = 6;
            // 
            // colDetailSummary
            // 
            this.colDetailSummary.FieldName = "DetailSummary";
            this.colDetailSummary.Name = "colDetailSummary";
            this.colDetailSummary.Visible = true;
            this.colDetailSummary.VisibleIndex = 7;
            this.colDetailSummary.Width = 79;
            // 
            // colAmountsInclueTax
            // 
            this.colAmountsInclueTax.FieldName = "AmountsInclueTax";
            this.colAmountsInclueTax.Name = "colAmountsInclueTax";
            this.colAmountsInclueTax.Visible = true;
            this.colAmountsInclueTax.VisibleIndex = 8;
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
            this.colId.Visible = true;
            this.colId.VisibleIndex = 1;
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
            this.colModifiedBy.VisibleIndex = 9;
            // 
            // colModifiedAt
            // 
            this.colModifiedAt.FieldName = "ModifiedAt";
            this.colModifiedAt.Name = "colModifiedAt";
            this.colModifiedAt.Visible = true;
            this.colModifiedAt.VisibleIndex = 10;
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
            this.colWFStatus.VisibleIndex = 0;
            // 
            // JournalTypeSetupFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(854, 585);
            this.Controls.Add(this.jourTypeGC);
            this.Name = "JournalTypeSetupFrm";
            this.Controls.SetChildIndex(this.jourTypeGC, 0);
            ((System.ComponentModel.ISupportInitialize)(this.jourTypeGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jourTypeBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jourTypeGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GUI.Grid.GridCtrlBase jourTypeGC;
        private GUI.Grid.GridViewBase jourTypeGV;
        private System.Windows.Forms.BindingSource jourTypeBS;
        private DevExpress.XtraGrid.Columns.GridColumn colLedgerJournals;
        private DevExpress.XtraGrid.Columns.GridColumn colDocuments;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyId;
        private DevExpress.XtraGrid.Columns.GridColumn colJourType;
        private DevExpress.XtraGrid.Columns.GridColumn colJourName;
        private DevExpress.XtraGrid.Columns.GridColumn colPostingLayer;
        private DevExpress.XtraGrid.Columns.GridColumn colSequId;
        private DevExpress.XtraGrid.Columns.GridColumn colSysSequence;
        private DevExpress.XtraGrid.Columns.GridColumn colSequGenerateAtPosting;
        private DevExpress.XtraGrid.Columns.GridColumn colDetailSummary;
        private DevExpress.XtraGrid.Columns.GridColumn colAmountsInclueTax;
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
