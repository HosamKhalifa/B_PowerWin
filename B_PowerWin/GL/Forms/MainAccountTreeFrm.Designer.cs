namespace B_PowerWin.GL.Forms
{
    partial class MainAccountTreeFrm
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
            this.accountTotalsLookupBS = new System.Windows.Forms.BindingSource(this.components);
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colReferenceNum = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colMainAccountType = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDescription = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colParnetId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.mainAccountTotalsLookup = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCreatedBy = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCreatedAt = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colModifiedBy = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colModifiedAt = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.accountTotalsLookupBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountTotalsLookup)).BeginInit();
            this.SuspendLayout();
            // 
            // accountTotalsLookupBS
            // 
            this.accountTotalsLookupBS.DataSource = typeof(B_PowerWin.DB.MainAccount);
            this.accountTotalsLookupBS.Filter = "";
            // 
            // treeList1
            // 
            this.treeList1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colReferenceNum,
            this.colName,
            this.colMainAccountType,
            this.colDescription,
            this.colParnetId,
            this.colId,
            this.colCreatedBy,
            this.colCreatedAt,
            this.colModifiedBy,
            this.colModifiedAt});
            this.treeList1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeList1.DataSource = this.accountTotalsLookupBS;
            this.treeList1.KeyFieldName = "Id";
            this.treeList1.Location = new System.Drawing.Point(12, 37);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.PopulateServiceColumns = true;
            this.treeList1.OptionsFilter.ShowAllValuesInFilterPopup = true;
            this.treeList1.OptionsView.EnableAppearanceEvenRow = true;
            this.treeList1.OptionsView.ShowAutoFilterRow = true;
            this.treeList1.OptionsView.ShowHorzLines = false;
            this.treeList1.ParentFieldName = "ParnetId";
            this.treeList1.PreviewFieldName = "FullName";
            this.treeList1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.mainAccountTotalsLookup});
            this.treeList1.Size = new System.Drawing.Size(846, 321);
            this.treeList1.TabIndex = 0;
            // 
            // colReferenceNum
            // 
            this.colReferenceNum.FieldName = "ReferenceNum";
            this.colReferenceNum.Name = "colReferenceNum";
            this.colReferenceNum.Visible = true;
            this.colReferenceNum.VisibleIndex = 0;
            this.colReferenceNum.Width = 106;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 243;
            // 
            // colMainAccountType
            // 
            this.colMainAccountType.FieldName = "MainAccountType";
            this.colMainAccountType.Name = "colMainAccountType";
            this.colMainAccountType.Visible = true;
            this.colMainAccountType.VisibleIndex = 2;
            this.colMainAccountType.Width = 110;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 4;
            this.colDescription.Width = 304;
            // 
            // colParnetId
            // 
            this.colParnetId.ColumnEdit = this.mainAccountTotalsLookup;
            this.colParnetId.FieldName = "ParnetId";
            this.colParnetId.Name = "colParnetId";
            this.colParnetId.Visible = true;
            this.colParnetId.VisibleIndex = 3;
            this.colParnetId.Width = 304;
            // 
            // mainAccountTotalsLookup
            // 
            this.mainAccountTotalsLookup.AutoHeight = false;
            this.mainAccountTotalsLookup.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mainAccountTotalsLookup.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ReferenceNum", "Reference Num"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 70, "Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MainAccountType", 10, "Type")});
            this.mainAccountTotalsLookup.DataSource = this.accountTotalsLookupBS;
            this.mainAccountTotalsLookup.DisplayMember = "FullName";
            this.mainAccountTotalsLookup.KeyMember = "Id";
            this.mainAccountTotalsLookup.Name = "mainAccountTotalsLookup";
            this.mainAccountTotalsLookup.ValueMember = "Id";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Width = 20;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.FieldName = "CreatedBy";
            this.colCreatedBy.Name = "colCreatedBy";
            this.colCreatedBy.Width = 20;
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.FieldName = "CreatedAt";
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.Width = 20;
            // 
            // colModifiedBy
            // 
            this.colModifiedBy.FieldName = "ModifiedBy";
            this.colModifiedBy.Name = "colModifiedBy";
            this.colModifiedBy.Width = 20;
            // 
            // colModifiedAt
            // 
            this.colModifiedAt.FieldName = "ModifiedAt";
            this.colModifiedAt.Name = "colModifiedAt";
            this.colModifiedAt.Width = 20;
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataNavigator1.DataSource = this.accountTotalsLookupBS;
            this.dataNavigator1.Location = new System.Drawing.Point(12, 357);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(331, 24);
            this.dataNavigator1.TabIndex = 4;
            this.dataNavigator1.Text = "dataNavigator1";
            // 
            // MainAccountTreeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(870, 410);
            this.Controls.Add(this.dataNavigator1);
            this.Controls.Add(this.treeList1);
            this.Name = "MainAccountTreeFrm";
            this.Text = "Main account";
            this.Controls.SetChildIndex(this.treeList1, 0);
            this.Controls.SetChildIndex(this.dataNavigator1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.accountTotalsLookupBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountTotalsLookup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colReferenceNum;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMainAccountType;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDescription;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colParnetId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCreatedBy;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCreatedAt;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colModifiedBy;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colModifiedAt;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit mainAccountTotalsLookup;
        private System.Windows.Forms.BindingSource accountTotalsLookupBS;
        private DevExpress.XtraEditors.DataNavigator dataNavigator1;
    }
}
