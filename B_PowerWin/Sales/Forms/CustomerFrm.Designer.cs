namespace B_PowerWin.Sales.Forms
{
    partial class CustomerFrm
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
            this.customerGC = new B_PowerWin.GUI.Grid.GridCtrlBase();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerGV = new B_PowerWin.GUI.Grid.GridViewBase();
            this.colCreditLimit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisplayNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferenceNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuspended = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWFStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customerGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerGV)).BeginInit();
            this.SuspendLayout();
            // 
            // customerGC
            // 
            this.customerGC.DataSource = this.customerBindingSource;
            this.customerGC.dbContext = null;
            this.customerGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerGC.Location = new System.Drawing.Point(0, 31);
            this.customerGC.MainView = this.customerGV;
            this.customerGC.MenuManager = this.barManager1;
            this.customerGC.Name = "customerGC";
            this.customerGC.Size = new System.Drawing.Size(766, 531);
            this.customerGC.TabIndex = 4;
            this.customerGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.customerGV});
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(B_PowerWin.DB.Customer);
            // 
            // customerGV
            // 
            this.customerGV.BaseTypeEnum = B_PowerWin.DB.BaseTypeEnum.None;
            this.customerGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWFStatus,
            this.colId,
            this.colReferenceNum,
            this.colName,
            this.colDescription,
            this.colGroupId,
            this.colCreditLimit,
            this.colCompanyId,
            this.colDisplayNum,
            this.colSuspended,
            this.colAccountGroup,
            this.colCreatedBy,
            this.colCreatedAt,
            this.colModifiedBy,
            this.colModifiedAt});
            this.customerGV.EnableAutoFormat = false;
            this.customerGV.GridControl = this.customerGC;
            this.customerGV.GridViewEditMode = B_PowerWin.GUI.Grid.GridViewEditModeEnum.FormEdit;
            this.customerGV.Name = "customerGV";
            this.customerGV.OptionsView.ColumnAutoWidth = false;
            this.customerGV.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colId, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colCreditLimit
            // 
            this.colCreditLimit.FieldName = "CreditLimit";
            this.colCreditLimit.Name = "colCreditLimit";
            this.colCreditLimit.Visible = true;
            this.colCreditLimit.VisibleIndex = 6;
            // 
            // colCompanyId
            // 
            this.colCompanyId.FieldName = "CompanyId";
            this.colCompanyId.Name = "colCompanyId";
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 3;
            this.colName.Width = 167;
            // 
            // colDisplayNum
            // 
            this.colDisplayNum.FieldName = "DisplayNum";
            this.colDisplayNum.Name = "colDisplayNum";
            // 
            // colReferenceNum
            // 
            this.colReferenceNum.FieldName = "ReferenceNum";
            this.colReferenceNum.Name = "colReferenceNum";
            this.colReferenceNum.Visible = true;
            this.colReferenceNum.VisibleIndex = 2;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 4;
            this.colDescription.Width = 137;
            // 
            // colGroupId
            // 
            this.colGroupId.FieldName = "GroupId";
            this.colGroupId.Name = "colGroupId";
            // 
            // colSuspended
            // 
            this.colSuspended.FieldName = "Suspended";
            this.colSuspended.Name = "colSuspended";
            this.colSuspended.Visible = true;
            this.colSuspended.VisibleIndex = 5;
            // 
            // colAccountGroup
            // 
            this.colAccountGroup.FieldName = "AccountGroup.FullName";
            this.colAccountGroup.Name = "colAccountGroup";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 1;
            this.colId.Width = 64;
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
            // 
            // colWFStatus
            // 
            this.colWFStatus.FieldName = "WFStatus";
            this.colWFStatus.Name = "colWFStatus";
            this.colWFStatus.Visible = true;
            this.colWFStatus.VisibleIndex = 0;
            this.colWFStatus.Width = 70;
            // 
            // CustomerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(766, 585);
            this.Controls.Add(this.customerGC);
            this.Name = "CustomerFrm";
            this.Controls.SetChildIndex(this.customerGC, 0);
            ((System.ComponentModel.ISupportInitialize)(this.customerGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GUI.Grid.GridCtrlBase customerGC;
        private GUI.Grid.GridViewBase customerGV;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCreditLimit;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDisplayNum;
        private DevExpress.XtraGrid.Columns.GridColumn colReferenceNum;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupId;
        private DevExpress.XtraGrid.Columns.GridColumn colSuspended;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colWFStatus;
    }
}
