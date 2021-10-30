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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UILabelManagerFrm));
            this.uiLabelGV_langTxtsGV = new DevExpress.XtraGrid.Views.Card.CardView();
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
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.buildLabaelsBI = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.uiLabelGV_langTxtsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiLabelGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uILabelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiLabelGV)).BeginInit();
            this.SuspendLayout();
            // 
            // uiLabelGV_langTxtsGV
            // 
            this.uiLabelGV_langTxtsGV.FocusedCardTopFieldIndex = 0;
            this.uiLabelGV_langTxtsGV.GridControl = this.uiLabelGC;
            this.uiLabelGV_langTxtsGV.Name = "uiLabelGV_langTxtsGV";
            // 
            // uiLabelGC
            // 
            this.uiLabelGC.DataSource = this.uILabelBindingSource;
            this.uiLabelGC.dbContext = null;
            this.uiLabelGC.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.uiLabelGV_langTxtsGV;
            gridLevelNode1.RelationName = "LangTxts";
            this.uiLabelGC.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.uiLabelGC.Location = new System.Drawing.Point(0, 31);
            this.uiLabelGC.MainView = this.uiLabelGV;
            this.uiLabelGC.Name = "uiLabelGC";
            this.uiLabelGC.Size = new System.Drawing.Size(894, 485);
            this.uiLabelGC.TabIndex = 0;
            this.uiLabelGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.uiLabelGV,
            this.uiLabelGV_langTxtsGV});
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
            // 
            // colLookupCode
            // 
            this.colLookupCode.FieldName = "LookupCode";
            this.colLookupCode.Name = "colLookupCode";
            this.colLookupCode.Visible = true;
            this.colLookupCode.VisibleIndex = 2;
            // 
            // colLookupFilterExp
            // 
            this.colLookupFilterExp.FieldName = "LookupFilterExp";
            this.colLookupFilterExp.Name = "colLookupFilterExp";
            this.colLookupFilterExp.Visible = true;
            this.colLookupFilterExp.VisibleIndex = 3;
            // 
            // colGrid_IsHidden
            // 
            this.colGrid_IsHidden.FieldName = "Grid_IsHidden";
            this.colGrid_IsHidden.Name = "colGrid_IsHidden";
            this.colGrid_IsHidden.Visible = true;
            this.colGrid_IsHidden.VisibleIndex = 4;
            // 
            // colGrid_IsDisabled
            // 
            this.colGrid_IsDisabled.FieldName = "Grid_IsDisabled";
            this.colGrid_IsDisabled.Name = "colGrid_IsDisabled";
            this.colGrid_IsDisabled.Visible = true;
            this.colGrid_IsDisabled.VisibleIndex = 5;
            // 
            // colGrid_Width
            // 
            this.colGrid_Width.FieldName = "Grid_Width";
            this.colGrid_Width.Name = "colGrid_Width";
            this.colGrid_Width.Visible = true;
            this.colGrid_Width.VisibleIndex = 6;
            // 
            // colGrid_VisibleOrder
            // 
            this.colGrid_VisibleOrder.FieldName = "Grid_VisibleOrder";
            this.colGrid_VisibleOrder.Name = "colGrid_VisibleOrder";
            this.colGrid_VisibleOrder.Visible = true;
            this.colGrid_VisibleOrder.VisibleIndex = 7;
            // 
            // colGrid_LookupFormRef
            // 
            this.colGrid_LookupFormRef.FieldName = "Grid_LookupFormRef";
            this.colGrid_LookupFormRef.Name = "colGrid_LookupFormRef";
            this.colGrid_LookupFormRef.Visible = true;
            this.colGrid_LookupFormRef.VisibleIndex = 8;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "BaseType.BaseTypeName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 31);
            this.barDockControlTop.Size = new System.Drawing.Size(894, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 516);
            this.barDockControlBottom.Size = new System.Drawing.Size(894, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(894, 31);
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
            this.ClientSize = new System.Drawing.Size(894, 539);
            this.Controls.Add(this.uiLabelGC);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UILabelManagerFrm";
            this.Controls.SetChildIndex(this.barDockControlTop, 0);
            this.Controls.SetChildIndex(this.barDockControlBottom, 0);
            this.Controls.SetChildIndex(this.barDockControlRight, 0);
            this.Controls.SetChildIndex(this.barDockControlLeft, 0);
            this.Controls.SetChildIndex(this.uiLabelGC, 0);
            ((System.ComponentModel.ISupportInitialize)(this.uiLabelGV_langTxtsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiLabelGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uILabelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiLabelGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Grid.GridCtrlBase uiLabelGC;
        private Grid.GridViewBase uiLabelGV;
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
        private DevExpress.XtraGrid.Views.Card.CardView uiLabelGV_langTxtsGV;
    }
}
