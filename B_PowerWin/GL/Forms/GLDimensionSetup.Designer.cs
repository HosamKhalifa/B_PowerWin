namespace B_PowerWin.GL.Forms
{
    partial class GLDimensionSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GLDimensionSetup));
            this.dimensionNavPane = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.businessUnitNavPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.businessUnitGC = new B_PowerWin.GUI.Grid.GridCtrlBase();
            this.businessUnitBS = new System.Windows.Forms.BindingSource();
            this.businessUnitGV = new B_PowerWin.GUI.Grid.GridViewBase();
            this.colDimDefaults = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInventDimDefaults = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBusinessUnitCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBusinessUnitName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastErrorMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaseType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParnetId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.siteNavPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.siteGC = new B_PowerWin.GUI.Grid.GridCtrlBase();
            this.siteBS = new System.Windows.Forms.BindingSource();
            this.siteGV = new B_PowerWin.GUI.Grid.GridViewBase();
            this.deptartmentNavPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.departmentGC = new B_PowerWin.GUI.Grid.GridCtrlBase();
            this.departmentBS = new System.Windows.Forms.BindingSource();
            this.departmentGV = new B_PowerWin.GUI.Grid.GridViewBase();
            this.projectNavPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.projectGC = new B_PowerWin.GUI.Grid.GridCtrlBase();
            this.projectBS = new System.Windows.Forms.BindingSource();
            this.projectGV = new B_PowerWin.GUI.Grid.GridViewBase();
            this.purposeNavPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.purposeGC = new B_PowerWin.GUI.Grid.GridCtrlBase();
            this.purposeBS = new System.Windows.Forms.BindingSource();
            this.purposeGV = new B_PowerWin.GUI.Grid.GridViewBase();
            this.equipmentNavPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.equipmentGC = new B_PowerWin.GUI.Grid.GridCtrlBase();
            this.equipmentBS = new System.Windows.Forms.BindingSource();
            this.equipmentGV = new B_PowerWin.GUI.Grid.GridViewBase();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionNavPane)).BeginInit();
            this.dimensionNavPane.SuspendLayout();
            this.businessUnitNavPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.businessUnitGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessUnitBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessUnitGV)).BeginInit();
            this.siteNavPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siteGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteGV)).BeginInit();
            this.deptartmentNavPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentGV)).BeginInit();
            this.projectNavPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectGV)).BeginInit();
            this.purposeNavPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purposeGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purposeBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purposeGV)).BeginInit();
            this.equipmentNavPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentGV)).BeginInit();
            this.SuspendLayout();
            // 
            // dimensionNavPane
            // 
            this.dimensionNavPane.Controls.Add(this.businessUnitNavPage);
            this.dimensionNavPane.Controls.Add(this.siteNavPage);
            this.dimensionNavPane.Controls.Add(this.deptartmentNavPage);
            this.dimensionNavPane.Controls.Add(this.projectNavPage);
            this.dimensionNavPane.Controls.Add(this.purposeNavPage);
            this.dimensionNavPane.Controls.Add(this.equipmentNavPage);
            this.dimensionNavPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dimensionNavPane.Location = new System.Drawing.Point(0, 31);
            this.dimensionNavPane.Name = "dimensionNavPane";
            this.dimensionNavPane.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.dimensionNavPane.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.businessUnitNavPage,
            this.siteNavPage,
            this.deptartmentNavPage,
            this.projectNavPage,
            this.purposeNavPage,
            this.equipmentNavPage});
            this.dimensionNavPane.RegularSize = new System.Drawing.Size(766, 531);
            this.dimensionNavPane.SelectedPage = this.businessUnitNavPage;
            this.dimensionNavPane.Size = new System.Drawing.Size(766, 531);
            this.dimensionNavPane.TabIndex = 4;
            this.dimensionNavPane.Text = "navigationPane1";
            // 
            // businessUnitNavPage
            // 
            this.businessUnitNavPage.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("businessUnitNavPage.Appearance.Image")));
            this.businessUnitNavPage.Appearance.Options.UseImage = true;
            this.businessUnitNavPage.Appearance.Options.UseTextOptions = true;
            this.businessUnitNavPage.Caption = "Business unit";
            this.businessUnitNavPage.Controls.Add(this.businessUnitGC);
            this.businessUnitNavPage.Image = ((System.Drawing.Image)(resources.GetObject("businessUnitNavPage.Image")));
            this.businessUnitNavPage.Name = "businessUnitNavPage";
            this.businessUnitNavPage.Size = new System.Drawing.Size(633, 471);
            // 
            // businessUnitGC
            // 
            this.businessUnitGC.DataSource = this.businessUnitBS;
            this.businessUnitGC.dbContext = null;
            this.businessUnitGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.businessUnitGC.Location = new System.Drawing.Point(0, 0);
            this.businessUnitGC.MainView = this.businessUnitGV;
            this.businessUnitGC.MenuManager = this.barManager1;
            this.businessUnitGC.Name = "businessUnitGC";
            this.businessUnitGC.Size = new System.Drawing.Size(633, 471);
            this.businessUnitGC.TabIndex = 0;
            this.businessUnitGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.businessUnitGV});
            // 
            // businessUnitBS
            // 
            this.businessUnitBS.DataSource = typeof(B_PowerWin.DB.BusinessUnit);
            // 
            // businessUnitGV
            // 
            this.businessUnitGV.BaseTypeEnum = B_PowerWin.DB.BaseTypeEnum.BusinessUnit;
            this.businessUnitGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDimDefaults,
            this.colInventDimDefaults,
            this.colBusinessUnitCode,
            this.colBusinessUnitName,
            this.colLastErrorMessage,
            this.colId,
            this.colCreatedBy,
            this.colCreatedAt,
            this.colModifiedBy,
            this.colModifiedAt,
            this.colBaseType,
            this.colParnetId});
            this.businessUnitGV.GridControl = this.businessUnitGC;
            this.businessUnitGV.GridViewEditMode = B_PowerWin.GUI.Grid.GridViewEditModeEnum.SimpleEdit;
            this.businessUnitGV.Name = "businessUnitGV";
            // 
            // colDimDefaults
            // 
            this.colDimDefaults.FieldName = "DimDefaults";
            this.colDimDefaults.Name = "colDimDefaults";
            this.colDimDefaults.Visible = true;
            this.colDimDefaults.VisibleIndex = 0;
            // 
            // colInventDimDefaults
            // 
            this.colInventDimDefaults.FieldName = "InventDimDefaults";
            this.colInventDimDefaults.Name = "colInventDimDefaults";
            this.colInventDimDefaults.Visible = true;
            this.colInventDimDefaults.VisibleIndex = 1;
            // 
            // colBusinessUnitCode
            // 
            this.colBusinessUnitCode.FieldName = "BusinessUnitCode";
            this.colBusinessUnitCode.Name = "colBusinessUnitCode";
            this.colBusinessUnitCode.Visible = true;
            this.colBusinessUnitCode.VisibleIndex = 2;
            // 
            // colBusinessUnitName
            // 
            this.colBusinessUnitName.FieldName = "BusinessUnitName";
            this.colBusinessUnitName.Name = "colBusinessUnitName";
            this.colBusinessUnitName.Visible = true;
            this.colBusinessUnitName.VisibleIndex = 3;
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
            // siteNavPage
            // 
            this.siteNavPage.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("siteNavPage.Appearance.Image")));
            this.siteNavPage.Appearance.Options.UseImage = true;
            this.siteNavPage.Appearance.Options.UseTextOptions = true;
            this.siteNavPage.Caption = "Sites {Locations}";
            this.siteNavPage.Controls.Add(this.siteGC);
            this.siteNavPage.Image = ((System.Drawing.Image)(resources.GetObject("siteNavPage.Image")));
            this.siteNavPage.Name = "siteNavPage";
            this.siteNavPage.Size = new System.Drawing.Size(633, 471);
            // 
            // siteGC
            // 
            this.siteGC.DataSource = this.siteBS;
            this.siteGC.dbContext = null;
            this.siteGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siteGC.Location = new System.Drawing.Point(0, 0);
            this.siteGC.MainView = this.siteGV;
            this.siteGC.MenuManager = this.barManager1;
            this.siteGC.Name = "siteGC";
            this.siteGC.Size = new System.Drawing.Size(633, 471);
            this.siteGC.TabIndex = 0;
            this.siteGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.siteGV});
            // 
            // siteGV
            // 
            this.siteGV.BaseTypeEnum = B_PowerWin.DB.BaseTypeEnum.Site;
            this.siteGV.GridControl = this.siteGC;
            this.siteGV.GridViewEditMode = B_PowerWin.GUI.Grid.GridViewEditModeEnum.FormEdit;
            this.siteGV.Name = "siteGV";
            // 
            // deptartmentNavPage
            // 
            this.deptartmentNavPage.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("deptartmentNavPage.Appearance.Image")));
            this.deptartmentNavPage.Appearance.Options.UseImage = true;
            this.deptartmentNavPage.Caption = "Departments";
            this.deptartmentNavPage.Controls.Add(this.departmentGC);
            this.deptartmentNavPage.Image = ((System.Drawing.Image)(resources.GetObject("deptartmentNavPage.Image")));
            this.deptartmentNavPage.Name = "deptartmentNavPage";
            this.deptartmentNavPage.Size = new System.Drawing.Size(633, 471);
            // 
            // departmentGC
            // 
            this.departmentGC.DataSource = this.departmentBS;
            this.departmentGC.dbContext = null;
            this.departmentGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departmentGC.Location = new System.Drawing.Point(0, 0);
            this.departmentGC.MainView = this.departmentGV;
            this.departmentGC.MenuManager = this.barManager1;
            this.departmentGC.Name = "departmentGC";
            this.departmentGC.Size = new System.Drawing.Size(633, 471);
            this.departmentGC.TabIndex = 0;
            this.departmentGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.departmentGV});
            // 
            // departmentGV
            // 
            this.departmentGV.BaseTypeEnum = B_PowerWin.DB.BaseTypeEnum.Department;
            this.departmentGV.GridControl = this.departmentGC;
            this.departmentGV.GridViewEditMode = B_PowerWin.GUI.Grid.GridViewEditModeEnum.FormEdit;
            this.departmentGV.Name = "departmentGV";
            // 
            // projectNavPage
            // 
            this.projectNavPage.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("projectNavPage.Appearance.Image")));
            this.projectNavPage.Appearance.Options.UseImage = true;
            this.projectNavPage.Caption = "Projects";
            this.projectNavPage.Controls.Add(this.projectGC);
            this.projectNavPage.Image = ((System.Drawing.Image)(resources.GetObject("projectNavPage.Image")));
            this.projectNavPage.Name = "projectNavPage";
            this.projectNavPage.Size = new System.Drawing.Size(633, 471);
            // 
            // projectGC
            // 
            this.projectGC.DataSource = this.projectBS;
            this.projectGC.dbContext = null;
            this.projectGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectGC.Location = new System.Drawing.Point(0, 0);
            this.projectGC.MainView = this.projectGV;
            this.projectGC.MenuManager = this.barManager1;
            this.projectGC.Name = "projectGC";
            this.projectGC.Size = new System.Drawing.Size(633, 471);
            this.projectGC.TabIndex = 0;
            this.projectGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.projectGV});
            // 
            // projectGV
            // 
            this.projectGV.BaseTypeEnum = B_PowerWin.DB.BaseTypeEnum.Project;
            this.projectGV.GridControl = this.projectGC;
            this.projectGV.GridViewEditMode = B_PowerWin.GUI.Grid.GridViewEditModeEnum.FormEdit;
            this.projectGV.Name = "projectGV";
            // 
            // purposeNavPage
            // 
            this.purposeNavPage.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("purposeNavPage.Appearance.Image")));
            this.purposeNavPage.Appearance.Options.UseImage = true;
            this.purposeNavPage.Caption = "Purposes";
            this.purposeNavPage.Controls.Add(this.purposeGC);
            this.purposeNavPage.Image = ((System.Drawing.Image)(resources.GetObject("purposeNavPage.Image")));
            this.purposeNavPage.Name = "purposeNavPage";
            this.purposeNavPage.Size = new System.Drawing.Size(633, 471);
            // 
            // purposeGC
            // 
            this.purposeGC.DataSource = this.purposeBS;
            this.purposeGC.dbContext = null;
            this.purposeGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purposeGC.Location = new System.Drawing.Point(0, 0);
            this.purposeGC.MainView = this.purposeGV;
            this.purposeGC.MenuManager = this.barManager1;
            this.purposeGC.Name = "purposeGC";
            this.purposeGC.Size = new System.Drawing.Size(633, 471);
            this.purposeGC.TabIndex = 0;
            this.purposeGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.purposeGV});
            // 
            // purposeGV
            // 
            this.purposeGV.BaseTypeEnum = B_PowerWin.DB.BaseTypeEnum.Purpose;
            this.purposeGV.GridControl = this.purposeGC;
            this.purposeGV.GridViewEditMode = B_PowerWin.GUI.Grid.GridViewEditModeEnum.FormEdit;
            this.purposeGV.Name = "purposeGV";
            // 
            // equipmentNavPage
            // 
            this.equipmentNavPage.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("equipmentNavPage.Appearance.Image")));
            this.equipmentNavPage.Appearance.Options.UseImage = true;
            this.equipmentNavPage.Caption = "Equipments";
            this.equipmentNavPage.Controls.Add(this.equipmentGC);
            this.equipmentNavPage.Image = ((System.Drawing.Image)(resources.GetObject("equipmentNavPage.Image")));
            this.equipmentNavPage.Name = "equipmentNavPage";
            this.equipmentNavPage.Size = new System.Drawing.Size(633, 471);
            // 
            // equipmentGC
            // 
            this.equipmentGC.DataSource = this.equipmentBS;
            this.equipmentGC.dbContext = null;
            this.equipmentGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipmentGC.Location = new System.Drawing.Point(0, 0);
            this.equipmentGC.MainView = this.equipmentGV;
            this.equipmentGC.MenuManager = this.barManager1;
            this.equipmentGC.Name = "equipmentGC";
            this.equipmentGC.Size = new System.Drawing.Size(633, 471);
            this.equipmentGC.TabIndex = 0;
            this.equipmentGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.equipmentGV});
            // 
            // equipmentGV
            // 
            this.equipmentGV.BaseTypeEnum = B_PowerWin.DB.BaseTypeEnum.Equipment;
            this.equipmentGV.GridControl = this.equipmentGC;
            this.equipmentGV.GridViewEditMode = B_PowerWin.GUI.Grid.GridViewEditModeEnum.FormEdit;
            this.equipmentGV.Name = "equipmentGV";
            // 
            // GLDimensionSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 585);
            this.Controls.Add(this.dimensionNavPane);
            this.Name = "GLDimensionSetup";
            this.Text = "GLDimensionSetup";
            this.Controls.SetChildIndex(this.dimensionNavPane, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dimensionNavPane)).EndInit();
            this.dimensionNavPane.ResumeLayout(false);
            this.businessUnitNavPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.businessUnitGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessUnitBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessUnitGV)).EndInit();
            this.siteNavPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siteGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteGV)).EndInit();
            this.deptartmentNavPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.departmentGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentGV)).EndInit();
            this.projectNavPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectGV)).EndInit();
            this.purposeNavPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.purposeGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purposeBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purposeGV)).EndInit();
            this.equipmentNavPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane dimensionNavPane;
        private DevExpress.XtraBars.Navigation.NavigationPage businessUnitNavPage;
        private DevExpress.XtraBars.Navigation.NavigationPage siteNavPage;
        private DevExpress.XtraBars.Navigation.NavigationPage deptartmentNavPage;
        private DevExpress.XtraBars.Navigation.NavigationPage projectNavPage;
        private DevExpress.XtraBars.Navigation.NavigationPage purposeNavPage;
        private DevExpress.XtraBars.Navigation.NavigationPage equipmentNavPage;
        private GUI.Grid.GridCtrlBase businessUnitGC;
        private GUI.Grid.GridViewBase businessUnitGV;
        private System.Windows.Forms.BindingSource businessUnitBS;
        private System.Windows.Forms.BindingSource siteBS;
        private System.Windows.Forms.BindingSource departmentBS;
        private System.Windows.Forms.BindingSource projectBS;
        private System.Windows.Forms.BindingSource purposeBS;
        private System.Windows.Forms.BindingSource equipmentBS;
        private GUI.Grid.GridCtrlBase siteGC;
        private GUI.Grid.GridViewBase siteGV;
        private GUI.Grid.GridCtrlBase departmentGC;
        private GUI.Grid.GridViewBase departmentGV;
        private GUI.Grid.GridCtrlBase projectGC;
        private GUI.Grid.GridViewBase projectGV;
        private GUI.Grid.GridCtrlBase purposeGC;
        private GUI.Grid.GridViewBase purposeGV;
        private GUI.Grid.GridCtrlBase equipmentGC;
        private GUI.Grid.GridViewBase equipmentGV;
        private DevExpress.XtraGrid.Columns.GridColumn colDimDefaults;
        private DevExpress.XtraGrid.Columns.GridColumn colInventDimDefaults;
        private DevExpress.XtraGrid.Columns.GridColumn colBusinessUnitCode;
        private DevExpress.XtraGrid.Columns.GridColumn colBusinessUnitName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastErrorMessage;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseType;
        private DevExpress.XtraGrid.Columns.GridColumn colParnetId;
    }
}