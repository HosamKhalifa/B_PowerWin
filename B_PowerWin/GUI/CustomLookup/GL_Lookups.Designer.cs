namespace B_PowerWin.GUI.CustomLookup
{
    partial class GL_Lookups
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MyLookupPR = new DevExpress.XtraEditors.Repository.PersistentRepository();
            this.mainAccount = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.mainAccountBS = new System.Windows.Forms.BindingSource();
            this.mainAccountSLookupGV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colReferenceNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMainAccountType = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountSLookupGV)).BeginInit();
            this.SuspendLayout();
            // 
            // MyLookupPR
            // 
            this.MyLookupPR.Items.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.mainAccount});
            // 
            // mainAccount
            // 
            this.mainAccount.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mainAccount.DataSource = this.mainAccountBS;
            this.mainAccount.DisplayMember = "ReferenceNum";
            this.mainAccount.KeyMember = "Id";
            this.mainAccount.Name = "mainAccount";
            this.mainAccount.ValueMember = "Id";
            this.mainAccount.View = this.mainAccountSLookupGV;
            // 
            // mainAccountBS
            // 
            this.mainAccountBS.DataSource = typeof(B_PowerWin.DB.MainAccount);
            // 
            // mainAccountSLookupGV
            // 
            this.mainAccountSLookupGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colReferenceNum,
            this.colName,
            this.colMainAccountType});
            this.mainAccountSLookupGV.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.mainAccountSLookupGV.Name = "mainAccountSLookupGV";
            this.mainAccountSLookupGV.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.mainAccountSLookupGV.OptionsView.ColumnAutoWidth = false;
            this.mainAccountSLookupGV.OptionsView.ShowAutoFilterRow = true;
            this.mainAccountSLookupGV.OptionsView.ShowGroupPanel = false;
            // 
            // colReferenceNum
            // 
            this.colReferenceNum.Caption = "Num";
            this.colReferenceNum.FieldName = "ReferenceNum";
            this.colReferenceNum.Name = "colReferenceNum";
            this.colReferenceNum.Visible = true;
            this.colReferenceNum.VisibleIndex = 0;
            this.colReferenceNum.Width = 92;
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 245;
            // 
            // colMainAccountType
            // 
            this.colMainAccountType.Caption = "Account type";
            this.colMainAccountType.FieldName = "MainAccountType";
            this.colMainAccountType.Name = "colMainAccountType";
            this.colMainAccountType.Visible = true;
            this.colMainAccountType.VisibleIndex = 2;
            this.colMainAccountType.Width = 111;
            // 
            // GL_Lookups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "GL_Lookups";
            this.Size = new System.Drawing.Size(622, 331);
            ((System.ComponentModel.ISupportInitialize)(this.mainAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountSLookupGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit mainAccount;
        private DevExpress.XtraGrid.Views.Grid.GridView mainAccountSLookupGV;
        private DevExpress.XtraGrid.Columns.GridColumn colReferenceNum;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colMainAccountType;
        public DevExpress.XtraEditors.Repository.PersistentRepository MyLookupPR;
        private System.Windows.Forms.BindingSource mainAccountBS;
    }
}
