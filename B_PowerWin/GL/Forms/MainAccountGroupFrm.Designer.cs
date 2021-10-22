namespace B_PowerWin.GL.Forms
{
    partial class MainAccountGroupFrm
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
            this.mainAccountGroupGC = new B_PowerWin.GUI.Grid.GridCtrlBase();
            this.mainAccountGroupGV = new B_PowerWin.GUI.Grid.GridViewBase();
            this.colGroupNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMainAccountType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mainAccountGroupBindingSource = new System.Windows.Forms.BindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountGroupGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountGroupGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountGroupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainAccountGroupGC
            // 
            this.mainAccountGroupGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainAccountGroupGC.Location = new System.Drawing.Point(0, 0);
            this.mainAccountGroupGC.MainView = this.mainAccountGroupGV;
            this.mainAccountGroupGC.Name = "mainAccountGroupGC";
            this.mainAccountGroupGC.Size = new System.Drawing.Size(707, 386);
            this.mainAccountGroupGC.TabIndex = 0;
            this.mainAccountGroupGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.mainAccountGroupGV});
            // 
            // mainAccountGroupGV
            // 
            this.mainAccountGroupGV.BaseTypeEnum = B_PowerWin.DB.BaseTypeEnum.MainAccountGroup;
            this.mainAccountGroupGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGroupNum,
            this.colGroupName,
            this.colMainAccountType,
            this.colCreatedBy,
            this.colCreatedAt,
            this.colModifiedBy,
            this.colModifiedAt});
            this.mainAccountGroupGV.GridControl = this.mainAccountGroupGC;
            this.mainAccountGroupGV.Name = "mainAccountGroupGV";
            // 
            // colGroupNum
            // 
            this.colGroupNum.FieldName = "GroupNum";
            this.colGroupNum.Name = "colGroupNum";
            this.colGroupNum.Visible = true;
            this.colGroupNum.VisibleIndex = 0;
            // 
            // colGroupName
            // 
            this.colGroupName.FieldName = "GroupName";
            this.colGroupName.Name = "colGroupName";
            this.colGroupName.Visible = true;
            this.colGroupName.VisibleIndex = 1;
            // 
            // colMainAccountType
            // 
            this.colMainAccountType.FieldName = "MainAccountType";
            this.colMainAccountType.Name = "colMainAccountType";
            this.colMainAccountType.Visible = true;
            this.colMainAccountType.VisibleIndex = 2;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.FieldName = "CreatedBy";
            this.colCreatedBy.Name = "colCreatedBy";
            this.colCreatedBy.Visible = true;
            this.colCreatedBy.VisibleIndex = 3;
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.FieldName = "CreatedAt";
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.Visible = true;
            this.colCreatedAt.VisibleIndex = 4;
            // 
            // colModifiedBy
            // 
            this.colModifiedBy.FieldName = "ModifiedBy";
            this.colModifiedBy.Name = "colModifiedBy";
            this.colModifiedBy.Visible = true;
            this.colModifiedBy.VisibleIndex = 5;
            // 
            // colModifiedAt
            // 
            this.colModifiedAt.FieldName = "ModifiedAt";
            this.colModifiedAt.Name = "colModifiedAt";
            this.colModifiedAt.Visible = true;
            this.colModifiedAt.VisibleIndex = 6;
            // 
            // mainAccountGroupBindingSource
            // 
            this.mainAccountGroupBindingSource.DataSource = typeof(B_PowerWin.DB.MainAccountGroup);
            // 
            // MainAccountGroupFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(707, 386);
            this.Controls.Add(this.mainAccountGroupGC);
            this.Name = "MainAccountGroupFrm";
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountGroupGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountGroupGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountGroupBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GUI.Grid.GridCtrlBase mainAccountGroupGC;
        private GUI.Grid.GridViewBase mainAccountGroupGV;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupNum;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupName;
        private DevExpress.XtraGrid.Columns.GridColumn colMainAccountType;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedAt;
        private System.Windows.Forms.BindingSource mainAccountGroupBindingSource;
    }
}
