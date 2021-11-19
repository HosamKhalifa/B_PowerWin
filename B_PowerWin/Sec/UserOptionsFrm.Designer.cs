namespace B_PowerWin.Sec
{
    partial class UserOptionsFrm
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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.UserKeyTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.secPrincipalUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmplIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.UserImagePictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.DefaultCompanyLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.LangIdComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.PrincipalFullNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.UseMdiTabbedManagerRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForUserKey = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmplId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUserImage = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDefaultCompany = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLangId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPrincipalFullName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUseMdiTabbedManager = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserKeyTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secPrincipalUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmplIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserImagePictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultCompanyLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LangIdComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrincipalFullNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UseMdiTabbedManagerRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUserKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmplId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUserImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDefaultCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLangId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPrincipalFullName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUseMdiTabbedManager)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataLayoutControl1.Controls.Add(this.UserKeyTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EmplIdLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.UserImagePictureEdit);
            this.dataLayoutControl1.Controls.Add(this.DefaultCompanyLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.LangIdComboBoxEdit);
            this.dataLayoutControl1.Controls.Add(this.PrincipalFullNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.UseMdiTabbedManagerRadioGroup);
            this.dataLayoutControl1.DataSource = this.secPrincipalUserBindingSource;
            this.dataLayoutControl1.Location = new System.Drawing.Point(8, 40);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsView.UseDefaultDragAndDropRendering = false;
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(742, 386);
            this.dataLayoutControl1.TabIndex = 4;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // UserKeyTextEdit
            // 
            this.UserKeyTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.secPrincipalUserBindingSource, "UserKey", true));
            this.UserKeyTextEdit.Location = new System.Drawing.Point(136, 12);
            this.UserKeyTextEdit.MenuManager = this.barManager1;
            this.UserKeyTextEdit.Name = "UserKeyTextEdit";
            this.UserKeyTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.UserKeyTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.UserKeyTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.UserKeyTextEdit.Properties.Mask.EditMask = "N0";
            this.UserKeyTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.UserKeyTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.UserKeyTextEdit.Size = new System.Drawing.Size(233, 20);
            this.UserKeyTextEdit.StyleController = this.dataLayoutControl1;
            this.UserKeyTextEdit.TabIndex = 4;
            // 
            // secPrincipalUserBindingSource
            // 
            this.secPrincipalUserBindingSource.DataSource = typeof(B_PowerWin.DB.SecPrincipalUser);
            // 
            // EmplIdLookUpEdit
            // 
            this.EmplIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.secPrincipalUserBindingSource, "EmplId", true));
            this.EmplIdLookUpEdit.Location = new System.Drawing.Point(497, 12);
            this.EmplIdLookUpEdit.MenuManager = this.barManager1;
            this.EmplIdLookUpEdit.Name = "EmplIdLookUpEdit";
            this.EmplIdLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.EmplIdLookUpEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.EmplIdLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.EmplIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EmplIdLookUpEdit.Properties.NullText = "";
            this.EmplIdLookUpEdit.Size = new System.Drawing.Size(233, 20);
            this.EmplIdLookUpEdit.StyleController = this.dataLayoutControl1;
            this.EmplIdLookUpEdit.TabIndex = 5;
            // 
            // UserImagePictureEdit
            // 
            this.UserImagePictureEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.UserImagePictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.secPrincipalUserBindingSource, "UserImage", true));
            this.UserImagePictureEdit.Location = new System.Drawing.Point(136, 36);
            this.UserImagePictureEdit.MenuManager = this.barManager1;
            this.UserImagePictureEdit.Name = "UserImagePictureEdit";
            this.UserImagePictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.UserImagePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.UserImagePictureEdit.Properties.ZoomAccelerationFactor = 1D;
            this.UserImagePictureEdit.Size = new System.Drawing.Size(594, 263);
            this.UserImagePictureEdit.StyleController = this.dataLayoutControl1;
            this.UserImagePictureEdit.TabIndex = 7;
            // 
            // DefaultCompanyLookUpEdit
            // 
            this.DefaultCompanyLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.secPrincipalUserBindingSource, "DefaultCompany", true));
            this.DefaultCompanyLookUpEdit.Location = new System.Drawing.Point(136, 303);
            this.DefaultCompanyLookUpEdit.MenuManager = this.barManager1;
            this.DefaultCompanyLookUpEdit.Name = "DefaultCompanyLookUpEdit";
            this.DefaultCompanyLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.DefaultCompanyLookUpEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.DefaultCompanyLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DefaultCompanyLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DefaultCompanyLookUpEdit.Properties.NullText = "";
            this.DefaultCompanyLookUpEdit.Size = new System.Drawing.Size(233, 20);
            this.DefaultCompanyLookUpEdit.StyleController = this.dataLayoutControl1;
            this.DefaultCompanyLookUpEdit.TabIndex = 8;
            // 
            // LangIdComboBoxEdit
            // 
            this.LangIdComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.secPrincipalUserBindingSource, "LangId", true));
            this.LangIdComboBoxEdit.Location = new System.Drawing.Point(497, 303);
            this.LangIdComboBoxEdit.MenuManager = this.barManager1;
            this.LangIdComboBoxEdit.Name = "LangIdComboBoxEdit";
            this.LangIdComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LangIdComboBoxEdit.Size = new System.Drawing.Size(233, 20);
            this.LangIdComboBoxEdit.StyleController = this.dataLayoutControl1;
            this.LangIdComboBoxEdit.TabIndex = 9;
            // 
            // PrincipalFullNameTextEdit
            // 
            this.PrincipalFullNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.secPrincipalUserBindingSource, "PrincipalFullName", true));
            this.PrincipalFullNameTextEdit.Location = new System.Drawing.Point(136, 327);
            this.PrincipalFullNameTextEdit.MenuManager = this.barManager1;
            this.PrincipalFullNameTextEdit.Name = "PrincipalFullNameTextEdit";
            this.PrincipalFullNameTextEdit.Properties.ReadOnly = true;
            this.PrincipalFullNameTextEdit.Size = new System.Drawing.Size(594, 20);
            this.PrincipalFullNameTextEdit.StyleController = this.dataLayoutControl1;
            this.PrincipalFullNameTextEdit.TabIndex = 10;
            // 
            // UseMdiTabbedManagerRadioGroup
            // 
            this.UseMdiTabbedManagerRadioGroup.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.secPrincipalUserBindingSource, "UseMdiTabbedManager", true));
            this.UseMdiTabbedManagerRadioGroup.Location = new System.Drawing.Point(136, 351);
            this.UseMdiTabbedManagerRadioGroup.MenuManager = this.barManager1;
            this.UseMdiTabbedManagerRadioGroup.Name = "UseMdiTabbedManagerRadioGroup";
            this.UseMdiTabbedManagerRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.UseMdiTabbedManagerRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Tabbed window"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "MDI window")});
            this.UseMdiTabbedManagerRadioGroup.Size = new System.Drawing.Size(594, 23);
            this.UseMdiTabbedManagerRadioGroup.StyleController = this.dataLayoutControl1;
            this.UseMdiTabbedManagerRadioGroup.TabIndex = 11;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(742, 386);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForUserKey,
            this.ItemForEmplId,
            this.ItemForUserImage,
            this.ItemForDefaultCompany,
            this.ItemForLangId,
            this.ItemForPrincipalFullName,
            this.ItemForUseMdiTabbedManager});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(722, 366);
            // 
            // ItemForUserKey
            // 
            this.ItemForUserKey.Control = this.UserKeyTextEdit;
            this.ItemForUserKey.Location = new System.Drawing.Point(0, 0);
            this.ItemForUserKey.Name = "ItemForUserKey";
            this.ItemForUserKey.Size = new System.Drawing.Size(361, 24);
            this.ItemForUserKey.Text = "User Key";
            this.ItemForUserKey.TextSize = new System.Drawing.Size(121, 13);
            // 
            // ItemForEmplId
            // 
            this.ItemForEmplId.Control = this.EmplIdLookUpEdit;
            this.ItemForEmplId.Location = new System.Drawing.Point(361, 0);
            this.ItemForEmplId.Name = "ItemForEmplId";
            this.ItemForEmplId.Size = new System.Drawing.Size(361, 24);
            this.ItemForEmplId.Text = "Empl Id";
            this.ItemForEmplId.TextSize = new System.Drawing.Size(121, 13);
            // 
            // ItemForUserImage
            // 
            this.ItemForUserImage.Control = this.UserImagePictureEdit;
            this.ItemForUserImage.Location = new System.Drawing.Point(0, 24);
            this.ItemForUserImage.Name = "ItemForUserImage";
            this.ItemForUserImage.Size = new System.Drawing.Size(722, 267);
            this.ItemForUserImage.StartNewLine = true;
            this.ItemForUserImage.Text = "User Image";
            this.ItemForUserImage.TextSize = new System.Drawing.Size(121, 13);
            // 
            // ItemForDefaultCompany
            // 
            this.ItemForDefaultCompany.Control = this.DefaultCompanyLookUpEdit;
            this.ItemForDefaultCompany.Location = new System.Drawing.Point(0, 291);
            this.ItemForDefaultCompany.Name = "ItemForDefaultCompany";
            this.ItemForDefaultCompany.Size = new System.Drawing.Size(361, 24);
            this.ItemForDefaultCompany.Text = "Default Company";
            this.ItemForDefaultCompany.TextSize = new System.Drawing.Size(121, 13);
            // 
            // ItemForLangId
            // 
            this.ItemForLangId.Control = this.LangIdComboBoxEdit;
            this.ItemForLangId.Location = new System.Drawing.Point(361, 291);
            this.ItemForLangId.Name = "ItemForLangId";
            this.ItemForLangId.Size = new System.Drawing.Size(361, 24);
            this.ItemForLangId.Text = "Lang Id";
            this.ItemForLangId.TextSize = new System.Drawing.Size(121, 13);
            // 
            // ItemForPrincipalFullName
            // 
            this.ItemForPrincipalFullName.Control = this.PrincipalFullNameTextEdit;
            this.ItemForPrincipalFullName.Location = new System.Drawing.Point(0, 315);
            this.ItemForPrincipalFullName.Name = "ItemForPrincipalFullName";
            this.ItemForPrincipalFullName.Size = new System.Drawing.Size(722, 24);
            this.ItemForPrincipalFullName.Text = "Principal Full Name";
            this.ItemForPrincipalFullName.TextSize = new System.Drawing.Size(121, 13);
            // 
            // ItemForUseMdiTabbedManager
            // 
            this.ItemForUseMdiTabbedManager.Control = this.UseMdiTabbedManagerRadioGroup;
            this.ItemForUseMdiTabbedManager.Location = new System.Drawing.Point(0, 339);
            this.ItemForUseMdiTabbedManager.Name = "ItemForUseMdiTabbedManager";
            this.ItemForUseMdiTabbedManager.Size = new System.Drawing.Size(722, 27);
            this.ItemForUseMdiTabbedManager.StartNewLine = true;
            this.ItemForUseMdiTabbedManager.Text = "Use Mdi Tabbed Manager";
            this.ItemForUseMdiTabbedManager.TextSize = new System.Drawing.Size(121, 13);
            // 
            // UserOptionsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(766, 585);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "UserOptionsFrm";
            this.Text = "User options";
            this.Controls.SetChildIndex(this.dataLayoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserKeyTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secPrincipalUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmplIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserImagePictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultCompanyLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LangIdComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrincipalFullNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UseMdiTabbedManagerRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUserKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmplId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUserImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDefaultCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLangId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPrincipalFullName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUseMdiTabbedManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit UserKeyTextEdit;
        private System.Windows.Forms.BindingSource secPrincipalUserBindingSource;
        private DevExpress.XtraEditors.LookUpEdit EmplIdLookUpEdit;
        private DevExpress.XtraEditors.PictureEdit UserImagePictureEdit;
        private DevExpress.XtraEditors.LookUpEdit DefaultCompanyLookUpEdit;
        private DevExpress.XtraEditors.ComboBoxEdit LangIdComboBoxEdit;
        private DevExpress.XtraEditors.TextEdit PrincipalFullNameTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUserKey;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmplId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUserImage;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDefaultCompany;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLangId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPrincipalFullName;
        private DevExpress.XtraEditors.RadioGroup UseMdiTabbedManagerRadioGroup;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUseMdiTabbedManager;
    }
}
