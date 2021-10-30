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
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GL_Lookups));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.MyLookupPR = new DevExpress.XtraEditors.Repository.PersistentRepository(this.components);
            this.mainAccount = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.mainAccountBS = new System.Windows.Forms.BindingSource(this.components);
            this.mainAccountSLookupGV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colReferenceNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMainAccountType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mainAccountGroupLookup = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.mainAccountGroupBS = new System.Windows.Forms.BindingSource(this.components);
            this.sequLookup = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.sequBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountSLookupGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountGroupLookup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountGroupBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequLookup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MyLookupPR
            // 
            this.MyLookupPR.Items.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.mainAccount,
            this.mainAccountGroupLookup,
            this.sequLookup});
            // 
            // mainAccount
            // 
            this.mainAccount.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
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
            // mainAccountGroupLookup
            // 
            this.mainAccountGroupLookup.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Edit...", -1, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("mainAccountGroupLookup.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.mainAccountGroupLookup.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GroupNum", "Group Num", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GroupName", "Group Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MainAccountType", "Main Account Type", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
            this.mainAccountGroupLookup.DataSource = this.mainAccountGroupBS;
            this.mainAccountGroupLookup.DisplayMember = "GroupName";
            this.mainAccountGroupLookup.Name = "mainAccountGroupLookup";
            this.mainAccountGroupLookup.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.mainAccountGroupLookup.ValueMember = "Id";
            this.mainAccountGroupLookup.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.mainAccountGroupLookup_ButtonClick);
            // 
            // mainAccountGroupBS
            // 
            this.mainAccountGroupBS.DataSource = typeof(B_PowerWin.DB.MainAccountGroup);
            // 
            // sequLookup
            // 
            this.sequLookup.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Go to table", -1, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F9), serializableAppearanceObject3, "Go to table", null, null, true)});
            this.sequLookup.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SequNum", "Sequ Num", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SequName", "Sequ Name", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SysSequRecycle", "Sys Sequ Recycle", 10, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
            this.sequLookup.DataSource = this.sequBindingSource;
            this.sequLookup.DisplayMember = "DisplayTitle";
            this.sequLookup.KeyMember = "Id";
            this.sequLookup.Name = "sequLookup";
            this.sequLookup.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.sequLookup.ValueMember = "Id";
            // 
            // sequBindingSource
            // 
            this.sequBindingSource.DataSource = typeof(B_PowerWin.DB.SysSequence);
            // 
            // GL_Lookups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "GL_Lookups";
            this.Size = new System.Drawing.Size(752, 513);
            ((System.ComponentModel.ISupportInitialize)(this.mainAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountSLookupGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountGroupLookup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountGroupBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequLookup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequBindingSource)).EndInit();
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
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit mainAccountGroupLookup;
        private System.Windows.Forms.BindingSource mainAccountGroupBS;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit sequLookup;
        private System.Windows.Forms.BindingSource sequBindingSource;
    }
}
