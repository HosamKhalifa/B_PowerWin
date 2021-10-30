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
            this.sequGC = new B_PowerWin.GUI.Grid.GridCtrlBase();
            this.sequGV = new B_PowerWin.GUI.Grid.GridViewBase();
            this.sequBS = new System.Windows.Forms.BindingSource();
            this.colSequNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSequName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.sequGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // sequGC
            // 
            this.sequGC.DataSource = this.sequBS;
            this.sequGC.dbContext = null;
            this.sequGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sequGC.Location = new System.Drawing.Point(0, 31);
            this.sequGC.MainView = this.sequGV;
            this.sequGC.MenuManager = this.barManager1;
            this.sequGC.Name = "sequGC";
            this.sequGC.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.sequGC.Size = new System.Drawing.Size(518, 359);
            this.sequGC.TabIndex = 4;
            this.sequGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.sequGV});
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
            this.sequGV.GridControl = this.sequGC;
            this.sequGV.GridViewEditMode = B_PowerWin.GUI.Grid.GridViewEditModeEnum.FormEdit;
            this.sequGV.Name = "sequGV";
            // 
            // sequBS
            // 
            this.sequBS.DataSource = typeof(B_PowerWin.DB.SysSequence);
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
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // SysSequenceSetupFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 413);
            this.Controls.Add(this.sequGC);
            this.Name = "SysSequenceSetupFrm";
            this.Text = "SysSequenceSetupFrm";
            this.Controls.SetChildIndex(this.sequGC, 0);
            ((System.ComponentModel.ISupportInitialize)(this.sequGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
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
    }
}