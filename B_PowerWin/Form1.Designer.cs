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
            this.components = new System.ComponentModel.Container();
            this.usersBS = new System.Windows.Forms.BindingSource(this.components);
            this.secPrincipalUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.usersBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secPrincipalUsersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // secPrincipalUsersBindingSource
            // 
            this.secPrincipalUsersBindingSource.DataSource = typeof(B_PowerWin.DB.SecPrincipalUser);
            // 
            // testSimpleButton
            // 
            this.testSimpleButton.Location = new System.Drawing.Point(12, 41);
            this.testSimpleButton.Name = "testSimpleButton";
            this.testSimpleButton.Size = new System.Drawing.Size(75, 23);
            this.testSimpleButton.TabIndex = 1;
            this.testSimpleButton.Text = "Test";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 12);
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
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.usersBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secPrincipalUsersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource usersBS;
        private System.Windows.Forms.BindingSource secPrincipalUsersBindingSource;
        private DevExpress.XtraEditors.SimpleButton testSimpleButton;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}

