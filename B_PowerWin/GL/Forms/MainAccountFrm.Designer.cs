namespace B_PowerWin.GL.Forms
{
    partial class MainAccountFrm
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
            this.mainAccountGC = new B_PowerWin.GUI.Grid.GridCtrlBase();
            this.mainAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainAccountGV = new B_PowerWin.GUI.Grid.GridViewBase();
            this.colMainAccountType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMainAccountGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisplayNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferenceNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisplayNumSequ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMainAccountSetManually = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMainAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuspended = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParnetId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountGV)).BeginInit();
            this.SuspendLayout();
            // 
            // mainAccountGC
            // 
            this.mainAccountGC.DataSource = this.mainAccountBindingSource;
            this.mainAccountGC.dbContext = null;
            this.mainAccountGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainAccountGC.Location = new System.Drawing.Point(0, 31);
            this.mainAccountGC.MainView = this.mainAccountGV;
            this.mainAccountGC.MenuManager = this.barManager1;
            this.mainAccountGC.Name = "mainAccountGC";
            this.mainAccountGC.Size = new System.Drawing.Size(766, 531);
            this.mainAccountGC.TabIndex = 4;
            this.mainAccountGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.mainAccountGV});
            // 
            // mainAccountBindingSource
            // 
            this.mainAccountBindingSource.DataSource = typeof(B_PowerWin.DB.MainAccount);
            // 
            // mainAccountGV
            // 
            this.mainAccountGV.BaseTypeEnum = B_PowerWin.DB.BaseTypeEnum.MainAccount;
            this.mainAccountGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMainAccountType,
            this.colIsTotal,
            this.colMainAccountGroup,
            this.colName,
            this.colDisplayNum,
            this.colReferenceNum,
            this.colDescription,
            this.colGroupId,
            this.colDisplayNumSequ,
            this.colMainAccountSetManually,
            this.colMainAccount,
            this.colSuspended,
            this.colId,
            this.colCreatedBy,
            this.colCreatedAt,
            this.colModifiedBy,
            this.colParnetId,
            this.colModifiedAt});
            this.mainAccountGV.GridControl = this.mainAccountGC;
            this.mainAccountGV.GridViewEditMode = B_PowerWin.GUI.Grid.GridViewEditModeEnum.FormEdit;
            this.mainAccountGV.Name = "mainAccountGV";
            // 
            // colMainAccountType
            // 
            this.colMainAccountType.FieldName = "MainAccountType";
            this.colMainAccountType.Name = "colMainAccountType";
            this.colMainAccountType.Visible = true;
            this.colMainAccountType.VisibleIndex = 0;
            // 
            // colIsTotal
            // 
            this.colIsTotal.FieldName = "IsTotal";
            this.colIsTotal.Name = "colIsTotal";
            this.colIsTotal.Visible = true;
            this.colIsTotal.VisibleIndex = 1;
            // 
            // colMainAccountGroup
            // 
            this.colMainAccountGroup.FieldName = "MainAccountGroup";
            this.colMainAccountGroup.Name = "colMainAccountGroup";
            this.colMainAccountGroup.Visible = true;
            this.colMainAccountGroup.VisibleIndex = 2;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 3;
            // 
            // colDisplayNum
            // 
            this.colDisplayNum.FieldName = "DisplayNum";
            this.colDisplayNum.Name = "colDisplayNum";
            this.colDisplayNum.Visible = true;
            this.colDisplayNum.VisibleIndex = 4;
            // 
            // colReferenceNum
            // 
            this.colReferenceNum.FieldName = "ReferenceNum";
            this.colReferenceNum.Name = "colReferenceNum";
            this.colReferenceNum.Visible = true;
            this.colReferenceNum.VisibleIndex = 5;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 6;
            // 
            // colGroupId
            // 
            this.colGroupId.FieldName = "GroupId";
            this.colGroupId.Name = "colGroupId";
            // 
            // colDisplayNumSequ
            // 
            this.colDisplayNumSequ.FieldName = "DisplayNumSequ";
            this.colDisplayNumSequ.Name = "colDisplayNumSequ";
            this.colDisplayNumSequ.Visible = true;
            this.colDisplayNumSequ.VisibleIndex = 7;
            // 
            // colMainAccountSetManually
            // 
            this.colMainAccountSetManually.FieldName = "MainAccountSetManually";
            this.colMainAccountSetManually.Name = "colMainAccountSetManually";
            this.colMainAccountSetManually.Visible = true;
            this.colMainAccountSetManually.VisibleIndex = 8;
            // 
            // colMainAccount
            // 
            this.colMainAccount.FieldName = "MainAccount";
            this.colMainAccount.Name = "colMainAccount";
            this.colMainAccount.Visible = true;
            this.colMainAccount.VisibleIndex = 9;
            // 
            // colSuspended
            // 
            this.colSuspended.FieldName = "Suspended";
            this.colSuspended.Name = "colSuspended";
            this.colSuspended.Visible = true;
            this.colSuspended.VisibleIndex = 10;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 11;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.FieldName = "CreatedBy";
            this.colCreatedBy.Name = "colCreatedBy";
            this.colCreatedBy.Visible = true;
            this.colCreatedBy.VisibleIndex = 12;
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.FieldName = "CreatedAt";
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.Visible = true;
            this.colCreatedAt.VisibleIndex = 13;
            // 
            // colModifiedBy
            // 
            this.colModifiedBy.FieldName = "ModifiedBy";
            this.colModifiedBy.Name = "colModifiedBy";
            this.colModifiedBy.Visible = true;
            this.colModifiedBy.VisibleIndex = 14;
            // 
            // colParnetId
            // 
            this.colParnetId.FieldName = "ParnetId";
            this.colParnetId.Name = "colParnetId";
            this.colParnetId.Visible = true;
            this.colParnetId.VisibleIndex = 16;
            // 
            // colModifiedAt
            // 
            this.colModifiedAt.FieldName = "ModifiedAt";
            this.colModifiedAt.Name = "colModifiedAt";
            this.colModifiedAt.Visible = true;
            this.colModifiedAt.VisibleIndex = 15;
            // 
            // MainAccountFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(766, 585);
            this.Controls.Add(this.mainAccountGC);
            this.Name = "MainAccountFrm";
            this.Controls.SetChildIndex(this.mainAccountGC, 0);
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GUI.Grid.GridCtrlBase mainAccountGC;
        private GUI.Grid.GridViewBase mainAccountGV;
        private System.Windows.Forms.BindingSource mainAccountBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMainAccountType;
        private DevExpress.XtraGrid.Columns.GridColumn colIsTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colMainAccountGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDisplayNum;
        private DevExpress.XtraGrid.Columns.GridColumn colReferenceNum;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupId;
        private DevExpress.XtraGrid.Columns.GridColumn colDisplayNumSequ;
        private DevExpress.XtraGrid.Columns.GridColumn colMainAccountSetManually;
        private DevExpress.XtraGrid.Columns.GridColumn colMainAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colSuspended;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colParnetId;
    }
}
