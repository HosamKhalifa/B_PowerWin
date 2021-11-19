namespace B_PowerWin.GL.Forms
{
    partial class CashFrm
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
            this.cashGC = new B_PowerWin.GUI.Grid.GridCtrlBase();
            this.cashBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cashGV = new B_PowerWin.GUI.Grid.GridViewBase();
            this.colEmployee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.cashGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashGV)).BeginInit();
            this.SuspendLayout();
            // 
            // cashGC
            // 
            this.cashGC.DataSource = this.cashBindingSource;
            this.cashGC.dbContext = null;
            this.cashGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cashGC.Location = new System.Drawing.Point(0, 31);
            this.cashGC.MainView = this.cashGV;
            this.cashGC.MenuManager = this.barManager1;
            this.cashGC.Name = "cashGC";
            this.cashGC.Size = new System.Drawing.Size(766, 531);
            this.cashGC.TabIndex = 4;
            this.cashGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cashGV});
            // 
            // cashBindingSource
            // 
            this.cashBindingSource.DataSource = typeof(B_PowerWin.DB.Cash);
            // 
            // cashGV
            // 
            this.cashGV.BaseTypeEnum = B_PowerWin.DB.BaseTypeEnum.Cash;
            this.cashGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWFStatus,
            this.colId,
            this.colReferenceNum,
            this.colName,
            this.colDescription,
            this.colGroupId,
            this.colEmployee,
            this.colSuspended,
            this.colAccountGroup,
            this.colCreatedBy,
            this.colCreatedAt,
            this.colModifiedBy,
            this.colModifiedAt});
            this.cashGV.EnableAutoFormat = false;
            this.cashGV.GridControl = this.cashGC;
            this.cashGV.GridViewEditMode = B_PowerWin.GUI.Grid.GridViewEditModeEnum.FormEdit;
            this.cashGV.Name = "cashGV";
            this.cashGV.OptionsView.ColumnAutoWidth = false;
            this.cashGV.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colId, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colEmployee
            // 
            this.colEmployee.FieldName = "Employee";
            this.colEmployee.Name = "colEmployee";
            this.colEmployee.Visible = true;
            this.colEmployee.VisibleIndex = 5;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 3;
            this.colName.Width = 171;
            // 
            // colReferenceNum
            // 
            this.colReferenceNum.FieldName = "ReferenceNum";
            this.colReferenceNum.Name = "colReferenceNum";
            this.colReferenceNum.Visible = true;
            this.colReferenceNum.VisibleIndex = 2;
            this.colReferenceNum.Width = 71;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 6;
            this.colDescription.Width = 155;
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
            this.colSuspended.VisibleIndex = 4;
            // 
            // colAccountGroup
            // 
            this.colAccountGroup.Caption = "Group name";
            this.colAccountGroup.FieldName = "AccountGroup.FullName";
            this.colAccountGroup.Name = "colAccountGroup";
            this.colAccountGroup.Visible = true;
            this.colAccountGroup.VisibleIndex = 7;
            this.colAccountGroup.Width = 172;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 1;
            this.colId.Width = 58;
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
            this.colModifiedBy.VisibleIndex = 8;
            // 
            // colModifiedAt
            // 
            this.colModifiedAt.FieldName = "ModifiedAt";
            this.colModifiedAt.Name = "colModifiedAt";
            this.colModifiedAt.Visible = true;
            this.colModifiedAt.VisibleIndex = 9;
            // 
            // colWFStatus
            // 
            this.colWFStatus.FieldName = "WFStatus";
            this.colWFStatus.Name = "colWFStatus";
            this.colWFStatus.Visible = true;
            this.colWFStatus.VisibleIndex = 0;
            this.colWFStatus.Width = 63;
            // 
            // CashFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(766, 585);
            this.Controls.Add(this.cashGC);
            this.Name = "CashFrm";
            this.Controls.SetChildIndex(this.cashGC, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cashGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GUI.Grid.GridCtrlBase cashGC;
        private GUI.Grid.GridViewBase cashGV;
        private System.Windows.Forms.BindingSource cashBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
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
