namespace B_PowerWin.GL.Forms
{
    partial class BankFrm
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
            this.bankGC = new B_PowerWin.GUI.Grid.GridCtrlBase();
            this.bankBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankGV = new B_PowerWin.GUI.Grid.GridViewBase();
            this.colWFStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferenceNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisplayNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bankGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankGV)).BeginInit();
            this.SuspendLayout();
            // 
            // bankGC
            // 
            this.bankGC.DataSource = this.bankBindingSource;
            this.bankGC.dbContext = null;
            this.bankGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bankGC.Location = new System.Drawing.Point(0, 31);
            this.bankGC.MainView = this.bankGV;
            this.bankGC.MenuManager = this.barManager1;
            this.bankGC.Name = "bankGC";
            this.bankGC.Size = new System.Drawing.Size(766, 531);
            this.bankGC.TabIndex = 4;
            this.bankGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bankGV});
            // 
            // bankBindingSource
            // 
            this.bankBindingSource.DataSource = typeof(B_PowerWin.DB.Bank);
            // 
            // bankGV
            // 
            this.bankGV.BaseTypeEnum = B_PowerWin.DB.BaseTypeEnum.Bank;
            this.bankGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWFStatus,
            this.colId,
            this.colReferenceNum,
            this.colDisplayNum,
            this.colName,
            this.colDescription,
            this.colGroupId,
            this.colAccountGroup,
            this.colCreatedBy,
            this.colCreatedAt,
            this.colModifiedBy,
            this.colModifiedAt});
            this.bankGV.EnableAutoFormat = false;
            this.bankGV.GridControl = this.bankGC;
            this.bankGV.GridViewEditMode = B_PowerWin.GUI.Grid.GridViewEditModeEnum.FormEdit;
            this.bankGV.Name = "bankGV";
            this.bankGV.OptionsView.ColumnAutoWidth = false;
            this.bankGV.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colId, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colWFStatus
            // 
            this.colWFStatus.FieldName = "WFStatus";
            this.colWFStatus.Name = "colWFStatus";
            this.colWFStatus.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colWFStatus.Visible = true;
            this.colWFStatus.VisibleIndex = 0;
            this.colWFStatus.Width = 62;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 1;
            this.colId.Width = 58;
            // 
            // colReferenceNum
            // 
            this.colReferenceNum.FieldName = "ReferenceNum";
            this.colReferenceNum.Name = "colReferenceNum";
            this.colReferenceNum.OptionsEditForm.VisibleIndex = 10;
            this.colReferenceNum.Visible = true;
            this.colReferenceNum.VisibleIndex = 2;
            this.colReferenceNum.Width = 68;
            // 
            // colDisplayNum
            // 
            this.colDisplayNum.FieldName = "DisplayNum";
            this.colDisplayNum.Name = "colDisplayNum";
            this.colDisplayNum.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colDisplayNum.Visible = true;
            this.colDisplayNum.VisibleIndex = 3;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsEditForm.VisibleIndex = 20;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 4;
            this.colName.Width = 196;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colDescription.OptionsEditForm.VisibleIndex = 40;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 5;
            // 
            // colGroupId
            // 
            this.colGroupId.FieldName = "GroupId";
            this.colGroupId.Name = "colGroupId";
            this.colGroupId.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colGroupId.OptionsEditForm.VisibleIndex = 30;
            this.colGroupId.Visible = true;
            this.colGroupId.VisibleIndex = 6;
            // 
            // colAccountGroup
            // 
            this.colAccountGroup.Caption = "Group FullName";
            this.colAccountGroup.FieldName = "AccountGroup.FullName";
            this.colAccountGroup.Name = "colAccountGroup";
            this.colAccountGroup.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colAccountGroup.Visible = true;
            this.colAccountGroup.VisibleIndex = 7;
            this.colAccountGroup.Width = 162;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.FieldName = "CreatedBy";
            this.colCreatedBy.Name = "colCreatedBy";
            this.colCreatedBy.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.FieldName = "CreatedAt";
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colModifiedBy
            // 
            this.colModifiedBy.FieldName = "ModifiedBy";
            this.colModifiedBy.Name = "colModifiedBy";
            this.colModifiedBy.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colModifiedBy.Visible = true;
            this.colModifiedBy.VisibleIndex = 8;
            // 
            // colModifiedAt
            // 
            this.colModifiedAt.FieldName = "ModifiedAt";
            this.colModifiedAt.Name = "colModifiedAt";
            this.colModifiedAt.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colModifiedAt.Visible = true;
            this.colModifiedAt.VisibleIndex = 9;
            // 
            // BankFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(766, 585);
            this.Controls.Add(this.bankGC);
            this.Name = "BankFrm";
            this.Controls.SetChildIndex(this.bankGC, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bankGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GUI.Grid.GridCtrlBase bankGC;
        private GUI.Grid.GridViewBase bankGV;
        private System.Windows.Forms.BindingSource bankBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDisplayNum;
        private DevExpress.XtraGrid.Columns.GridColumn colReferenceNum;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupId;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colWFStatus;
    }
}
