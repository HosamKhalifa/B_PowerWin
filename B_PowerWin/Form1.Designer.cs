namespace B_PowerWin
{
    partial class Form1
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
            this.usersBS = new System.Windows.Forms.BindingSource();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.secPrincipalUsersBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserKey = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmplId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPwd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDefaultCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastUserJob = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEffectiveFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEffectiveTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrincipalId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrincipalName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.testSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.usersBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secPrincipalUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.secPrincipalUsersBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(258, 145);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 200);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // secPrincipalUsersBindingSource
            // 
            this.secPrincipalUsersBindingSource.DataSource = typeof(B_PowerWin.DB.SecPrincipalUser);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserKey,
            this.colEmplId,
            this.colPwd,
            this.colUserImage,
            this.colDefaultCompany,
            this.colLastUserJob,
            this.colEffectiveFrom,
            this.colEffectiveTo,
            this.colPrincipalId,
            this.colPrincipalName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colUserKey
            // 
            this.colUserKey.FieldName = "UserKey";
            this.colUserKey.Name = "colUserKey";
            this.colUserKey.Visible = true;
            this.colUserKey.VisibleIndex = 0;
            // 
            // colEmplId
            // 
            this.colEmplId.FieldName = "EmplId";
            this.colEmplId.Name = "colEmplId";
            this.colEmplId.Visible = true;
            this.colEmplId.VisibleIndex = 1;
            // 
            // colPwd
            // 
            this.colPwd.FieldName = "Pwd";
            this.colPwd.Name = "colPwd";
            this.colPwd.Visible = true;
            this.colPwd.VisibleIndex = 2;
            // 
            // colUserImage
            // 
            this.colUserImage.FieldName = "UserImage";
            this.colUserImage.Name = "colUserImage";
            this.colUserImage.Visible = true;
            this.colUserImage.VisibleIndex = 3;
            // 
            // colDefaultCompany
            // 
            this.colDefaultCompany.FieldName = "DefaultCompany";
            this.colDefaultCompany.Name = "colDefaultCompany";
            this.colDefaultCompany.Visible = true;
            this.colDefaultCompany.VisibleIndex = 4;
            // 
            // colLastUserJob
            // 
            this.colLastUserJob.FieldName = "LastUserJob";
            this.colLastUserJob.Name = "colLastUserJob";
            this.colLastUserJob.Visible = true;
            this.colLastUserJob.VisibleIndex = 5;
            // 
            // colEffectiveFrom
            // 
            this.colEffectiveFrom.FieldName = "EffectiveFrom";
            this.colEffectiveFrom.Name = "colEffectiveFrom";
            this.colEffectiveFrom.Visible = true;
            this.colEffectiveFrom.VisibleIndex = 6;
            // 
            // colEffectiveTo
            // 
            this.colEffectiveTo.FieldName = "EffectiveTo";
            this.colEffectiveTo.Name = "colEffectiveTo";
            this.colEffectiveTo.Visible = true;
            this.colEffectiveTo.VisibleIndex = 7;
            // 
            // colPrincipalId
            // 
            this.colPrincipalId.FieldName = "PrincipalId";
            this.colPrincipalId.Name = "colPrincipalId";
            this.colPrincipalId.Visible = true;
            this.colPrincipalId.VisibleIndex = 8;
            // 
            // colPrincipalName
            // 
            this.colPrincipalName.FieldName = "PrincipalName";
            this.colPrincipalName.Name = "colPrincipalName";
            this.colPrincipalName.Visible = true;
            this.colPrincipalName.VisibleIndex = 9;
            // 
            // testSimpleButton
            // 
            this.testSimpleButton.Location = new System.Drawing.Point(705, 111);
            this.testSimpleButton.Name = "testSimpleButton";
            this.testSimpleButton.Size = new System.Drawing.Size(75, 23);
            this.testSimpleButton.TabIndex = 1;
            this.testSimpleButton.Text = "Test";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(220, 34);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 522);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.testSimpleButton);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.usersBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secPrincipalUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource usersBS;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource secPrincipalUsersBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colUserKey;
        private DevExpress.XtraGrid.Columns.GridColumn colEmplId;
        private DevExpress.XtraGrid.Columns.GridColumn colPwd;
        private DevExpress.XtraGrid.Columns.GridColumn colUserImage;
        private DevExpress.XtraGrid.Columns.GridColumn colDefaultCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colLastUserJob;
        private DevExpress.XtraGrid.Columns.GridColumn colEffectiveFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colEffectiveTo;
        private DevExpress.XtraGrid.Columns.GridColumn colPrincipalId;
        private DevExpress.XtraGrid.Columns.GridColumn colPrincipalName;
        private DevExpress.XtraEditors.SimpleButton testSimpleButton;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}

