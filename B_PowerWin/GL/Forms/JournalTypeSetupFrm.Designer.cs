namespace B_PowerWin.GL.Forms
{
    partial class JournalTypeSetupFrm
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
            this.jourTypeGC = new B_PowerWin.GUI.Grid.GridCtrlBase();
            this.jourTypeGV = new B_PowerWin.GUI.Grid.GridViewBase();
            this.jourTypeBS = new System.Windows.Forms.BindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.jourTypeGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jourTypeGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jourTypeBS)).BeginInit();
            this.SuspendLayout();
            // 
            // jourTypeGC
            // 
            this.jourTypeGC.dbContext = null;
            this.jourTypeGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jourTypeGC.Location = new System.Drawing.Point(0, 31);
            this.jourTypeGC.MainView = this.jourTypeGV;
            this.jourTypeGC.MenuManager = this.barManager1;
            this.jourTypeGC.Name = "jourTypeGC";
            this.jourTypeGC.Size = new System.Drawing.Size(766, 531);
            this.jourTypeGC.TabIndex = 4;
            this.jourTypeGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.jourTypeGV});
            // 
            // jourTypeGV
            // 
            this.jourTypeGV.BaseTypeEnum = B_PowerWin.DB.BaseTypeEnum.JournalType;
            this.jourTypeGV.GridControl = this.jourTypeGC;
            this.jourTypeGV.GridViewEditMode = B_PowerWin.GUI.Grid.GridViewEditModeEnum.FormEdit;
            this.jourTypeGV.Name = "jourTypeGV";
            // 
            // jourTypeBS
            // 
            this.jourTypeBS.DataSource = typeof(B_PowerWin.DB.JournalType);
            // 
            // JournalTypeSetupFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(766, 585);
            this.Controls.Add(this.jourTypeGC);
            this.Name = "JournalTypeSetupFrm";
            this.Controls.SetChildIndex(this.jourTypeGC, 0);
            ((System.ComponentModel.ISupportInitialize)(this.jourTypeGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jourTypeGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jourTypeBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GUI.Grid.GridCtrlBase jourTypeGC;
        private GUI.Grid.GridViewBase jourTypeGV;
        private System.Windows.Forms.BindingSource jourTypeBS;
    }
}
