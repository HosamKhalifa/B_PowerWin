namespace B_PowerWin.GL.Forms
{
    partial class AccountGroupEditorFrm
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
            this.accountGroupGC = new B_PowerWin.GUI.Grid.GridCtrlBase();
            this.accountGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountGroupGV = new B_PowerWin.GUI.Grid.GridViewBase();
            this.colWFStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferenceNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.accountGroupGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountGroupGV)).BeginInit();
            this.SuspendLayout();
            // 
            // accountGroupGC
            // 
            this.accountGroupGC.DataSource = this.accountGroupBindingSource;
            this.accountGroupGC.dbContext = null;
            this.accountGroupGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountGroupGC.Location = new System.Drawing.Point(0, 31);
            this.accountGroupGC.MainView = this.accountGroupGV;
            this.accountGroupGC.MenuManager = this.barManager1;
            this.accountGroupGC.Name = "accountGroupGC";
            this.accountGroupGC.Size = new System.Drawing.Size(766, 531);
            this.accountGroupGC.TabIndex = 4;
            this.accountGroupGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.accountGroupGV});
            // 
            // accountGroupBindingSource
            // 
            this.accountGroupBindingSource.DataSource = typeof(B_PowerWin.DB.AccountGroup);
            // 
            // accountGroupGV
            // 
            this.accountGroupGV.BaseTypeEnum = B_PowerWin.DB.BaseTypeEnum.None;
            this.accountGroupGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWFStatus,
            this.colId,
            this.colReferenceNum,
            this.colName,
            this.colCreatedBy,
            this.colCreatedAt,
            this.colModifiedBy,
            this.colModifiedAt});
            this.accountGroupGV.EnableAutoFormat = false;
            this.accountGroupGV.GridControl = this.accountGroupGC;
            this.accountGroupGV.GridViewEditMode = B_PowerWin.GUI.Grid.GridViewEditModeEnum.FormEdit;
            this.accountGroupGV.Name = "accountGroupGV";
            this.accountGroupGV.OptionsView.ColumnAutoWidth = false;
            // 
            // colWFStatus
            // 
            this.colWFStatus.FieldName = "WFStatus";
            this.colWFStatus.Name = "colWFStatus";
            this.colWFStatus.Visible = true;
            this.colWFStatus.VisibleIndex = 0;
            this.colWFStatus.Width = 70;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Width = 52;
            // 
            // colReferenceNum
            // 
            this.colReferenceNum.FieldName = "ReferenceNum";
            this.colReferenceNum.Name = "colReferenceNum";
            this.colReferenceNum.Visible = true;
            this.colReferenceNum.VisibleIndex = 1;
            this.colReferenceNum.Width = 87;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            this.colName.Width = 249;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.FieldName = "CreatedBy";
            this.colCreatedBy.Name = "colCreatedBy";
            this.colCreatedBy.Width = 52;
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.FieldName = "CreatedAt";
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.Width = 52;
            // 
            // colModifiedBy
            // 
            this.colModifiedBy.FieldName = "ModifiedBy";
            this.colModifiedBy.Name = "colModifiedBy";
            this.colModifiedBy.Width = 52;
            // 
            // colModifiedAt
            // 
            this.colModifiedAt.FieldName = "ModifiedAt";
            this.colModifiedAt.Name = "colModifiedAt";
            this.colModifiedAt.Width = 72;
            // 
            // AccountGroupEditorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(766, 585);
            this.Controls.Add(this.accountGroupGC);
            this.Name = "AccountGroupEditorFrm";
            this.Controls.SetChildIndex(this.accountGroupGC, 0);
            ((System.ComponentModel.ISupportInitialize)(this.accountGroupGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountGroupGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GUI.Grid.GridCtrlBase accountGroupGC;
        private GUI.Grid.GridViewBase accountGroupGV;
        private System.Windows.Forms.BindingSource accountGroupBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colReferenceNum;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colWFStatus;
    }
}
