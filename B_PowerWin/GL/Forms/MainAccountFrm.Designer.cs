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
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
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
            this.repositoryItemLookUpEdit1});
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
            this.mainAccountGV.GridControl = this.mainAccountGC;
            this.mainAccountGV.GridViewEditMode = B_PowerWin.GUI.Grid.GridViewEditModeEnum.FormEdit;
            this.mainAccountGV.Name = "mainAccountGV";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // MainAccountFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(766, 585);
            this.Controls.Add(this.mainAccountGC);
            this.Name = "MainAccountFrm";
            this.Text = "Main account";
            this.Controls.SetChildIndex(this.mainAccountGC, 0);
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GUI.Grid.GridCtrlBase mainAccountGC;
        private GUI.Grid.GridViewBase mainAccountGV;
        private System.Windows.Forms.BindingSource mainAccountBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    }
}
