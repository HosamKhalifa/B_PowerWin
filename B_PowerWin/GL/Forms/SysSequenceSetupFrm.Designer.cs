namespace B_PowerWin.GL.Forms
{
    partial class SysSequenceSetupFrm
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
            this.sequGC = new B_PowerWin.GUI.Grid.GridCtrlBase();
            this.sequBS = new System.Windows.Forms.BindingSource(this.components);
            this.sequGV = new B_PowerWin.GUI.Grid.GridViewBase();
            this.colSequNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSequName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colSysSequRecycle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSequValueStringFormat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastErrorMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaseType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParnetId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sequNavPane = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.sequSetupPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.accountBaseSequencePage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.sequAccountRefGC = new B_PowerWin.GUI.Grid.GridCtrlBase();
            this.sequAccountRefGV = new B_PowerWin.GUI.Grid.GridViewBase();
            this.baseTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colBaseTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaseTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecordTypeType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSysSequenceId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSysSequence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sequLookup = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.sequGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequNavPane)).BeginInit();
            this.sequNavPane.SuspendLayout();
            this.sequSetupPage.SuspendLayout();
            this.accountBaseSequencePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sequAccountRefGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequAccountRefGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequLookup)).BeginInit();
            this.SuspendLayout();
            // 
            // sequGC
            // 
            this.sequGC.DataSource = this.sequBS;
            this.sequGC.dbContext = null;
            this.sequGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sequGC.Location = new System.Drawing.Point(0, 0);
            this.sequGC.MainView = this.sequGV;
            this.sequGC.MenuManager = this.barManager1;
            this.sequGC.Name = "sequGC";
            this.sequGC.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.sequGC.Size = new System.Drawing.Size(700, 299);
            this.sequGC.TabIndex = 4;
            this.sequGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.sequGV});
            // 
            // sequBS
            // 
            this.sequBS.DataSource = typeof(B_PowerWin.DB.SysSequence);
            // 
            // sequGV
            // 
            this.sequGV.BaseTypeEnum = B_PowerWin.DB.BaseTypeEnum.SysSequence;
            this.sequGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSequNum,
            this.colSequName,
            this.colStartDate,
            this.colSysSequRecycle,
            this.colStartValue,
            this.colSequValueStringFormat,
            this.colLastErrorMessage,
            this.colId,
            this.colCreatedBy,
            this.colCreatedAt,
            this.colModifiedBy,
            this.colModifiedAt,
            this.colBaseType,
            this.colParnetId});
            this.sequGV.EnableAutoFormat = true;
            this.sequGV.GridControl = this.sequGC;
            this.sequGV.GridViewEditMode = B_PowerWin.GUI.Grid.GridViewEditModeEnum.FormEdit;
            this.sequGV.Name = "sequGV";
            // 
            // colSequNum
            // 
            this.colSequNum.FieldName = "SequNum";
            this.colSequNum.Name = "colSequNum";
            this.colSequNum.Visible = true;
            this.colSequNum.VisibleIndex = 0;
            // 
            // colSequName
            // 
            this.colSequName.FieldName = "SequName";
            this.colSequName.Name = "colSequName";
            this.colSequName.Visible = true;
            this.colSequName.VisibleIndex = 1;
            // 
            // colStartDate
            // 
            this.colStartDate.ColumnEdit = this.repositoryItemDateEdit1;
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 2;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // colSysSequRecycle
            // 
            this.colSysSequRecycle.FieldName = "SysSequRecycle";
            this.colSysSequRecycle.Name = "colSysSequRecycle";
            this.colSysSequRecycle.Visible = true;
            this.colSysSequRecycle.VisibleIndex = 3;
            // 
            // colStartValue
            // 
            this.colStartValue.FieldName = "StartValue";
            this.colStartValue.Name = "colStartValue";
            this.colStartValue.Visible = true;
            this.colStartValue.VisibleIndex = 4;
            // 
            // colSequValueStringFormat
            // 
            this.colSequValueStringFormat.FieldName = "SequValueStringFormat";
            this.colSequValueStringFormat.Name = "colSequValueStringFormat";
            this.colSequValueStringFormat.Visible = true;
            this.colSequValueStringFormat.VisibleIndex = 5;
            // 
            // colLastErrorMessage
            // 
            this.colLastErrorMessage.FieldName = "LastErrorMessage";
            this.colLastErrorMessage.Name = "colLastErrorMessage";
            this.colLastErrorMessage.Visible = true;
            this.colLastErrorMessage.VisibleIndex = 6;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 7;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.FieldName = "CreatedBy";
            this.colCreatedBy.Name = "colCreatedBy";
            this.colCreatedBy.Visible = true;
            this.colCreatedBy.VisibleIndex = 8;
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.FieldName = "CreatedAt";
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.Visible = true;
            this.colCreatedAt.VisibleIndex = 9;
            // 
            // colModifiedBy
            // 
            this.colModifiedBy.FieldName = "ModifiedBy";
            this.colModifiedBy.Name = "colModifiedBy";
            this.colModifiedBy.Visible = true;
            this.colModifiedBy.VisibleIndex = 10;
            // 
            // colModifiedAt
            // 
            this.colModifiedAt.FieldName = "ModifiedAt";
            this.colModifiedAt.Name = "colModifiedAt";
            this.colModifiedAt.Visible = true;
            this.colModifiedAt.VisibleIndex = 11;
            // 
            // colBaseType
            // 
            this.colBaseType.FieldName = "BaseType";
            this.colBaseType.Name = "colBaseType";
            this.colBaseType.Visible = true;
            this.colBaseType.VisibleIndex = 12;
            // 
            // colParnetId
            // 
            this.colParnetId.FieldName = "ParnetId";
            this.colParnetId.Name = "colParnetId";
            this.colParnetId.Visible = true;
            this.colParnetId.VisibleIndex = 13;
            // 
            // sequNavPane
            // 
            this.sequNavPane.Controls.Add(this.sequSetupPage);
            this.sequNavPane.Controls.Add(this.accountBaseSequencePage);
            this.sequNavPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sequNavPane.Location = new System.Drawing.Point(0, 31);
            this.sequNavPane.Name = "sequNavPane";
            this.sequNavPane.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.sequSetupPage,
            this.accountBaseSequencePage});
            this.sequNavPane.RegularSize = new System.Drawing.Size(853, 359);
            this.sequNavPane.SelectedPage = this.sequSetupPage;
            this.sequNavPane.Size = new System.Drawing.Size(853, 359);
            this.sequNavPane.TabIndex = 5;
            this.sequNavPane.Text = "navigationPane1";
            // 
            // sequSetupPage
            // 
            this.sequSetupPage.Caption = "Setup sequence";
            this.sequSetupPage.Controls.Add(this.sequGC);
            this.sequSetupPage.Name = "sequSetupPage";
            this.sequSetupPage.Size = new System.Drawing.Size(700, 299);
            // 
            // accountBaseSequencePage
            // 
            this.accountBaseSequencePage.Caption = "Account base sequences";
            this.accountBaseSequencePage.Controls.Add(this.sequAccountRefGC);
            this.accountBaseSequencePage.Name = "accountBaseSequencePage";
            this.accountBaseSequencePage.Size = new System.Drawing.Size(700, 299);
            // 
            // sequAccountRefGC
            // 
            this.sequAccountRefGC.DataSource = this.baseTypeBindingSource;
            this.sequAccountRefGC.dbContext = null;
            this.sequAccountRefGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sequAccountRefGC.Location = new System.Drawing.Point(0, 0);
            this.sequAccountRefGC.MainView = this.sequAccountRefGV;
            this.sequAccountRefGC.MenuManager = this.barManager1;
            this.sequAccountRefGC.Name = "sequAccountRefGC";
            this.sequAccountRefGC.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.sequLookup});
            this.sequAccountRefGC.Size = new System.Drawing.Size(700, 299);
            this.sequAccountRefGC.TabIndex = 0;
            this.sequAccountRefGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.sequAccountRefGV});
            // 
            // sequAccountRefGV
            // 
            this.sequAccountRefGV.BaseTypeEnum = B_PowerWin.DB.BaseTypeEnum.None;
            this.sequAccountRefGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBaseTypeId,
            this.colBaseTypeName,
            this.colRecordTypeType,
            this.colSysSequenceId,
            this.colSysSequence});
            this.sequAccountRefGV.EnableAutoFormat = false;
            this.sequAccountRefGV.GridControl = this.sequAccountRefGC;
            this.sequAccountRefGV.GridViewEditMode = B_PowerWin.GUI.Grid.GridViewEditModeEnum.FormEdit;
            this.sequAccountRefGV.Name = "sequAccountRefGV";
            this.sequAccountRefGV.OptionsView.ColumnAutoWidth = false;
            // 
            // baseTypeBindingSource
            // 
            this.baseTypeBindingSource.DataSource = typeof(B_PowerWin.DB.BaseType);
            // 
            // colBaseTypeId
            // 
            this.colBaseTypeId.FieldName = "BaseTypeId";
            this.colBaseTypeId.Name = "colBaseTypeId";
            // 
            // colBaseTypeName
            // 
            this.colBaseTypeName.FieldName = "BaseTypeName";
            this.colBaseTypeName.Name = "colBaseTypeName";
            this.colBaseTypeName.Visible = true;
            this.colBaseTypeName.VisibleIndex = 0;
            this.colBaseTypeName.Width = 143;
            // 
            // colRecordTypeType
            // 
            this.colRecordTypeType.FieldName = "RecordTypeType";
            this.colRecordTypeType.Name = "colRecordTypeType";
            this.colRecordTypeType.Width = 97;
            // 
            // colSysSequenceId
            // 
            this.colSysSequenceId.ColumnEdit = this.sequLookup;
            this.colSysSequenceId.FieldName = "SysSequenceId";
            this.colSysSequenceId.Name = "colSysSequenceId";
            this.colSysSequenceId.Visible = true;
            this.colSysSequenceId.VisibleIndex = 1;
            this.colSysSequenceId.Width = 109;
            // 
            // colSysSequence
            // 
            this.colSysSequence.FieldName = "SysSequence.SequName";
            this.colSysSequence.Name = "colSysSequence";
            this.colSysSequence.Visible = true;
            this.colSysSequence.VisibleIndex = 2;
            this.colSysSequence.Width = 235;
            // 
            // sequLookup
            // 
            this.sequLookup.AutoHeight = false;
            this.sequLookup.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sequLookup.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SequNum", "Sequ Num", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SequName", "Sequ Name", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SysSequRecycle", "Sys Sequ Recycle", 10, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
            this.sequLookup.DataSource = this.sequBS;
            this.sequLookup.DisplayMember = "SequNum";
            this.sequLookup.KeyMember = "Id";
            this.sequLookup.Name = "sequLookup";
            this.sequLookup.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.sequLookup.ValueMember = "Id";
            // 
            // SysSequenceSetupFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 413);
            this.Controls.Add(this.sequNavPane);
            this.Name = "SysSequenceSetupFrm";
            this.Text = "SysSequenceSetupFrm";
            this.Controls.SetChildIndex(this.sequNavPane, 0);
            ((System.ComponentModel.ISupportInitialize)(this.sequGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequNavPane)).EndInit();
            this.sequNavPane.ResumeLayout(false);
            this.sequSetupPage.ResumeLayout(false);
            this.accountBaseSequencePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sequAccountRefGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequAccountRefGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequLookup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GUI.Grid.GridCtrlBase sequGC;
        private GUI.Grid.GridViewBase sequGV;
        private System.Windows.Forms.BindingSource sequBS;
        private DevExpress.XtraGrid.Columns.GridColumn colSequNum;
        private DevExpress.XtraGrid.Columns.GridColumn colSequName;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colSysSequRecycle;
        private DevExpress.XtraGrid.Columns.GridColumn colStartValue;
        private DevExpress.XtraGrid.Columns.GridColumn colSequValueStringFormat;
        private DevExpress.XtraGrid.Columns.GridColumn colLastErrorMessage;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseType;
        private DevExpress.XtraGrid.Columns.GridColumn colParnetId;
        private DevExpress.XtraBars.Navigation.NavigationPane sequNavPane;
        private DevExpress.XtraBars.Navigation.NavigationPage sequSetupPage;
        private DevExpress.XtraBars.Navigation.NavigationPage accountBaseSequencePage;
        private GUI.Grid.GridCtrlBase sequAccountRefGC;
        private System.Windows.Forms.BindingSource baseTypeBindingSource;
        private GUI.Grid.GridViewBase sequAccountRefGV;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colRecordTypeType;
        private DevExpress.XtraGrid.Columns.GridColumn colSysSequenceId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit sequLookup;
        private DevExpress.XtraGrid.Columns.GridColumn colSysSequence;
    }
}