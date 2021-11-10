namespace B_PowerWin.Sales.Forms
{
    partial class CustomerEditFrm
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
            this.CreditLimitTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DisplayNumTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ReferenceNumTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DescriptionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.GroupIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.SuspendedCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForGroupId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForReferenceNum = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDisplayNum = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCreditLimit = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSuspended = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreditLimitTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayNumTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReferenceNumTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuspendedCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGroupId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForReferenceNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDisplayNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCreditLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSuspended)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataLayoutControl1.Controls.Add(this.CreditLimitTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DisplayNumTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ReferenceNumTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DescriptionTextEdit);
            this.dataLayoutControl1.Controls.Add(this.GroupIdLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.SuspendedCheckEdit);
            this.dataLayoutControl1.DataSource = this.customerBindingSource;
            this.dataLayoutControl1.Location = new System.Drawing.Point(16, 43);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(546, 342, 250, 350);
            this.dataLayoutControl1.OptionsView.UseDefaultDragAndDropRendering = false;
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(725, 497);
            this.dataLayoutControl1.TabIndex = 4;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // CreditLimitTextEdit
            // 
            this.CreditLimitTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerBindingSource, "CreditLimit", true));
            this.CreditLimitTextEdit.Location = new System.Drawing.Point(441, 36);
            this.CreditLimitTextEdit.MenuManager = this.barManager1;
            this.CreditLimitTextEdit.Name = "CreditLimitTextEdit";
            this.CreditLimitTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.CreditLimitTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.CreditLimitTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.CreditLimitTextEdit.Properties.Mask.EditMask = "G";
            this.CreditLimitTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.CreditLimitTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.CreditLimitTextEdit.Size = new System.Drawing.Size(272, 20);
            this.CreditLimitTextEdit.StyleController = this.dataLayoutControl1;
            this.CreditLimitTextEdit.TabIndex = 4;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(B_PowerWin.DB.Customer);
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerBindingSource, "Name", true));
            this.NameTextEdit.Location = new System.Drawing.Point(441, 12);
            this.NameTextEdit.MenuManager = this.barManager1;
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.NameTextEdit.Size = new System.Drawing.Size(272, 20);
            this.NameTextEdit.StyleController = this.dataLayoutControl1;
            this.NameTextEdit.TabIndex = 5;
            // 
            // DisplayNumTextEdit
            // 
            this.DisplayNumTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerBindingSource, "DisplayNum", true));
            this.DisplayNumTextEdit.Location = new System.Drawing.Point(89, 36);
            this.DisplayNumTextEdit.MenuManager = this.barManager1;
            this.DisplayNumTextEdit.Name = "DisplayNumTextEdit";
            this.DisplayNumTextEdit.Size = new System.Drawing.Size(271, 20);
            this.DisplayNumTextEdit.StyleController = this.dataLayoutControl1;
            this.DisplayNumTextEdit.TabIndex = 6;
            // 
            // ReferenceNumTextEdit
            // 
            this.ReferenceNumTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerBindingSource, "ReferenceNum", true));
            this.ReferenceNumTextEdit.Location = new System.Drawing.Point(89, 12);
            this.ReferenceNumTextEdit.MenuManager = this.barManager1;
            this.ReferenceNumTextEdit.Name = "ReferenceNumTextEdit";
            this.ReferenceNumTextEdit.Size = new System.Drawing.Size(271, 20);
            this.ReferenceNumTextEdit.StyleController = this.dataLayoutControl1;
            this.ReferenceNumTextEdit.TabIndex = 7;
            // 
            // DescriptionTextEdit
            // 
            this.DescriptionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerBindingSource, "Description", true));
            this.DescriptionTextEdit.Location = new System.Drawing.Point(89, 60);
            this.DescriptionTextEdit.MenuManager = this.barManager1;
            this.DescriptionTextEdit.Name = "DescriptionTextEdit";
            this.DescriptionTextEdit.Size = new System.Drawing.Size(624, 20);
            this.DescriptionTextEdit.StyleController = this.dataLayoutControl1;
            this.DescriptionTextEdit.TabIndex = 8;
            // 
            // GroupIdLookUpEdit
            // 
            this.GroupIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerBindingSource, "GroupId", true));
            this.GroupIdLookUpEdit.Location = new System.Drawing.Point(89, 84);
            this.GroupIdLookUpEdit.MenuManager = this.barManager1;
            this.GroupIdLookUpEdit.Name = "GroupIdLookUpEdit";
            this.GroupIdLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.GroupIdLookUpEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.GroupIdLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.GroupIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GroupIdLookUpEdit.Properties.NullText = "";
            this.GroupIdLookUpEdit.Size = new System.Drawing.Size(271, 20);
            this.GroupIdLookUpEdit.StyleController = this.dataLayoutControl1;
            this.GroupIdLookUpEdit.TabIndex = 9;
            // 
            // SuspendedCheckEdit
            // 
            this.SuspendedCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerBindingSource, "Suspended", true));
            this.SuspendedCheckEdit.Location = new System.Drawing.Point(441, 84);
            this.SuspendedCheckEdit.MenuManager = this.barManager1;
            this.SuspendedCheckEdit.Name = "SuspendedCheckEdit";
            this.SuspendedCheckEdit.Properties.Caption = "Suspended";
            this.SuspendedCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SuspendedCheckEdit.Size = new System.Drawing.Size(272, 19);
            this.SuspendedCheckEdit.StyleController = this.dataLayoutControl1;
            this.SuspendedCheckEdit.TabIndex = 10;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(725, 497);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForDescription,
            this.ItemForGroupId,
            this.ItemForReferenceNum,
            this.ItemForName,
            this.ItemForDisplayNum,
            this.ItemForCreditLimit,
            this.ItemForSuspended});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(705, 477);
            // 
            // ItemForDescription
            // 
            this.ItemForDescription.Control = this.DescriptionTextEdit;
            this.ItemForDescription.Location = new System.Drawing.Point(0, 48);
            this.ItemForDescription.Name = "ItemForDescription";
            this.ItemForDescription.Size = new System.Drawing.Size(705, 24);
            this.ItemForDescription.Text = "Description";
            this.ItemForDescription.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForGroupId
            // 
            this.ItemForGroupId.Control = this.GroupIdLookUpEdit;
            this.ItemForGroupId.Location = new System.Drawing.Point(0, 72);
            this.ItemForGroupId.Name = "ItemForGroupId";
            this.ItemForGroupId.Size = new System.Drawing.Size(352, 405);
            this.ItemForGroupId.Text = "Group Id";
            this.ItemForGroupId.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForReferenceNum
            // 
            this.ItemForReferenceNum.Control = this.ReferenceNumTextEdit;
            this.ItemForReferenceNum.Location = new System.Drawing.Point(0, 0);
            this.ItemForReferenceNum.Name = "ItemForReferenceNum";
            this.ItemForReferenceNum.Size = new System.Drawing.Size(352, 24);
            this.ItemForReferenceNum.Text = "Reference Num";
            this.ItemForReferenceNum.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForName
            // 
            this.ItemForName.Control = this.NameTextEdit;
            this.ItemForName.Location = new System.Drawing.Point(352, 0);
            this.ItemForName.Name = "ItemForName";
            this.ItemForName.Size = new System.Drawing.Size(353, 24);
            this.ItemForName.Text = "Name";
            this.ItemForName.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForDisplayNum
            // 
            this.ItemForDisplayNum.Control = this.DisplayNumTextEdit;
            this.ItemForDisplayNum.Location = new System.Drawing.Point(0, 24);
            this.ItemForDisplayNum.Name = "ItemForDisplayNum";
            this.ItemForDisplayNum.Size = new System.Drawing.Size(352, 24);
            this.ItemForDisplayNum.Text = "Display Num";
            this.ItemForDisplayNum.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForCreditLimit
            // 
            this.ItemForCreditLimit.Control = this.CreditLimitTextEdit;
            this.ItemForCreditLimit.Location = new System.Drawing.Point(352, 24);
            this.ItemForCreditLimit.Name = "ItemForCreditLimit";
            this.ItemForCreditLimit.Size = new System.Drawing.Size(353, 24);
            this.ItemForCreditLimit.Text = "Credit Limit";
            this.ItemForCreditLimit.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForSuspended
            // 
            this.ItemForSuspended.Control = this.SuspendedCheckEdit;
            this.ItemForSuspended.Location = new System.Drawing.Point(352, 72);
            this.ItemForSuspended.Name = "ItemForSuspended";
            this.ItemForSuspended.Size = new System.Drawing.Size(353, 405);
            this.ItemForSuspended.Text = "Suspended";
            this.ItemForSuspended.TextSize = new System.Drawing.Size(74, 13);
            // 
            // CustomerEditFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(766, 585);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "CustomerEditFrm";
            this.Controls.SetChildIndex(this.dataLayoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CreditLimitTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayNumTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReferenceNumTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuspendedCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGroupId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForReferenceNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDisplayNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCreditLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSuspended)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit CreditLimitTextEdit;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private DevExpress.XtraEditors.TextEdit DisplayNumTextEdit;
        private DevExpress.XtraEditors.TextEdit ReferenceNumTextEdit;
        private DevExpress.XtraEditors.TextEdit DescriptionTextEdit;
        private DevExpress.XtraEditors.LookUpEdit GroupIdLookUpEdit;
        private DevExpress.XtraEditors.CheckEdit SuspendedCheckEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDescription;
        private DevExpress.XtraLayout.LayoutControlItem ItemForGroupId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForReferenceNum;
        private DevExpress.XtraLayout.LayoutControlItem ItemForName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDisplayNum;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCreditLimit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSuspended;
    }
}
