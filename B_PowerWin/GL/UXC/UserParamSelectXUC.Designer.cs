namespace B_PowerWin.GL.UXC
{
    partial class UserParamSelectXUC
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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.StartDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ItemForStartDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.EndDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ItemForEndDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.CustomerListExpPopupContainerEdit = new DevExpress.XtraEditors.PopupContainerEdit();
            this.ItemForCustomerListExp = new DevExpress.XtraLayout.LayoutControlItem();
            this.VendorListExpPopupContainerEdit = new DevExpress.XtraEditors.PopupContainerEdit();
            this.ItemForVendorListExp = new DevExpress.XtraLayout.LayoutControlItem();
            this.StoreListExpPopupContainerEdit = new DevExpress.XtraEditors.PopupContainerEdit();
            this.ItemForStoreListExp = new DevExpress.XtraLayout.LayoutControlItem();
            this.SiteListExpPopupContainerEdit = new DevExpress.XtraEditors.PopupContainerEdit();
            this.ItemForSiteListExp = new DevExpress.XtraLayout.LayoutControlItem();
            this.userParameterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerListExpPopupContainerEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomerListExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendorListExpPopupContainerEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVendorListExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreListExpPopupContainerEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStoreListExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SiteListExpPopupContainerEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSiteListExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userParameterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataLayoutControl1.Controls.Add(this.StartDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.EndDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.CustomerListExpPopupContainerEdit);
            this.dataLayoutControl1.Controls.Add(this.VendorListExpPopupContainerEdit);
            this.dataLayoutControl1.Controls.Add(this.StoreListExpPopupContainerEdit);
            this.dataLayoutControl1.Controls.Add(this.SiteListExpPopupContainerEdit);
            this.dataLayoutControl1.DataSource = this.userParameterBindingSource;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsView.UseDefaultDragAndDropRendering = false;
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(681, 264);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(681, 264);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForStartDate,
            this.ItemForEndDate,
            this.ItemForCustomerListExp,
            this.ItemForVendorListExp,
            this.ItemForStoreListExp,
            this.ItemForSiteListExp});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(661, 244);
            // 
            // StartDateDateEdit
            // 
            this.StartDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userParameterBindingSource, "StartDate", true));
            this.StartDateDateEdit.EditValue = null;
            this.StartDateDateEdit.Location = new System.Drawing.Point(102, 12);
            this.StartDateDateEdit.Name = "StartDateDateEdit";
            this.StartDateDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.StartDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StartDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StartDateDateEdit.Size = new System.Drawing.Size(236, 20);
            this.StartDateDateEdit.StyleController = this.dataLayoutControl1;
            this.StartDateDateEdit.TabIndex = 4;
            // 
            // ItemForStartDate
            // 
            this.ItemForStartDate.Control = this.StartDateDateEdit;
            this.ItemForStartDate.Location = new System.Drawing.Point(0, 0);
            this.ItemForStartDate.Name = "ItemForStartDate";
            this.ItemForStartDate.Size = new System.Drawing.Size(330, 24);
            this.ItemForStartDate.Text = "Start Date";
            this.ItemForStartDate.TextSize = new System.Drawing.Size(86, 13);
            // 
            // EndDateDateEdit
            // 
            this.EndDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userParameterBindingSource, "EndDate", true));
            this.EndDateDateEdit.EditValue = null;
            this.EndDateDateEdit.Location = new System.Drawing.Point(432, 12);
            this.EndDateDateEdit.Name = "EndDateDateEdit";
            this.EndDateDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.EndDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EndDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EndDateDateEdit.Size = new System.Drawing.Size(237, 20);
            this.EndDateDateEdit.StyleController = this.dataLayoutControl1;
            this.EndDateDateEdit.TabIndex = 5;
            // 
            // ItemForEndDate
            // 
            this.ItemForEndDate.Control = this.EndDateDateEdit;
            this.ItemForEndDate.Location = new System.Drawing.Point(330, 0);
            this.ItemForEndDate.Name = "ItemForEndDate";
            this.ItemForEndDate.Size = new System.Drawing.Size(331, 24);
            this.ItemForEndDate.Text = "End Date";
            this.ItemForEndDate.TextSize = new System.Drawing.Size(86, 13);
            // 
            // CustomerListExpPopupContainerEdit
            // 
            this.CustomerListExpPopupContainerEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userParameterBindingSource, "CustomerListExp", true));
            this.CustomerListExpPopupContainerEdit.Location = new System.Drawing.Point(102, 36);
            this.CustomerListExpPopupContainerEdit.Name = "CustomerListExpPopupContainerEdit";
            this.CustomerListExpPopupContainerEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CustomerListExpPopupContainerEdit.Size = new System.Drawing.Size(236, 20);
            this.CustomerListExpPopupContainerEdit.StyleController = this.dataLayoutControl1;
            this.CustomerListExpPopupContainerEdit.TabIndex = 6;
            // 
            // ItemForCustomerListExp
            // 
            this.ItemForCustomerListExp.Control = this.CustomerListExpPopupContainerEdit;
            this.ItemForCustomerListExp.Location = new System.Drawing.Point(0, 24);
            this.ItemForCustomerListExp.Name = "ItemForCustomerListExp";
            this.ItemForCustomerListExp.Size = new System.Drawing.Size(330, 24);
            this.ItemForCustomerListExp.Text = "Customer List Exp";
            this.ItemForCustomerListExp.TextSize = new System.Drawing.Size(86, 13);
            // 
            // VendorListExpPopupContainerEdit
            // 
            this.VendorListExpPopupContainerEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userParameterBindingSource, "VendorListExp", true));
            this.VendorListExpPopupContainerEdit.Location = new System.Drawing.Point(432, 36);
            this.VendorListExpPopupContainerEdit.Name = "VendorListExpPopupContainerEdit";
            this.VendorListExpPopupContainerEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.VendorListExpPopupContainerEdit.Size = new System.Drawing.Size(237, 20);
            this.VendorListExpPopupContainerEdit.StyleController = this.dataLayoutControl1;
            this.VendorListExpPopupContainerEdit.TabIndex = 7;
            // 
            // ItemForVendorListExp
            // 
            this.ItemForVendorListExp.Control = this.VendorListExpPopupContainerEdit;
            this.ItemForVendorListExp.Location = new System.Drawing.Point(330, 24);
            this.ItemForVendorListExp.Name = "ItemForVendorListExp";
            this.ItemForVendorListExp.Size = new System.Drawing.Size(331, 24);
            this.ItemForVendorListExp.Text = "Vendor List Exp";
            this.ItemForVendorListExp.TextSize = new System.Drawing.Size(86, 13);
            // 
            // StoreListExpPopupContainerEdit
            // 
            this.StoreListExpPopupContainerEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userParameterBindingSource, "StoreListExp", true));
            this.StoreListExpPopupContainerEdit.Location = new System.Drawing.Point(102, 60);
            this.StoreListExpPopupContainerEdit.Name = "StoreListExpPopupContainerEdit";
            this.StoreListExpPopupContainerEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StoreListExpPopupContainerEdit.Size = new System.Drawing.Size(236, 20);
            this.StoreListExpPopupContainerEdit.StyleController = this.dataLayoutControl1;
            this.StoreListExpPopupContainerEdit.TabIndex = 8;
            // 
            // ItemForStoreListExp
            // 
            this.ItemForStoreListExp.Control = this.StoreListExpPopupContainerEdit;
            this.ItemForStoreListExp.Location = new System.Drawing.Point(0, 48);
            this.ItemForStoreListExp.Name = "ItemForStoreListExp";
            this.ItemForStoreListExp.Size = new System.Drawing.Size(330, 196);
            this.ItemForStoreListExp.Text = "Store List Exp";
            this.ItemForStoreListExp.TextSize = new System.Drawing.Size(86, 13);
            // 
            // SiteListExpPopupContainerEdit
            // 
            this.SiteListExpPopupContainerEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userParameterBindingSource, "SiteListExp", true));
            this.SiteListExpPopupContainerEdit.Location = new System.Drawing.Point(432, 60);
            this.SiteListExpPopupContainerEdit.Name = "SiteListExpPopupContainerEdit";
            this.SiteListExpPopupContainerEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SiteListExpPopupContainerEdit.Size = new System.Drawing.Size(237, 20);
            this.SiteListExpPopupContainerEdit.StyleController = this.dataLayoutControl1;
            this.SiteListExpPopupContainerEdit.TabIndex = 9;
            // 
            // ItemForSiteListExp
            // 
            this.ItemForSiteListExp.Control = this.SiteListExpPopupContainerEdit;
            this.ItemForSiteListExp.Location = new System.Drawing.Point(330, 48);
            this.ItemForSiteListExp.Name = "ItemForSiteListExp";
            this.ItemForSiteListExp.Size = new System.Drawing.Size(331, 196);
            this.ItemForSiteListExp.Text = "Site List Exp";
            this.ItemForSiteListExp.TextSize = new System.Drawing.Size(86, 13);
            // 
            // userParameterBindingSource
            // 
            this.userParameterBindingSource.DataSource = typeof(B_PowerWin.DB.GUI.UserParameter);
            // 
            // UserParamSelectXUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "UserParamSelectXUC";
            this.Size = new System.Drawing.Size(694, 267);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerListExpPopupContainerEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomerListExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendorListExpPopupContainerEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVendorListExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreListExpPopupContainerEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStoreListExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SiteListExpPopupContainerEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSiteListExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userParameterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.DateEdit StartDateDateEdit;
        private System.Windows.Forms.BindingSource userParameterBindingSource;
        private DevExpress.XtraEditors.DateEdit EndDateDateEdit;
        private DevExpress.XtraEditors.PopupContainerEdit CustomerListExpPopupContainerEdit;
        private DevExpress.XtraEditors.PopupContainerEdit VendorListExpPopupContainerEdit;
        private DevExpress.XtraEditors.PopupContainerEdit StoreListExpPopupContainerEdit;
        private DevExpress.XtraEditors.PopupContainerEdit SiteListExpPopupContainerEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForStartDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEndDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCustomerListExp;
        private DevExpress.XtraLayout.LayoutControlItem ItemForVendorListExp;
        private DevExpress.XtraLayout.LayoutControlItem ItemForStoreListExp;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSiteListExp;
    }
}
