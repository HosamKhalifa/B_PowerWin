namespace B_PowerWin.Invent
{
    partial class InventStoreFrm
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
            this.inventStoreBS = new System.Windows.Forms.BindingSource();
            this.inventStoreGC = new B_PowerWin.GUI.Grid.GridCtrlBase();
            this.inventStoreGv = new B_PowerWin.GUI.Grid.GridViewBase();
            ((System.ComponentModel.ISupportInitialize)(this.inventStoreBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventStoreGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventStoreGv)).BeginInit();
            this.SuspendLayout();
            // 
            // inventStoreBS
            // 
            this.inventStoreBS.DataSource = typeof(B_PowerWin.DB.InventStore);
            // 
            // inventStoreGC
            // 
            this.inventStoreGC.DataSource = this.inventStoreBS;
            this.inventStoreGC.dbContext = null;
            this.inventStoreGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventStoreGC.Location = new System.Drawing.Point(0, 31);
            this.inventStoreGC.MainView = this.inventStoreGv;
            this.inventStoreGC.MenuManager = this.barManager1;
            this.inventStoreGC.Name = "inventStoreGC";
            this.inventStoreGC.Size = new System.Drawing.Size(766, 531);
            this.inventStoreGC.TabIndex = 4;
            this.inventStoreGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.inventStoreGv});
            // 
            // inventStoreGv
            // 
            this.inventStoreGv.BaseTypeEnum = B_PowerWin.DB.BaseTypeEnum.InventStore;
            this.inventStoreGv.GridControl = this.inventStoreGC;
            this.inventStoreGv.GridViewEditMode = B_PowerWin.GUI.Grid.GridViewEditModeEnum.FormEdit;
            this.inventStoreGv.Name = "inventStoreGv";
            // 
            // InventStoreFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(766, 585);
            this.Controls.Add(this.inventStoreGC);
            this.Name = "InventStoreFrm";
            this.Controls.SetChildIndex(this.inventStoreGC, 0);
            ((System.ComponentModel.ISupportInitialize)(this.inventStoreBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventStoreGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventStoreGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource inventStoreBS;
        private GUI.Grid.GridCtrlBase inventStoreGC;
        private GUI.Grid.GridViewBase inventStoreGv;
    }
}
