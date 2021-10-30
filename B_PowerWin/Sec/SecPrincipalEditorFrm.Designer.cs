namespace B_PowerWin.Sec
{
    partial class SecPrincipalEditorFrm
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
            this.membersGC = new B_PowerWin.GUI.Grid.GridCtrlBase();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membersGV = new B_PowerWin.GUI.Grid.GridViewBase();
            this.colRolePrincipalId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMemberPrincipalId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MemeberLookup = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.secPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colAccessType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEffectiveFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEffectiveTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMemberRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRolePrincipalName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.membersGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemeberLookup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secPrincipalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // membersGC
            // 
            this.membersGC.DataSource = this.membersBindingSource;
            this.membersGC.dbContext = null;
            this.membersGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.membersGC.Location = new System.Drawing.Point(0, 31);
            this.membersGC.MainView = this.membersGV;
            this.membersGC.MenuManager = this.barManager1;
            this.membersGC.Name = "membersGC";
            this.membersGC.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.MemeberLookup});
            this.membersGC.Size = new System.Drawing.Size(766, 531);
            this.membersGC.TabIndex = 4;
            this.membersGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.membersGV});
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataSource = typeof(B_PowerWin.DB.SecPrincipalRoleMem);
            // 
            // membersGV
            // 
            this.membersGV.BaseTypeEnum = B_PowerWin.DB.BaseTypeEnum.SecPrincipalRoleMem;
            this.membersGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRolePrincipalId,
            this.colMemberPrincipalId,
            this.colAccessType,
            this.colEffectiveFrom,
            this.colEffectiveTo,
            this.colMemberRef,
            this.colCreatedBy,
            this.colCreatedAt,
            this.colModifiedBy,
            this.colModifiedAt,
            this.colRolePrincipalName});
            this.membersGV.GridControl = this.membersGC;
            this.membersGV.GridViewEditMode = B_PowerWin.GUI.Grid.GridViewEditModeEnum.FormEdit;
            this.membersGV.Name = "membersGV";
            // 
            // colRolePrincipalId
            // 
            this.colRolePrincipalId.FieldName = "RolePrincipalId";
            this.colRolePrincipalId.Name = "colRolePrincipalId";
            // 
            // colMemberPrincipalId
            // 
            this.colMemberPrincipalId.ColumnEdit = this.MemeberLookup;
            this.colMemberPrincipalId.FieldName = "MemberPrincipalId";
            this.colMemberPrincipalId.Name = "colMemberPrincipalId";
            this.colMemberPrincipalId.Visible = true;
            this.colMemberPrincipalId.VisibleIndex = 1;
            this.colMemberPrincipalId.Width = 241;
            // 
            // MemeberLookup
            // 
            this.MemeberLookup.AutoHeight = false;
            this.MemeberLookup.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MemeberLookup.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrincipalId", "Principal Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrincipalName", "Principal Name", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RoleType", "Role Type", 10, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
            this.MemeberLookup.DataSource = this.secPrincipalBindingSource;
            this.MemeberLookup.DisplayMember = "PrincipalFullName";
            this.MemeberLookup.KeyMember = "PrincipalId";
            this.MemeberLookup.Name = "MemeberLookup";
            this.MemeberLookup.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.MemeberLookup.ValueMember = "PrincipalId";
            // 
            // secPrincipalBindingSource
            // 
            this.secPrincipalBindingSource.DataSource = typeof(B_PowerWin.DB.SecPrincipal);
            // 
            // colAccessType
            // 
            this.colAccessType.FieldName = "AccessType";
            this.colAccessType.Name = "colAccessType";
            this.colAccessType.Visible = true;
            this.colAccessType.VisibleIndex = 2;
            this.colAccessType.Width = 99;
            // 
            // colEffectiveFrom
            // 
            this.colEffectiveFrom.FieldName = "EffectiveFrom";
            this.colEffectiveFrom.Name = "colEffectiveFrom";
            this.colEffectiveFrom.Visible = true;
            this.colEffectiveFrom.VisibleIndex = 3;
            this.colEffectiveFrom.Width = 99;
            // 
            // colEffectiveTo
            // 
            this.colEffectiveTo.FieldName = "EffectiveTo";
            this.colEffectiveTo.Name = "colEffectiveTo";
            this.colEffectiveTo.Visible = true;
            this.colEffectiveTo.VisibleIndex = 4;
            this.colEffectiveTo.Width = 99;
            // 
            // colMemberRef
            // 
            this.colMemberRef.FieldName = "MemberRef";
            this.colMemberRef.Name = "colMemberRef";
            this.colMemberRef.Width = 99;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.FieldName = "CreatedBy";
            this.colCreatedBy.Name = "colCreatedBy";
            this.colCreatedBy.Visible = true;
            this.colCreatedBy.VisibleIndex = 5;
            this.colCreatedBy.Width = 99;
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.FieldName = "CreatedAt";
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.Visible = true;
            this.colCreatedAt.VisibleIndex = 6;
            this.colCreatedAt.Width = 99;
            // 
            // colModifiedBy
            // 
            this.colModifiedBy.FieldName = "ModifiedBy";
            this.colModifiedBy.Name = "colModifiedBy";
            this.colModifiedBy.Visible = true;
            this.colModifiedBy.VisibleIndex = 7;
            this.colModifiedBy.Width = 99;
            // 
            // colModifiedAt
            // 
            this.colModifiedAt.FieldName = "ModifiedAt";
            this.colModifiedAt.Name = "colModifiedAt";
            this.colModifiedAt.Visible = true;
            this.colModifiedAt.VisibleIndex = 8;
            this.colModifiedAt.Width = 103;
            // 
            // colRolePrincipalName
            // 
            this.colRolePrincipalName.Caption = "Role Name";
            this.colRolePrincipalName.FieldName = "RoleRef.PrincipalFullName";
            this.colRolePrincipalName.Name = "colRolePrincipalName";
            this.colRolePrincipalName.Visible = true;
            this.colRolePrincipalName.VisibleIndex = 0;
            this.colRolePrincipalName.Width = 115;
            // 
            // SecPrincipalEditorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(766, 585);
            this.Controls.Add(this.membersGC);
            this.Name = "SecPrincipalEditorFrm";
            this.Controls.SetChildIndex(this.membersGC, 0);
            ((System.ComponentModel.ISupportInitialize)(this.membersGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemeberLookup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secPrincipalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GUI.Grid.GridCtrlBase membersGC;
        private GUI.Grid.GridViewBase membersGV;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colRolePrincipalId;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberPrincipalId;
        private DevExpress.XtraGrid.Columns.GridColumn colAccessType;
        private DevExpress.XtraGrid.Columns.GridColumn colEffectiveFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colEffectiveTo;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberRef;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedAt;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit MemeberLookup;
        private System.Windows.Forms.BindingSource secPrincipalBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colRolePrincipalName;
    }
}
