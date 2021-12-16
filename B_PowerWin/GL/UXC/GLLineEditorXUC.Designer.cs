namespace B_PowerWin.GL.UXC
{
    partial class GLLineEditorXUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.debitFCCalc = new DevExpress.XtraEditors.CalcEdit();
            this.calcEdit2 = new DevExpress.XtraEditors.CalcEdit();
            this.mainLedgerActType = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.debitFCLbl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.creditFCLbl = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.offsetLedgerActType = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.mainPopup = new DevExpress.XtraEditors.PopupContainerEdit();
            this.mainPopupContainerControl = new DevExpress.XtraEditors.PopupContainerControl();
            this.offsetPopupContainerControl = new DevExpress.XtraEditors.PopupContainerControl();
            this.offsetPopup = new DevExpress.XtraEditors.PopupContainerEdit();
            this.offsetGLDimSelectXUC = new B_PowerWin.GL.UXC.GLDimSelectXUC();
            this.mainGLDimSelectXUC = new B_PowerWin.GL.UXC.GLDimSelectXUC();
            this.lineBS = new System.Windows.Forms.BindingSource(this.components);
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.debitFCCalc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainLedgerActType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetLedgerActType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPopup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPopupContainerControl)).BeginInit();
            this.mainPopupContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offsetPopupContainerControl)).BeginInit();
            this.offsetPopupContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offsetPopup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // debitFCCalc
            // 
            this.debitFCCalc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lineBS, "DebitFC", true));
            this.debitFCCalc.Location = new System.Drawing.Point(4, 19);
            this.debitFCCalc.Name = "debitFCCalc";
            this.debitFCCalc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.debitFCCalc.Size = new System.Drawing.Size(100, 20);
            this.debitFCCalc.TabIndex = 0;
            // 
            // calcEdit2
            // 
            this.calcEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lineBS, "CreditFC", true));
            this.calcEdit2.Location = new System.Drawing.Point(110, 19);
            this.calcEdit2.Name = "calcEdit2";
            this.calcEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcEdit2.Size = new System.Drawing.Size(100, 20);
            this.calcEdit2.TabIndex = 1;
            // 
            // mainLedgerActType
            // 
            this.mainLedgerActType.Location = new System.Drawing.Point(110, 60);
            this.mainLedgerActType.Name = "mainLedgerActType";
            this.mainLedgerActType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mainLedgerActType.Size = new System.Drawing.Size(70, 20);
            this.mainLedgerActType.TabIndex = 2;
            // 
            // debitFCLbl
            // 
            this.debitFCLbl.Location = new System.Drawing.Point(4, 0);
            this.debitFCLbl.Name = "debitFCLbl";
            this.debitFCLbl.Size = new System.Drawing.Size(41, 13);
            this.debitFCLbl.TabIndex = 3;
            this.debitFCLbl.Text = "Debit FC";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(4, 96);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Offset account";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(217, 0);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Currency";
            // 
            // creditFCLbl
            // 
            this.creditFCLbl.Location = new System.Drawing.Point(110, 0);
            this.creditFCLbl.Name = "creditFCLbl";
            this.creditFCLbl.Size = new System.Drawing.Size(45, 13);
            this.creditFCLbl.TabIndex = 6;
            this.creditFCLbl.Text = "Credit FC";
            this.creditFCLbl.Click += new System.EventHandler(this.creditFCLbl_Click);
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lineBS, "CurrencyCode", true));
            this.lookUpEdit1.Location = new System.Drawing.Point(216, 19);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrCode", "Curr Code", 30, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrName", "Curr Name", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit1.Properties.DataSource = this.currencyBindingSource;
            this.lookUpEdit1.Properties.DisplayMember = "CurrName";
            this.lookUpEdit1.Properties.ValueMember = "CurrCode";
            this.lookUpEdit1.Size = new System.Drawing.Size(63, 20);
            this.lookUpEdit1.TabIndex = 7;
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lineBS, "ExchRate", true));
            this.textEdit1.EditValue = "";
            this.textEdit1.Location = new System.Drawing.Point(285, 19);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(48, 20);
            this.textEdit1.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(4, 66);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Main account";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(285, 0);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(49, 13);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Exch Rate";
            // 
            // offsetLedgerActType
            // 
            this.offsetLedgerActType.Location = new System.Drawing.Point(110, 89);
            this.offsetLedgerActType.Name = "offsetLedgerActType";
            this.offsetLedgerActType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.offsetLedgerActType.Size = new System.Drawing.Size(70, 20);
            this.offsetLedgerActType.TabIndex = 12;
            // 
            // mainPopup
            // 
            this.mainPopup.Location = new System.Drawing.Point(186, 60);
            this.mainPopup.Name = "mainPopup";
            this.mainPopup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mainPopup.Properties.PopupControl = this.mainPopupContainerControl;
            this.mainPopup.Size = new System.Drawing.Size(147, 20);
            this.mainPopup.TabIndex = 13;
            // 
            // mainPopupContainerControl
            // 
            this.mainPopupContainerControl.Controls.Add(this.mainGLDimSelectXUC);
            this.mainPopupContainerControl.Location = new System.Drawing.Point(503, 22);
            this.mainPopupContainerControl.Name = "mainPopupContainerControl";
            this.mainPopupContainerControl.Size = new System.Drawing.Size(200, 100);
            this.mainPopupContainerControl.TabIndex = 14;
            // 
            // offsetPopupContainerControl
            // 
            this.offsetPopupContainerControl.Controls.Add(this.offsetGLDimSelectXUC);
            this.offsetPopupContainerControl.Location = new System.Drawing.Point(297, 96);
            this.offsetPopupContainerControl.Name = "offsetPopupContainerControl";
            this.offsetPopupContainerControl.Size = new System.Drawing.Size(200, 100);
            this.offsetPopupContainerControl.TabIndex = 15;
            // 
            // offsetPopup
            // 
            this.offsetPopup.Location = new System.Drawing.Point(187, 89);
            this.offsetPopup.Name = "offsetPopup";
            this.offsetPopup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.offsetPopup.Properties.PopupControl = this.offsetPopupContainerControl;
            this.offsetPopup.Size = new System.Drawing.Size(147, 20);
            this.offsetPopup.TabIndex = 16;
            // 
            // offsetGLDimSelectXUC
            // 
            this.offsetGLDimSelectXUC.DefaultDimension = null;
            this.offsetGLDimSelectXUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.offsetGLDimSelectXUC.LedgerLineType = B_PowerWin.DB.LedgerLineTypeEnum.None;
            this.offsetGLDimSelectXUC.LineBase = null;
            this.offsetGLDimSelectXUC.Location = new System.Drawing.Point(0, 0);
            this.offsetGLDimSelectXUC.Name = "offsetGLDimSelectXUC";
            this.offsetGLDimSelectXUC.Size = new System.Drawing.Size(200, 100);
            this.offsetGLDimSelectXUC.TabIndex = 0;
            // 
            // mainGLDimSelectXUC
            // 
            this.mainGLDimSelectXUC.DefaultDimension = null;
            this.mainGLDimSelectXUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGLDimSelectXUC.LedgerLineType = B_PowerWin.DB.LedgerLineTypeEnum.None;
            this.mainGLDimSelectXUC.LineBase = null;
            this.mainGLDimSelectXUC.Location = new System.Drawing.Point(0, 0);
            this.mainGLDimSelectXUC.Name = "mainGLDimSelectXUC";
            this.mainGLDimSelectXUC.Size = new System.Drawing.Size(200, 100);
            this.mainGLDimSelectXUC.TabIndex = 0;
            // 
            // lineBS
            // 
            this.lineBS.DataSource = typeof(B_PowerWin.DB.DocumentLine);
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataSource = typeof(B_PowerWin.DB.Currency);
            // 
            // GLLineEditorXUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.offsetPopup);
            this.Controls.Add(this.offsetPopupContainerControl);
            this.Controls.Add(this.mainPopupContainerControl);
            this.Controls.Add(this.mainPopup);
            this.Controls.Add(this.offsetLedgerActType);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.lookUpEdit1);
            this.Controls.Add(this.creditFCLbl);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.debitFCLbl);
            this.Controls.Add(this.mainLedgerActType);
            this.Controls.Add(this.calcEdit2);
            this.Controls.Add(this.debitFCCalc);
            this.Name = "GLLineEditorXUC";
            this.Size = new System.Drawing.Size(751, 143);
            ((System.ComponentModel.ISupportInitialize)(this.debitFCCalc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainLedgerActType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetLedgerActType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPopup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPopupContainerControl)).EndInit();
            this.mainPopupContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.offsetPopupContainerControl)).EndInit();
            this.offsetPopupContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.offsetPopup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource lineBS;
        private DevExpress.XtraEditors.CalcEdit debitFCCalc;
        private DevExpress.XtraEditors.CalcEdit calcEdit2;
        private DevExpress.XtraEditors.ImageComboBoxEdit mainLedgerActType;
        private DevExpress.XtraEditors.LabelControl debitFCLbl;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl creditFCLbl;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ImageComboBoxEdit offsetLedgerActType;
        private DevExpress.XtraEditors.PopupContainerEdit mainPopup;
        private DevExpress.XtraEditors.PopupContainerControl mainPopupContainerControl;
        private GLDimSelectXUC mainGLDimSelectXUC;
        private DevExpress.XtraEditors.PopupContainerControl offsetPopupContainerControl;
        private GLDimSelectXUC offsetGLDimSelectXUC;
        private DevExpress.XtraEditors.PopupContainerEdit offsetPopup;
    }
}
