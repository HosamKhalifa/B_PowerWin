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
            this.colMainAccountGroupId = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colGroupId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisplayNumSequVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMainAccountSetManually = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMainAccountId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuspended = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParnetId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentIdList = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentNameList = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMainAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastErrorMessage = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colMainAccountGroupId,
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
            this.colGroupId,
            this.colTaxGroup,
            this.colDisplayNumSequVersion,
            this.colMainAccountSetManually,
            this.colMainAccountId,
            this.colSuspended,
            this.colParnetId,
            this.colParentIdList,
            this.colParentNameList,
            this.colMainAccount,
            this.colAccountGroup,
            this.colLastErrorMessage,
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
            // 
            // colMainAccountType
            // 
            this.colMainAccountType.FieldName = "MainAccountType";
            this.colMainAccountType.Name = "colMainAccountType";
            this.colMainAccountType.Visible = true;
            this.colMainAccountType.VisibleIndex = 0;
            // 
            // colMainAccountGroupId
            // 
            this.colMainAccountGroupId.FieldName = "MainAccountGroupId";
            this.colMainAccountGroupId.Name = "colMainAccountGroupId";
            this.colMainAccountGroupId.Visible = true;
            this.colMainAccountGroupId.VisibleIndex = 1;
            // 
            // colBalanceControl
            // 
            this.colBalanceControl.FieldName = "BalanceControl";
            this.colBalanceControl.Name = "colBalanceControl";
            this.colBalanceControl.Visible = true;
            this.colBalanceControl.VisibleIndex = 2;
            // 
            // colDisableManualEntry
            // 
            this.colDisableManualEntry.FieldName = "DisableManualEntry";
            this.colDisableManualEntry.Name = "colDisableManualEntry";
            this.colDisableManualEntry.Visible = true;
            this.colDisableManualEntry.VisibleIndex = 3;
            // 
            // colRequiredBusinessUnit
            // 
            this.colRequiredBusinessUnit.FieldName = "RequiredBusinessUnit";
            this.colRequiredBusinessUnit.Name = "colRequiredBusinessUnit";
            this.colRequiredBusinessUnit.Visible = true;
            this.colRequiredBusinessUnit.VisibleIndex = 4;
            // 
            // colRequiredSite
            // 
            this.colRequiredSite.FieldName = "RequiredSite";
            this.colRequiredSite.Name = "colRequiredSite";
            this.colRequiredSite.Visible = true;
            this.colRequiredSite.VisibleIndex = 5;
            // 
            // colRequiredDept
            // 
            this.colRequiredDept.FieldName = "RequiredDept";
            this.colRequiredDept.Name = "colRequiredDept";
            this.colRequiredDept.Visible = true;
            this.colRequiredDept.VisibleIndex = 6;
            // 
            // colRequiredEquipment
            // 
            this.colRequiredEquipment.FieldName = "RequiredEquipment";
            this.colRequiredEquipment.Name = "colRequiredEquipment";
            this.colRequiredEquipment.Visible = true;
            this.colRequiredEquipment.VisibleIndex = 7;
            // 
            // colRequiredProject
            // 
            this.colRequiredProject.FieldName = "RequiredProject";
            this.colRequiredProject.Name = "colRequiredProject";
            this.colRequiredProject.Visible = true;
            this.colRequiredProject.VisibleIndex = 8;
            // 
            // colRequiredPurpose
            // 
            this.colRequiredPurpose.FieldName = "RequiredPurpose";
            this.colRequiredPurpose.Name = "colRequiredPurpose";
            this.colRequiredPurpose.Visible = true;
            this.colRequiredPurpose.VisibleIndex = 9;
            // 
            // colRequiredBank
            // 
            this.colRequiredBank.FieldName = "RequiredBank";
            this.colRequiredBank.Name = "colRequiredBank";
            this.colRequiredBank.Visible = true;
            this.colRequiredBank.VisibleIndex = 10;
            // 
            // colRequiredCash
            // 
            this.colRequiredCash.FieldName = "RequiredCash";
            this.colRequiredCash.Name = "colRequiredCash";
            this.colRequiredCash.Visible = true;
            this.colRequiredCash.VisibleIndex = 11;
            // 
            // colRequiredCustomer
            // 
            this.colRequiredCustomer.FieldName = "RequiredCustomer";
            this.colRequiredCustomer.Name = "colRequiredCustomer";
            this.colRequiredCustomer.Visible = true;
            this.colRequiredCustomer.VisibleIndex = 12;
            // 
            // colRequiredVendor
            // 
            this.colRequiredVendor.FieldName = "RequiredVendor";
            this.colRequiredVendor.Name = "colRequiredVendor";
            this.colRequiredVendor.Visible = true;
            this.colRequiredVendor.VisibleIndex = 13;
            // 
            // colRequiredEmployee
            // 
            this.colRequiredEmployee.FieldName = "RequiredEmployee";
            this.colRequiredEmployee.Name = "colRequiredEmployee";
            this.colRequiredEmployee.Visible = true;
            this.colRequiredEmployee.VisibleIndex = 14;
            // 
            // colRequiredPos
            // 
            this.colRequiredPos.FieldName = "RequiredPos";
            this.colRequiredPos.Name = "colRequiredPos";
            this.colRequiredPos.Visible = true;
            this.colRequiredPos.VisibleIndex = 15;
            // 
            // colIsTotal
            // 
            this.colIsTotal.FieldName = "IsTotal";
            this.colIsTotal.Name = "colIsTotal";
            this.colIsTotal.Visible = true;
            this.colIsTotal.VisibleIndex = 16;
            // 
            // colMainAccountGroup
            // 
            this.colMainAccountGroup.FieldName = "MainAccountGroup";
            this.colMainAccountGroup.Name = "colMainAccountGroup";
            this.colMainAccountGroup.Visible = true;
            this.colMainAccountGroup.VisibleIndex = 17;
            // 
            // colCompanyId
            // 
            this.colCompanyId.FieldName = "CompanyId";
            this.colCompanyId.Name = "colCompanyId";
            this.colCompanyId.Visible = true;
            this.colCompanyId.VisibleIndex = 18;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 19;
            // 
            // colDisplayNum
            // 
            this.colDisplayNum.FieldName = "DisplayNum";
            this.colDisplayNum.Name = "colDisplayNum";
            this.colDisplayNum.Visible = true;
            this.colDisplayNum.VisibleIndex = 20;
            // 
            // colReferenceNum
            // 
            this.colReferenceNum.FieldName = "ReferenceNum";
            this.colReferenceNum.Name = "colReferenceNum";
            this.colReferenceNum.Visible = true;
            this.colReferenceNum.VisibleIndex = 21;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 22;
            // 
            // colGroupId
            // 
            this.colGroupId.FieldName = "GroupId";
            this.colGroupId.Name = "colGroupId";
            this.colGroupId.Visible = true;
            this.colGroupId.VisibleIndex = 23;
            // 
            // colTaxGroup
            // 
            this.colTaxGroup.FieldName = "TaxGroup";
            this.colTaxGroup.Name = "colTaxGroup";
            this.colTaxGroup.Visible = true;
            this.colTaxGroup.VisibleIndex = 24;
            // 
            // colDisplayNumSequVersion
            // 
            this.colDisplayNumSequVersion.FieldName = "DisplayNumSequVersion";
            this.colDisplayNumSequVersion.Name = "colDisplayNumSequVersion";
            this.colDisplayNumSequVersion.Visible = true;
            this.colDisplayNumSequVersion.VisibleIndex = 25;
            // 
            // colMainAccountSetManually
            // 
            this.colMainAccountSetManually.FieldName = "MainAccountSetManually";
            this.colMainAccountSetManually.Name = "colMainAccountSetManually";
            this.colMainAccountSetManually.Visible = true;
            this.colMainAccountSetManually.VisibleIndex = 26;
            // 
            // colMainAccountId
            // 
            this.colMainAccountId.FieldName = "MainAccountId";
            this.colMainAccountId.Name = "colMainAccountId";
            this.colMainAccountId.Visible = true;
            this.colMainAccountId.VisibleIndex = 27;
            // 
            // colSuspended
            // 
            this.colSuspended.FieldName = "Suspended";
            this.colSuspended.Name = "colSuspended";
            this.colSuspended.Visible = true;
            this.colSuspended.VisibleIndex = 28;
            // 
            // colParnetId
            // 
            this.colParnetId.FieldName = "ParnetId";
            this.colParnetId.Name = "colParnetId";
            this.colParnetId.Visible = true;
            this.colParnetId.VisibleIndex = 29;
            // 
            // colParentIdList
            // 
            this.colParentIdList.FieldName = "ParentIdList";
            this.colParentIdList.Name = "colParentIdList";
            this.colParentIdList.OptionsColumn.ReadOnly = true;
            this.colParentIdList.Visible = true;
            this.colParentIdList.VisibleIndex = 30;
            // 
            // colParentNameList
            // 
            this.colParentNameList.FieldName = "ParentNameList";
            this.colParentNameList.Name = "colParentNameList";
            this.colParentNameList.OptionsColumn.ReadOnly = true;
            this.colParentNameList.Visible = true;
            this.colParentNameList.VisibleIndex = 31;
            // 
            // colMainAccount
            // 
            this.colMainAccount.FieldName = "MainAccount";
            this.colMainAccount.Name = "colMainAccount";
            this.colMainAccount.Visible = true;
            this.colMainAccount.VisibleIndex = 32;
            // 
            // colAccountGroup
            // 
            this.colAccountGroup.FieldName = "AccountGroup";
            this.colAccountGroup.Name = "colAccountGroup";
            this.colAccountGroup.Visible = true;
            this.colAccountGroup.VisibleIndex = 33;
            // 
            // colLastErrorMessage
            // 
            this.colLastErrorMessage.FieldName = "LastErrorMessage";
            this.colLastErrorMessage.Name = "colLastErrorMessage";
            this.colLastErrorMessage.Visible = true;
            this.colLastErrorMessage.VisibleIndex = 34;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 35;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.FieldName = "CreatedBy";
            this.colCreatedBy.Name = "colCreatedBy";
            this.colCreatedBy.Visible = true;
            this.colCreatedBy.VisibleIndex = 36;
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.FieldName = "CreatedAt";
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.Visible = true;
            this.colCreatedAt.VisibleIndex = 37;
            // 
            // colModifiedBy
            // 
            this.colModifiedBy.FieldName = "ModifiedBy";
            this.colModifiedBy.Name = "colModifiedBy";
            this.colModifiedBy.Visible = true;
            this.colModifiedBy.VisibleIndex = 38;
            // 
            // colModifiedAt
            // 
            this.colModifiedAt.FieldName = "ModifiedAt";
            this.colModifiedAt.Name = "colModifiedAt";
            this.colModifiedAt.Visible = true;
            this.colModifiedAt.VisibleIndex = 39;
            // 
            // colBaseType
            // 
            this.colBaseType.FieldName = "BaseType";
            this.colBaseType.Name = "colBaseType";
            this.colBaseType.Visible = true;
            this.colBaseType.VisibleIndex = 40;
            // 
            // colWFStatus
            // 
            this.colWFStatus.FieldName = "WFStatus";
            this.colWFStatus.Name = "colWFStatus";
            this.colWFStatus.Visible = true;
            this.colWFStatus.VisibleIndex = 41;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GUI.Grid.GridCtrlBase mainAccountGC;
        private GUI.Grid.GridViewBase mainAccountGV;
        private System.Windows.Forms.BindingSource mainAccountBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMainAccountType;
        private DevExpress.XtraGrid.Columns.GridColumn colMainAccountGroupId;
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
        private DevExpress.XtraGrid.Columns.GridColumn colGroupId;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colDisplayNumSequVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colMainAccountSetManually;
        private DevExpress.XtraGrid.Columns.GridColumn colMainAccountId;
        private DevExpress.XtraGrid.Columns.GridColumn colSuspended;
        private DevExpress.XtraGrid.Columns.GridColumn colParnetId;
        private DevExpress.XtraGrid.Columns.GridColumn colParentIdList;
        private DevExpress.XtraGrid.Columns.GridColumn colParentNameList;
        private DevExpress.XtraGrid.Columns.GridColumn colMainAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colLastErrorMessage;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseType;
        private DevExpress.XtraGrid.Columns.GridColumn colWFStatus;
    }
}
