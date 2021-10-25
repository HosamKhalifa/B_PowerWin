namespace B_PowerWin.GL.Forms
{
    partial class MainAccountGroupFrm
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
            this.mainAccountGroupBindingSource = new System.Windows.Forms.BindingSource();
            this.mainAccountGroupGC = new B_PowerWin.GUI.Grid.GridCtrlBase();
            this.mainAccountGroupGV = new B_PowerWin.GUI.Grid.GridViewBase();
            this.colGroupNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMainAccountType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMainAccounts = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastErrorMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaseType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParnetId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.saveLayoutBI = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountGroupGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountGroupGV)).BeginInit();
            this.SuspendLayout();
            // 
            // mainAccountGroupBindingSource
            // 
            this.mainAccountGroupBindingSource.DataSource = typeof(B_PowerWin.DB.MainAccountGroup);
            // 
            // mainAccountGroupGC
            // 
            this.mainAccountGroupGC.DataSource = this.mainAccountGroupBindingSource;
            this.mainAccountGroupGC.dbContext = null;
            this.mainAccountGroupGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainAccountGroupGC.Location = new System.Drawing.Point(0, 31);
            this.mainAccountGroupGC.MainView = this.mainAccountGroupGV;
            this.mainAccountGroupGC.MenuManager = this.barManager1;
            this.mainAccountGroupGC.Name = "mainAccountGroupGC";
            this.mainAccountGroupGC.Size = new System.Drawing.Size(766, 531);
            this.mainAccountGroupGC.TabIndex = 4;
            this.mainAccountGroupGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.mainAccountGroupGV});
            // 
            // mainAccountGroupGV
            // 
            this.mainAccountGroupGV.BaseTypeEnum = B_PowerWin.DB.BaseTypeEnum.MainAccountGroup;
            this.mainAccountGroupGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGroupNum,
            this.colGroupName,
            this.colMainAccountType,
            this.colMainAccounts,
            this.colLastErrorMessage,
            this.colId,
            this.colCreatedBy,
            this.colCreatedAt,
            this.colModifiedBy,
            this.colModifiedAt,
            this.colBaseType,
            this.colParnetId});
            this.mainAccountGroupGV.GridControl = this.mainAccountGroupGC;
            this.mainAccountGroupGV.GridViewEditMode = B_PowerWin.GUI.Grid.GridViewEditModeEnum.SimpleEdit;
            this.mainAccountGroupGV.Name = "mainAccountGroupGV";
            // 
            // colGroupNum
            // 
            this.colGroupNum.FieldName = "GroupNum";
            this.colGroupNum.Name = "colGroupNum";
            this.colGroupNum.Visible = true;
            this.colGroupNum.VisibleIndex = 0;
            // 
            // colGroupName
            // 
            this.colGroupName.FieldName = "GroupName";
            this.colGroupName.Name = "colGroupName";
            this.colGroupName.Visible = true;
            this.colGroupName.VisibleIndex = 1;
            // 
            // colMainAccountType
            // 
            this.colMainAccountType.FieldName = "MainAccountType";
            this.colMainAccountType.Name = "colMainAccountType";
            this.colMainAccountType.Visible = true;
            this.colMainAccountType.VisibleIndex = 2;
            // 
            // colMainAccounts
            // 
            this.colMainAccounts.FieldName = "MainAccounts";
            this.colMainAccounts.Name = "colMainAccounts";
            this.colMainAccounts.Visible = true;
            this.colMainAccounts.VisibleIndex = 3;
            // 
            // colLastErrorMessage
            // 
            this.colLastErrorMessage.FieldName = "LastErrorMessage";
            this.colLastErrorMessage.Name = "colLastErrorMessage";
            this.colLastErrorMessage.Visible = true;
            this.colLastErrorMessage.VisibleIndex = 4;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 5;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.FieldName = "CreatedBy";
            this.colCreatedBy.Name = "colCreatedBy";
            this.colCreatedBy.Visible = true;
            this.colCreatedBy.VisibleIndex = 6;
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.FieldName = "CreatedAt";
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.Visible = true;
            this.colCreatedAt.VisibleIndex = 7;
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
            // colBaseType
            // 
            this.colBaseType.FieldName = "BaseType";
            this.colBaseType.Name = "colBaseType";
            this.colBaseType.Visible = true;
            this.colBaseType.VisibleIndex = 10;
            // 
            // colParnetId
            // 
            this.colParnetId.FieldName = "ParnetId";
            this.colParnetId.Name = "colParnetId";
            this.colParnetId.Visible = true;
            this.colParnetId.VisibleIndex = 11;
            // 
            // saveLayoutBI
            // 
            this.saveLayoutBI.Caption = "SaveLayout";
            this.saveLayoutBI.Id = 2;
            this.saveLayoutBI.Name = "saveLayoutBI";
            // 
            // MainAccountGroupFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(766, 585);
            this.Controls.Add(this.mainAccountGroupGC);
            this.Name = "MainAccountGroupFrm";
            this.Controls.SetChildIndex(this.mainAccountGroupGC, 0);
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountGroupGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountGroupGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource mainAccountGroupBindingSource;
        private GUI.Grid.GridCtrlBase mainAccountGroupGC;
        private GUI.Grid.GridViewBase mainAccountGroupGV;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupNum;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupName;
        private DevExpress.XtraGrid.Columns.GridColumn colMainAccountType;
        private DevExpress.XtraGrid.Columns.GridColumn colMainAccounts;
        private DevExpress.XtraGrid.Columns.GridColumn colLastErrorMessage;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseType;
        private DevExpress.XtraGrid.Columns.GridColumn colParnetId;
        private DevExpress.XtraBars.BarButtonItem saveLayoutBI;
    }
}
