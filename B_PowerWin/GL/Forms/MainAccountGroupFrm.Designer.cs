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
            this.mainAccountGroupBindingSource = new System.Windows.Forms.BindingSource();
            this.mainAccountGroupGC = new B_PowerWin.GUI.Grid.GridCtrlBase();
            this.mainAccountGroupGV = new B_PowerWin.GUI.Grid.GridViewBase();
            this.saveLayoutBI = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountGroupGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountGroupGV)).BeginInit();
            this.SuspendLayout();
            // 
            // mainAccountGroupBindingSource
            // 
            this.mainAccountGroupBindingSource.DataSource = typeof(B_PowerWin.DB.MainAccountGroup);
            // 
            // mainAccountGroupGC
            // 
            this.mainAccountGroupGC.DataSource = this.mainAccountGroupBindingSource;
            this.mainAccountGroupGC.dbContext = null;
            this.mainAccountGroupGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainAccountGroupGC.Location = new System.Drawing.Point(0, 31);
            this.mainAccountGroupGC.MainView = this.mainAccountGroupGV;
            this.mainAccountGroupGC.MenuManager = this.barManager1;
            this.mainAccountGroupGC.Name = "mainAccountGroupGC";
            this.mainAccountGroupGC.Size = new System.Drawing.Size(766, 531);
            this.mainAccountGroupGC.TabIndex = 4;
            this.mainAccountGroupGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.mainAccountGroupGV});
            // 
            // mainAccountGroupGV
            // 
            this.mainAccountGroupGV.BaseTypeEnum = B_PowerWin.DB.BaseTypeEnum.MainAccountGroup;
            this.mainAccountGroupGV.GridControl = this.mainAccountGroupGC;
            this.mainAccountGroupGV.GridViewEditMode = B_PowerWin.GUI.Grid.GridViewEditModeEnum.FormEdit;
            this.mainAccountGroupGV.Name = "mainAccountGroupGV";
            // 
            // saveLayoutBI
            // 
            this.saveLayoutBI.Caption = "SaveLayout";
            this.saveLayoutBI.Id = 2;
            this.saveLayoutBI.Name = "saveLayoutBI";
            // 
            // MainAccountGroupFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(766, 585);
            this.Controls.Add(this.mainAccountGroupGC);
            this.Name = "MainAccountGroupFrm";
            this.Controls.SetChildIndex(this.mainAccountGroupGC, 0);
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountGroupGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAccountGroupGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource mainAccountGroupBindingSource;
        private GUI.Grid.GridCtrlBase mainAccountGroupGC;
        private GUI.Grid.GridViewBase mainAccountGroupGV;
        private DevExpress.XtraBars.BarButtonItem saveLayoutBI;
    }
}
