namespace B_PowerWin.HR.Forms
{
    partial class EmployeeFrm
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
            this.employeeGC = new B_PowerWin.GUI.Grid.GridCtrlBase();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeGV = new B_PowerWin.GUI.Grid.GridViewBase();
            this.colIdentityCard = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInsuranceNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaritalState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReligion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankAccountNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMob = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCityId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsRetired = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBank = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisplayNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferenceNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuspended = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWFStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGV)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeGC
            // 
            this.employeeGC.DataSource = this.employeeBindingSource;
            this.employeeGC.dbContext = null;
            this.employeeGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeGC.Location = new System.Drawing.Point(0, 31);
            this.employeeGC.MainView = this.employeeGV;
            this.employeeGC.MenuManager = this.barManager1;
            this.employeeGC.Name = "employeeGC";
            this.employeeGC.Size = new System.Drawing.Size(766, 531);
            this.employeeGC.TabIndex = 4;
            this.employeeGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.employeeGV});
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(B_PowerWin.DB.Employee);
            // 
            // employeeGV
            // 
            this.employeeGV.BaseTypeEnum = B_PowerWin.DB.BaseTypeEnum.Employee;
            this.employeeGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdentityCard,
            this.colInsuranceNum,
            this.colGender,
            this.colMaritalState,
            this.colReligion,
            this.colBirthDate,
            this.colStartDate,
            this.colEndDate,
            this.colBankAccountNum,
            this.colBankId,
            this.colAddress,
            this.colMob,
            this.colEmail,
            this.colCountryId,
            this.colCityId,
            this.colIsRetired,
            this.colBank,
            this.colCountry,
            this.colCity,
            this.colName,
            this.colDisplayNum,
            this.colReferenceNum,
            this.colDescription,
            this.colGroupId,
            this.colSuspended,
            this.colAccountGroup,
            this.colId,
            this.colCreatedBy,
            this.colCreatedAt,
            this.colModifiedBy,
            this.colModifiedAt,
            this.colWFStatus});
            this.employeeGV.EnableAutoFormat = false;
            this.employeeGV.GridControl = this.employeeGC;
            this.employeeGV.GridViewEditMode = B_PowerWin.GUI.Grid.GridViewEditModeEnum.FormEdit;
            this.employeeGV.Name = "employeeGV";
            this.employeeGV.OptionsView.ColumnAutoWidth = false;
            // 
            // colIdentityCard
            // 
            this.colIdentityCard.FieldName = "IdentityCard";
            this.colIdentityCard.Name = "colIdentityCard";
            this.colIdentityCard.Visible = true;
            this.colIdentityCard.VisibleIndex = 4;
            this.colIdentityCard.Width = 84;
            // 
            // colInsuranceNum
            // 
            this.colInsuranceNum.FieldName = "InsuranceNum";
            this.colInsuranceNum.Name = "colInsuranceNum";
            // 
            // colGender
            // 
            this.colGender.FieldName = "Gender";
            this.colGender.Name = "colGender";
            // 
            // colMaritalState
            // 
            this.colMaritalState.FieldName = "MaritalState";
            this.colMaritalState.Name = "colMaritalState";
            // 
            // colReligion
            // 
            this.colReligion.FieldName = "Religion";
            this.colReligion.Name = "colReligion";
            // 
            // colBirthDate
            // 
            this.colBirthDate.FieldName = "BirthDate";
            this.colBirthDate.Name = "colBirthDate";
            // 
            // colStartDate
            // 
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.Name = "colStartDate";
            // 
            // colEndDate
            // 
            this.colEndDate.FieldName = "EndDate";
            this.colEndDate.Name = "colEndDate";
            // 
            // colBankAccountNum
            // 
            this.colBankAccountNum.FieldName = "BankAccountNum";
            this.colBankAccountNum.Name = "colBankAccountNum";
            // 
            // colBankId
            // 
            this.colBankId.FieldName = "BankId";
            this.colBankId.Name = "colBankId";
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            // 
            // colMob
            // 
            this.colMob.FieldName = "Mob";
            this.colMob.Name = "colMob";
            this.colMob.Visible = true;
            this.colMob.VisibleIndex = 6;
            this.colMob.Width = 107;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            // 
            // colCountryId
            // 
            this.colCountryId.FieldName = "CountryId";
            this.colCountryId.Name = "colCountryId";
            // 
            // colCityId
            // 
            this.colCityId.FieldName = "CityId";
            this.colCityId.Name = "colCityId";
            // 
            // colIsRetired
            // 
            this.colIsRetired.FieldName = "IsRetired";
            this.colIsRetired.Name = "colIsRetired";
            this.colIsRetired.OptionsColumn.ReadOnly = true;
            // 
            // colBank
            // 
            this.colBank.FieldName = "Bank";
            this.colBank.Name = "colBank";
            // 
            // colCountry
            // 
            this.colCountry.FieldName = "Country";
            this.colCountry.Name = "colCountry";
            // 
            // colCity
            // 
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 3;
            this.colName.Width = 190;
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
            this.colReferenceNum.Visible = true;
            this.colReferenceNum.VisibleIndex = 2;
            this.colReferenceNum.Width = 83;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            // 
            // colGroupId
            // 
            this.colGroupId.FieldName = "GroupId";
            this.colGroupId.Name = "colGroupId";
            // 
            // colSuspended
            // 
            this.colSuspended.FieldName = "Suspended";
            this.colSuspended.Name = "colSuspended";
            // 
            // colAccountGroup
            // 
            this.colAccountGroup.Caption = "Group Full name";
            this.colAccountGroup.FieldName = "AccountGroup.FullName";
            this.colAccountGroup.Name = "colAccountGroup";
            this.colAccountGroup.Visible = true;
            this.colAccountGroup.VisibleIndex = 5;
            this.colAccountGroup.Width = 121;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 1;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.FieldName = "CreatedBy";
            this.colCreatedBy.Name = "colCreatedBy";
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.FieldName = "CreatedAt";
            this.colCreatedAt.Name = "colCreatedAt";
            // 
            // colModifiedBy
            // 
            this.colModifiedBy.FieldName = "ModifiedBy";
            this.colModifiedBy.Name = "colModifiedBy";
            // 
            // colModifiedAt
            // 
            this.colModifiedAt.FieldName = "ModifiedAt";
            this.colModifiedAt.Name = "colModifiedAt";
            // 
            // colWFStatus
            // 
            this.colWFStatus.FieldName = "WFStatus";
            this.colWFStatus.Name = "colWFStatus";
            this.colWFStatus.Visible = true;
            this.colWFStatus.VisibleIndex = 0;
            // 
            // EmployeeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(766, 585);
            this.Controls.Add(this.employeeGC);
            this.Name = "EmployeeFrm";
            this.Controls.SetChildIndex(this.employeeGC, 0);
            ((System.ComponentModel.ISupportInitialize)(this.employeeGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GUI.Grid.GridCtrlBase employeeGC;
        private GUI.Grid.GridViewBase employeeGV;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdentityCard;
        private DevExpress.XtraGrid.Columns.GridColumn colInsuranceNum;
        private DevExpress.XtraGrid.Columns.GridColumn colGender;
        private DevExpress.XtraGrid.Columns.GridColumn colMaritalState;
        private DevExpress.XtraGrid.Columns.GridColumn colReligion;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthDate;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colBankAccountNum;
        private DevExpress.XtraGrid.Columns.GridColumn colBankId;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colMob;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryId;
        private DevExpress.XtraGrid.Columns.GridColumn colCityId;
        private DevExpress.XtraGrid.Columns.GridColumn colIsRetired;
        private DevExpress.XtraGrid.Columns.GridColumn colBank;
        private DevExpress.XtraGrid.Columns.GridColumn colCountry;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDisplayNum;
        private DevExpress.XtraGrid.Columns.GridColumn colReferenceNum;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupId;
        private DevExpress.XtraGrid.Columns.GridColumn colSuspended;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colWFStatus;
    }
}
