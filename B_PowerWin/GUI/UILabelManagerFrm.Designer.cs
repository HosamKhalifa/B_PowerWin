namespace B_PowerWin.GUI
{
    partial class UILabelManagerFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UILabelManagerFrm));
            this.uILabelLangTxtGC = new B_PowerWin.GUI.Grid.GridCtrlBase();
            this.uILabelLangTxtGV = new B_PowerWin.GUI.Grid.GridViewBase();
            this.colLabelId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLabelType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLangId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTxt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.uiLabelGC = new B_PowerWin.GUI.Grid.GridCtrlBase();
            this.uILabelBindingSource = new System.Windows.Forms.BindingSource();
            this.uiLabelGV = new B_PowerWin.GUI.Grid.GridViewBase();
            this.colLabelId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFieldName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaseType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLookupCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLookupFilterExp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrid_IsHidden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrid_IsDisabled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrid_Width = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrid_VisibleOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrid_LookupFormRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.buildLabaelsBI = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.uILabelLangTxtGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uILabelLangTxtGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiLabelGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uILabelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiLabelGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uILabelLangTxtGC
            // 
            this.uILabelLangTxtGC.dbContext = null;
            this.uILabelLangTxtGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uILabelLangTxtGC.Location = new System.Drawing.Point(0, 0);
            this.uILabelLangTxtGC.MainView = this.uILabelLangTxtGV;
            this.uILabelLangTxtGC.Name = "uILabelLangTxtGC";
            this.uILabelLangTxtGC.Size = new System.Drawing.Size(796, 225);
            this.uILabelLangTxtGC.TabIndex = 0;
            this.uILabelLangTxtGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.uILabelLangTxtGV});
            // 
            // uILabelLangTxtGV
            // 
            this.uILabelLangTxtGV.BaseTypeEnum = B_PowerWin.DB.BaseTypeEnum.None;
            this.uILabelLangTxtGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLabelId1,
            this.colLabelType,
            this.colLangId,
            this.colTxt});
            this.uILabelLangTxtGV.GridControl = this.uILabelLangTxtGC;
            this.uILabelLangTxtGV.GridViewEditMode = B_PowerWin.GUI.Grid.GridViewEditModeEnum.FormEdit;
            this.uILabelLangTxtGV.Name = "uILabelLangTxtGV";
            // 
            // colLabelId1
            // 
            this.colLabelId1.FieldName = "LabelId";
            this.colLabelId1.Name = "colLabelId1";
            this.colLabelId1.Visible = true;
            this.colLabelId1.VisibleIndex = 0;
            // 
            // colLabelType
            // 
            this.colLabelType.FieldName = "LabelType";
            this.colLabelType.Name = "colLabelType";
            this.colLabelType.Visible = true;
            this.colLabelType.VisibleIndex = 1;
            // 
            // colLangId
            // 
            this.colLangId.FieldName = "LangId";
            this.colLangId.Name = "colLangId";
            this.colLangId.Visible = true;
            this.colLangId.VisibleIndex = 2;
            // 
            // colTxt
            // 
            this.colTxt.FieldName = "Txt";
            this.colTxt.Name = "colTxt";
            this.colTxt.Visible = true;
            this.colTxt.VisibleIndex = 3;
            // 
            // uiLabelGC
            // 
            this.uiLabelGC.DataSource = this.uILabelBindingSource;
            this.uiLabelGC.dbContext = null;
            this.uiLabelGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabelGC.Location = new System.Drawing.Point(0, 0);
            this.uiLabelGC.MainView = this.uiLabelGV;
            this.uiLabelGC.Name = "uiLabelGC";
            this.uiLabelGC.Size = new System.Drawing.Size(796, 255);
            this.uiLabelGC.TabIndex = 0;
            this.uiLabelGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.uiLabelGV});
            // 
            // uILabelBindingSource
            // 
            this.uILabelBindingSource.DataSource = typeof(B_PowerWin.DB.UILabel);
            // 
            // uiLabelGV
            // 
            this.uiLabelGV.BaseTypeEnum = B_PowerWin.DB.BaseTypeEnum.None;
            this.uiLabelGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLabelId,
            this.colFieldName,
            this.colBaseType,
            this.colLookupCode,
            this.colLookupFilterExp,
            this.colGrid_IsHidden,
            this.colGrid_IsDisabled,
            this.colGrid_Width,
            this.colGrid_VisibleOrder,
            this.colGrid_LookupFormRef,
            this.gridColumn1});
            this.uiLabelGV.GridControl = this.uiLabelGC;
            this.uiLabelGV.GridViewEditMode = B_PowerWin.GUI.Grid.GridViewEditModeEnum.SimpleEdit;
            this.uiLabelGV.Name = "uiLabelGV";
            // 
            // colLabelId
            // 
            this.colLabelId.FieldName = "LabelId";
            this.colLabelId.Name = "colLabelId";
            this.colLabelId.Visible = true;
            this.colLabelId.VisibleIndex = 0;
            // 
            // colFieldName
            // 
            this.colFieldName.FieldName = "FieldName";
            this.colFieldName.Name = "colFieldName";
            this.colFieldName.Visible = true;
            this.colFieldName.VisibleIndex = 1;
            // 
            // colBaseType
            // 
            this.colBaseType.FieldName = "BaseType";
            this.colBaseType.Name = "colBaseType";
            this.colBaseType.Visible = true;
            this.colBaseType.VisibleIndex = 2;
            // 
            // colLookupCode
            // 
            this.colLookupCode.FieldName = "LookupCode";
            this.colLookupCode.Name = "colLookupCode";
            this.colLookupCode.Visible = true;
            this.colLookupCode.VisibleIndex = 3;
            // 
            // colLookupFilterExp
            // 
            this.colLookupFilterExp.FieldName = "LookupFilterExp";
            this.colLookupFilterExp.Name = "colLookupFilterExp";
            this.colLookupFilterExp.Visible = true;
            this.colLookupFilterExp.VisibleIndex = 4;
            // 
            // colGrid_IsHidden
            // 
            this.colGrid_IsHidden.FieldName = "Grid_IsHidden";
            this.colGrid_IsHidden.Name = "colGrid_IsHidden";
            this.colGrid_IsHidden.Visible = true;
            this.colGrid_IsHidden.VisibleIndex = 5;
            // 
            // colGrid_IsDisabled
            // 
            this.colGrid_IsDisabled.FieldName = "Grid_IsDisabled";
            this.colGrid_IsDisabled.Name = "colGrid_IsDisabled";
            this.colGrid_IsDisabled.Visible = true;
            this.colGrid_IsDisabled.VisibleIndex = 6;
            // 
            // colGrid_Width
            // 
            this.colGrid_Width.FieldName = "Grid_Width";
            this.colGrid_Width.Name = "colGrid_Width";
            this.colGrid_Width.Visible = true;
            this.colGrid_Width.VisibleIndex = 7;
            // 
            // colGrid_VisibleOrder
            // 
            this.colGrid_VisibleOrder.FieldName = "Grid_VisibleOrder";
            this.colGrid_VisibleOrder.Name = "colGrid_VisibleOrder";
            this.colGrid_VisibleOrder.Visible = true;
            this.colGrid_VisibleOrder.VisibleIndex = 8;
            // 
            // colGrid_LookupFormRef
            // 
            this.colGrid_LookupFormRef.FieldName = "Grid_LookupFormRef";
            this.colGrid_LookupFormRef.Name = "colGrid_LookupFormRef";
            this.colGrid_LookupFormRef.Visible = true;
            this.colGrid_LookupFormRef.VisibleIndex = 9;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "BaseType.BaseTypeName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 10;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 31);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.uiLabelGC);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.uILabelLangTxtGC);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(796, 485);
            this.splitContainerControl1.SplitterPosition = 225;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 31);
            this.barDockControlTop.Size = new System.Drawing.Size(796, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 516);
            this.barDockControlBottom.Size = new System.Drawing.Size(796, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 485);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(796, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 485);
            // 
            // buildLabaelsBI
            // 
            this.buildLabaelsBI.Caption = "Build Labels";
            this.buildLabaelsBI.Glyph = ((System.Drawing.Image)(resources.GetObject("buildLabaelsBI.Glyph")));
            this.buildLabaelsBI.Id = 2;
            this.buildLabaelsBI.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("buildLabaelsBI.LargeGlyph")));
            this.buildLabaelsBI.Name = "buildLabaelsBI";
            this.buildLabaelsBI.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // UILabelManagerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(796, 539);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UILabelManagerFrm";
            this.Controls.SetChildIndex(this.barDockControlTop, 0);
            this.Controls.SetChildIndex(this.barDockControlBottom, 0);
            this.Controls.SetChildIndex(this.barDockControlRight, 0);
            this.Controls.SetChildIndex(this.barDockControlLeft, 0);
            this.Controls.SetChildIndex(this.splitContainerControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.uILabelLangTxtGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uILabelLangTxtGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiLabelGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uILabelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiLabelGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Grid.GridCtrlBase uiLabelGC;
        private Grid.GridViewBase uiLabelGV;
        private Grid.GridCtrlBase uILabelLangTxtGC;
        private Grid.GridViewBase uILabelLangTxtGV;
        private DevExpress.XtraGrid.Columns.GridColumn colLabelId1;
        private DevExpress.XtraGrid.Columns.GridColumn colLabelType;
        private DevExpress.XtraGrid.Columns.GridColumn colLangId;
        private DevExpress.XtraGrid.Columns.GridColumn colTxt;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.BindingSource uILabelBindingSource;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn colLabelId;
        private DevExpress.XtraGrid.Columns.GridColumn colFieldName;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseType;
        private DevExpress.XtraGrid.Columns.GridColumn colLookupCode;
        private DevExpress.XtraGrid.Columns.GridColumn colLookupFilterExp;
        private DevExpress.XtraGrid.Columns.GridColumn colGrid_IsHidden;
        private DevExpress.XtraGrid.Columns.GridColumn colGrid_IsDisabled;
        private DevExpress.XtraGrid.Columns.GridColumn colGrid_Width;
        private DevExpress.XtraGrid.Columns.GridColumn colGrid_VisibleOrder;
        private DevExpress.XtraGrid.Columns.GridColumn colGrid_LookupFormRef;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraBars.BarButtonItem buildLabaelsBI;
    }
}
