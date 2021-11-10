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
            this.colBalanceControl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisableManualEntry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequiredBusinessUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequiredSite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequiredDept = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequiredEquipment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequiredProject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequiredPurpose = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequiredBank = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequiredCash = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequiredCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequiredVendor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequiredEmployee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequiredPos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMainAccountGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisplayNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferenceNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParnetId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.parentAccLookup = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.mainAccountLookup = new System.Windows.Forms.BindingSource(this.components);
            this.colParentNameList = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaseType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWFStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentAccLookup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountLookup)).BeginInit();
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
            this.mainAccountGC.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.parentAccLookup});
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
            this.colBalanceControl,
            this.colDisableManualEntry,
            this.colRequiredBusinessUnit,
            this.colRequiredSite,
            this.colRequiredDept,
            this.colRequiredEquipment,
            this.colRequiredProject,
            this.colRequiredPurpose,
            this.colRequiredBank,
            this.colRequiredCash,
            this.colRequiredCustomer,
            this.colRequiredVendor,
            this.colRequiredEmployee,
            this.colRequiredPos,
            this.colIsTotal,
            this.colMainAccountGroup,
            this.colCompanyId,
            this.colName,
            this.colDisplayNum,
            this.colReferenceNum,
            this.colDescription,
            this.colParnetId,
            this.colParentNameList,
            this.colId,
            this.colCreatedBy,
            this.colCreatedAt,
            this.colModifiedBy,
            this.colModifiedAt,
            this.colBaseType,
            this.colWFStatus});
            this.mainAccountGV.EnableAutoFormat = false;
            this.mainAccountGV.GridControl = this.mainAccountGC;
            this.mainAccountGV.GridViewEditMode = B_PowerWin.GUI.Grid.GridViewEditModeEnum.FormEdit;
            this.mainAccountGV.Name = "mainAccountGV";
            this.mainAccountGV.OptionsView.ColumnAutoWidth = false;
            this.mainAccountGV.OptionsView.ShowAutoFilterRow = true;
            // 
            // colMainAccountType
            // 
            this.colMainAccountType.Caption = "Type";
            this.colMainAccountType.FieldName = "MainAccountType";
            this.colMainAccountType.Name = "colMainAccountType";
            this.colMainAccountType.OptionsEditForm.VisibleIndex = 50;
            this.colMainAccountType.Visible = true;
            this.colMainAccountType.VisibleIndex = 3;
            this.colMainAccountType.Width = 118;
            // 
            // colBalanceControl
            // 
            this.colBalanceControl.FieldName = "BalanceControl";
            this.colBalanceControl.Name = "colBalanceControl";
            this.colBalanceControl.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colBalanceControl.OptionsEditForm.VisibleIndex = 60;
            // 
            // colDisableManualEntry
            // 
            this.colDisableManualEntry.FieldName = "DisableManualEntry";
            this.colDisableManualEntry.Name = "colDisableManualEntry";
            this.colDisableManualEntry.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colDisableManualEntry.OptionsEditForm.VisibleIndex = 70;
            // 
            // colRequiredBusinessUnit
            // 
            this.colRequiredBusinessUnit.FieldName = "RequiredBusinessUnit";
            this.colRequiredBusinessUnit.Name = "colRequiredBusinessUnit";
            this.colRequiredBusinessUnit.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colRequiredBusinessUnit.OptionsEditForm.VisibleIndex = 90;
            // 
            // colRequiredSite
            // 
            this.colRequiredSite.FieldName = "RequiredSite";
            this.colRequiredSite.Name = "colRequiredSite";
            this.colRequiredSite.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colRequiredSite.OptionsEditForm.VisibleIndex = 100;
            // 
            // colRequiredDept
            // 
            this.colRequiredDept.FieldName = "RequiredDept";
            this.colRequiredDept.Name = "colRequiredDept";
            this.colRequiredDept.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colRequiredDept.OptionsEditForm.VisibleIndex = 110;
            // 
            // colRequiredEquipment
            // 
            this.colRequiredEquipment.FieldName = "RequiredEquipment";
            this.colRequiredEquipment.Name = "colRequiredEquipment";
            this.colRequiredEquipment.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colRequiredEquipment.OptionsEditForm.VisibleIndex = 120;
            // 
            // colRequiredProject
            // 
            this.colRequiredProject.FieldName = "RequiredProject";
            this.colRequiredProject.Name = "colRequiredProject";
            this.colRequiredProject.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colRequiredProject.OptionsEditForm.VisibleIndex = 130;
            // 
            // colRequiredPurpose
            // 
            this.colRequiredPurpose.FieldName = "RequiredPurpose";
            this.colRequiredPurpose.Name = "colRequiredPurpose";
            this.colRequiredPurpose.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colRequiredPurpose.OptionsEditForm.VisibleIndex = 140;
            // 
            // colRequiredBank
            // 
            this.colRequiredBank.FieldName = "RequiredBank";
            this.colRequiredBank.Name = "colRequiredBank";
            this.colRequiredBank.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colRequiredBank.OptionsEditForm.VisibleIndex = 150;
            // 
            // colRequiredCash
            // 
            this.colRequiredCash.FieldName = "RequiredCash";
            this.colRequiredCash.Name = "colRequiredCash";
            this.colRequiredCash.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colRequiredCash.OptionsEditForm.VisibleIndex = 160;
            // 
            // colRequiredCustomer
            // 
            this.colRequiredCustomer.FieldName = "RequiredCustomer";
            this.colRequiredCustomer.Name = "colRequiredCustomer";
            this.colRequiredCustomer.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colRequiredCustomer.OptionsEditForm.VisibleIndex = 170;
            // 
            // colRequiredVendor
            // 
            this.colRequiredVendor.FieldName = "RequiredVendor";
            this.colRequiredVendor.Name = "colRequiredVendor";
            this.colRequiredVendor.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colRequiredVendor.OptionsEditForm.VisibleIndex = 180;
            // 
            // colRequiredEmployee
            // 
            this.colRequiredEmployee.FieldName = "RequiredEmployee";
            this.colRequiredEmployee.Name = "colRequiredEmployee";
            this.colRequiredEmployee.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colRequiredEmployee.OptionsEditForm.VisibleIndex = 190;
            // 
            // colRequiredPos
            // 
            this.colRequiredPos.FieldName = "RequiredPos";
            this.colRequiredPos.Name = "colRequiredPos";
            this.colRequiredPos.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colRequiredPos.OptionsEditForm.VisibleIndex = 200;
            // 
            // colIsTotal
            // 
            this.colIsTotal.FieldName = "IsTotal";
            this.colIsTotal.Name = "colIsTotal";
            this.colIsTotal.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colMainAccountGroup
            // 
            this.colMainAccountGroup.FieldName = "MainAccountGroup";
            this.colMainAccountGroup.Name = "colMainAccountGroup";
            this.colMainAccountGroup.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colMainAccountGroup.OptionsEditForm.VisibleIndex = 80;
            // 
            // colCompanyId
            // 
            this.colCompanyId.FieldName = "CompanyId";
            this.colCompanyId.Name = "colCompanyId";
            this.colCompanyId.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsEditForm.VisibleIndex = 30;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            this.colName.Width = 209;
            // 
            // colDisplayNum
            // 
            this.colDisplayNum.FieldName = "DisplayNum";
            this.colDisplayNum.Name = "colDisplayNum";
            // 
            // colReferenceNum
            // 
            this.colReferenceNum.FieldName = "ReferenceNum";
            this.colReferenceNum.Name = "colReferenceNum";
            this.colReferenceNum.OptionsEditForm.VisibleIndex = 20;
            this.colReferenceNum.Visible = true;
            this.colReferenceNum.VisibleIndex = 1;
            this.colReferenceNum.Width = 104;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colDescription.OptionsEditForm.VisibleIndex = 40;
            // 
            // colParnetId
            // 
            this.colParnetId.ColumnEdit = this.parentAccLookup;
            this.colParnetId.FieldName = "ParnetId";
            this.colParnetId.Name = "colParnetId";
            this.colParnetId.OptionsEditForm.VisibleIndex = 10;
            this.colParnetId.Visible = true;
            this.colParnetId.VisibleIndex = 4;
            this.colParnetId.Width = 258;
            // 
            // parentAccLookup
            // 
            this.parentAccLookup.AutoHeight = false;
            this.parentAccLookup.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.parentAccLookup.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ReferenceNum", "Num", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 80, "Name")});
            this.parentAccLookup.DataSource = this.mainAccountLookup;
            this.parentAccLookup.DisplayMember = "FullName";
            this.parentAccLookup.KeyMember = "Id";
            this.parentAccLookup.Name = "parentAccLookup";
            this.parentAccLookup.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.parentAccLookup.ValueMember = "Id";
            // 
            // mainAccountLookup
            // 
            this.mainAccountLookup.DataSource = typeof(B_PowerWin.DB.MainAccount);
            // 
            // colParentNameList
            // 
            this.colParentNameList.FieldName = "ParentNameList";
            this.colParentNameList.Name = "colParentNameList";
            this.colParentNameList.OptionsColumn.ReadOnly = true;
            this.colParentNameList.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.FieldName = "CreatedBy";
            this.colCreatedBy.Name = "colCreatedBy";
            this.colCreatedBy.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.FieldName = "CreatedAt";
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colModifiedBy
            // 
            this.colModifiedBy.FieldName = "ModifiedBy";
            this.colModifiedBy.Name = "colModifiedBy";
            this.colModifiedBy.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colModifiedAt
            // 
            this.colModifiedAt.FieldName = "ModifiedAt";
            this.colModifiedAt.Name = "colModifiedAt";
            this.colModifiedAt.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colBaseType
            // 
            this.colBaseType.FieldName = "BaseType";
            this.colBaseType.Name = "colBaseType";
            this.colBaseType.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colWFStatus
            // 
            this.colWFStatus.FieldName = "WFStatus";
            this.colWFStatus.Name = "colWFStatus";
            this.colWFStatus.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // MainAccountFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(766, 585);
            this.Controls.Add(this.mainAccountGC);
            this.Name = "MainAccountFrm";
            this.Text = "Main accounts setup";
            this.Controls.SetChildIndex(this.mainAccountGC, 0);
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentAccLookup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountLookup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GUI.Grid.GridCtrlBase mainAccountGC;
        private GUI.Grid.GridViewBase mainAccountGV;
        private System.Windows.Forms.BindingSource mainAccountBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMainAccountType;
        private DevExpress.XtraGrid.Columns.GridColumn colBalanceControl;
        private DevExpress.XtraGrid.Columns.GridColumn colDisableManualEntry;
        private DevExpress.XtraGrid.Columns.GridColumn colRequiredBusinessUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colRequiredSite;
        private DevExpress.XtraGrid.Columns.GridColumn colRequiredDept;
        private DevExpress.XtraGrid.Columns.GridColumn colRequiredEquipment;
        private DevExpress.XtraGrid.Columns.GridColumn colRequiredProject;
        private DevExpress.XtraGrid.Columns.GridColumn colRequiredPurpose;
        private DevExpress.XtraGrid.Columns.GridColumn colRequiredBank;
        private DevExpress.XtraGrid.Columns.GridColumn colRequiredCash;
        private DevExpress.XtraGrid.Columns.GridColumn colRequiredCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colRequiredVendor;
        private DevExpress.XtraGrid.Columns.GridColumn colRequiredEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn colRequiredPos;
        private DevExpress.XtraGrid.Columns.GridColumn colIsTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colMainAccountGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDisplayNum;
        private DevExpress.XtraGrid.Columns.GridColumn colReferenceNum;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colParnetId;
        private DevExpress.XtraGrid.Columns.GridColumn colParentNameList;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseType;
        private DevExpress.XtraGrid.Columns.GridColumn colWFStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit parentAccLookup;
        private System.Windows.Forms.BindingSource mainAccountLookup;
    }
}
