﻿namespace B_PowerWin
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.preferencesBarItem = new DevExpress.XtraBars.BarSubItem();
            this.langBI = new DevExpress.XtraBars.BarEditItem();
            this.langComboBoxRepItem = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.labelSetupBarItem = new DevExpress.XtraBars.BarButtonItem();
            this.windowSubMenu = new DevExpress.XtraBars.BarSubItem();
            this.cascadeBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.tileVerticalBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.titleHorizontalBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.closeAllBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.arrangeIconsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.recentBarItem = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barDockingMenuItem1 = new DevExpress.XtraBars.BarDockingMenuItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.gLNavBarGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.mainAccountGroupNBI = new DevExpress.XtraNavBar.NavBarItem();
            this.mainAccountNBI = new DevExpress.XtraNavBar.NavBarItem();
            this.gLDimensionNBI = new DevExpress.XtraNavBar.NavBarItem();
            this.sequSetupBI = new DevExpress.XtraNavBar.NavBarItem();
            this.jourSetupBI = new DevExpress.XtraNavBar.NavBarItem();
            this.inentoryNavBarGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.inventStoreGroupNBI = new DevExpress.XtraNavBar.NavBarItem();
            this.systemAdminNavBarGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.securitySetupGroupNBI = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.langComboBoxRepItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.Controller = this.barAndDockingController1;
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.preferencesBarItem,
            this.skinBarSubItem1,
            this.langBI,
            this.barDockingMenuItem1,
            this.barSubItem1,
            this.recentBarItem,
            this.windowSubMenu,
            this.cascadeBarButtonItem,
            this.tileVerticalBarButtonItem,
            this.titleHorizontalBarButtonItem,
            this.closeAllBarButtonItem,
            this.arrangeIconsBarButtonItem,
            this.labelSetupBarItem});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 13;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.langComboBoxRepItem});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.preferencesBarItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.windowSubMenu)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // preferencesBarItem
            // 
            this.preferencesBarItem.Caption = "Preferences";
            this.preferencesBarItem.Id = 0;
            this.preferencesBarItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.langBI),
            new DevExpress.XtraBars.LinkPersistInfo(this.skinBarSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.labelSetupBarItem)});
            this.preferencesBarItem.Name = "preferencesBarItem";
            // 
            // langBI
            // 
            this.langBI.Caption = "Lang";
            this.langBI.Edit = this.langComboBoxRepItem;
            this.langBI.Id = 2;
            this.langBI.Name = "langBI";
            // 
            // langComboBoxRepItem
            // 
            this.langComboBoxRepItem.AutoHeight = false;
            this.langComboBoxRepItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.langComboBoxRepItem.DropDownRows = 4;
            this.langComboBoxRepItem.Items.AddRange(new object[] {
            "ar-EG",
            "en-US"});
            this.langComboBoxRepItem.Name = "langComboBoxRepItem";
            this.langComboBoxRepItem.Sorted = true;
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "Skin";
            this.skinBarSubItem1.Id = 1;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // labelSetupBarItem
            // 
            this.labelSetupBarItem.Caption = "Labels setup";
            this.labelSetupBarItem.Id = 12;
            this.labelSetupBarItem.Name = "labelSetupBarItem";
            // 
            // windowSubMenu
            // 
            this.windowSubMenu.Caption = "Window";
            this.windowSubMenu.Id = 6;
            this.windowSubMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.cascadeBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.tileVerticalBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.titleHorizontalBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.closeAllBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.arrangeIconsBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.recentBarItem)});
            this.windowSubMenu.Name = "windowSubMenu";
            // 
            // cascadeBarButtonItem
            // 
            this.cascadeBarButtonItem.Caption = "Cascade";
            this.cascadeBarButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("cascadeBarButtonItem.Glyph")));
            this.cascadeBarButtonItem.Id = 7;
            this.cascadeBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("cascadeBarButtonItem.LargeGlyph")));
            this.cascadeBarButtonItem.Name = "cascadeBarButtonItem";
            // 
            // tileVerticalBarButtonItem
            // 
            this.tileVerticalBarButtonItem.Caption = "Tile &Vertical";
            this.tileVerticalBarButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("tileVerticalBarButtonItem.Glyph")));
            this.tileVerticalBarButtonItem.Id = 8;
            this.tileVerticalBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tileVerticalBarButtonItem.LargeGlyph")));
            this.tileVerticalBarButtonItem.Name = "tileVerticalBarButtonItem";
            // 
            // titleHorizontalBarButtonItem
            // 
            this.titleHorizontalBarButtonItem.Caption = "Tile &Horizontal";
            this.titleHorizontalBarButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("titleHorizontalBarButtonItem.Glyph")));
            this.titleHorizontalBarButtonItem.Id = 9;
            this.titleHorizontalBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("titleHorizontalBarButtonItem.LargeGlyph")));
            this.titleHorizontalBarButtonItem.Name = "titleHorizontalBarButtonItem";
            // 
            // closeAllBarButtonItem
            // 
            this.closeAllBarButtonItem.Caption = "C&lose All";
            this.closeAllBarButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("closeAllBarButtonItem.Glyph")));
            this.closeAllBarButtonItem.Id = 10;
            this.closeAllBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("closeAllBarButtonItem.LargeGlyph")));
            this.closeAllBarButtonItem.Name = "closeAllBarButtonItem";
            // 
            // arrangeIconsBarButtonItem
            // 
            this.arrangeIconsBarButtonItem.Caption = "&Arrange Icons";
            this.arrangeIconsBarButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("arrangeIconsBarButtonItem.Glyph")));
            this.arrangeIconsBarButtonItem.Id = 11;
            this.arrangeIconsBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("arrangeIconsBarButtonItem.LargeGlyph")));
            this.arrangeIconsBarButtonItem.Name = "arrangeIconsBarButtonItem";
            // 
            // recentBarItem
            // 
            this.recentBarItem.Caption = "Recents";
            this.recentBarItem.Glyph = ((System.Drawing.Image)(resources.GetObject("recentBarItem.Glyph")));
            this.recentBarItem.Id = 5;
            this.recentBarItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("recentBarItem.LargeGlyph")));
            this.recentBarItem.Name = "recentBarItem";
            this.recentBarItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barAndDockingController1
            // 
            this.barAndDockingController1.PaintStyleName = "Skin";
            this.barAndDockingController1.PropertiesBar.AllowLinkLighting = false;
            this.barAndDockingController1.PropertiesBar.DefaultGlyphSize = new System.Drawing.Size(16, 16);
            this.barAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = new System.Drawing.Size(32, 32);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(728, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 504);
            this.barDockControlBottom.Size = new System.Drawing.Size(728, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 453);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(728, 51);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 453);
            // 
            // barDockingMenuItem1
            // 
            this.barDockingMenuItem1.Caption = "Docking";
            this.barDockingMenuItem1.Id = 3;
            this.barDockingMenuItem1.Name = "barDockingMenuItem1";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Window";
            this.barSubItem1.Id = 4;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.gLNavBarGroup;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.gLNavBarGroup,
            this.inentoryNavBarGroup,
            this.systemAdminNavBarGroup});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.mainAccountGroupNBI,
            this.mainAccountNBI,
            this.gLDimensionNBI,
            this.inventStoreGroupNBI,
            this.sequSetupBI,
            this.jourSetupBI,
            this.securitySetupGroupNBI});
            this.navBarControl1.Location = new System.Drawing.Point(0, 51);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 140;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.ExplorerBar;
            this.navBarControl1.Size = new System.Drawing.Size(140, 453);
            this.navBarControl1.TabIndex = 5;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // gLNavBarGroup
            // 
            this.gLNavBarGroup.Caption = "GL";
            this.gLNavBarGroup.Expanded = true;
            this.gLNavBarGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.mainAccountGroupNBI),
            new DevExpress.XtraNavBar.NavBarItemLink(this.mainAccountNBI),
            new DevExpress.XtraNavBar.NavBarItemLink(this.gLDimensionNBI),
            new DevExpress.XtraNavBar.NavBarItemLink(this.sequSetupBI),
            new DevExpress.XtraNavBar.NavBarItemLink(this.jourSetupBI)});
            this.gLNavBarGroup.Name = "gLNavBarGroup";
            this.gLNavBarGroup.SmallImage = ((System.Drawing.Image)(resources.GetObject("gLNavBarGroup.SmallImage")));
            // 
            // mainAccountGroupNBI
            // 
            this.mainAccountGroupNBI.Caption = "Main account group";
            this.mainAccountGroupNBI.Name = "mainAccountGroupNBI";
            this.mainAccountGroupNBI.SmallImage = ((System.Drawing.Image)(resources.GetObject("mainAccountGroupNBI.SmallImage")));
            // 
            // mainAccountNBI
            // 
            this.mainAccountNBI.Caption = "Main account";
            this.mainAccountNBI.Name = "mainAccountNBI";
            this.mainAccountNBI.SmallImage = ((System.Drawing.Image)(resources.GetObject("mainAccountNBI.SmallImage")));
            // 
            // gLDimensionNBI
            // 
            this.gLDimensionNBI.Caption = "GL Dimensions setup";
            this.gLDimensionNBI.Name = "gLDimensionNBI";
            this.gLDimensionNBI.SmallImage = ((System.Drawing.Image)(resources.GetObject("gLDimensionNBI.SmallImage")));
            // 
            // sequSetupBI
            // 
            this.sequSetupBI.Caption = "Sequence setup";
            this.sequSetupBI.Name = "sequSetupBI";
            this.sequSetupBI.SmallImage = ((System.Drawing.Image)(resources.GetObject("sequSetupBI.SmallImage")));
            // 
            // jourSetupBI
            // 
            this.jourSetupBI.Caption = "Journals setup";
            this.jourSetupBI.Name = "jourSetupBI";
            this.jourSetupBI.SmallImage = ((System.Drawing.Image)(resources.GetObject("jourSetupBI.SmallImage")));
            // 
            // inentoryNavBarGroup
            // 
            this.inentoryNavBarGroup.Caption = "Inventory";
            this.inentoryNavBarGroup.Expanded = true;
            this.inentoryNavBarGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.inventStoreGroupNBI)});
            this.inentoryNavBarGroup.Name = "inentoryNavBarGroup";
            this.inentoryNavBarGroup.SmallImage = ((System.Drawing.Image)(resources.GetObject("inentoryNavBarGroup.SmallImage")));
            // 
            // inventStoreGroupNBI
            // 
            this.inventStoreGroupNBI.Caption = "Warehouse";
            this.inventStoreGroupNBI.Name = "inventStoreGroupNBI";
            this.inventStoreGroupNBI.SmallImage = ((System.Drawing.Image)(resources.GetObject("inventStoreGroupNBI.SmallImage")));
            // 
            // systemAdminNavBarGroup
            // 
            this.systemAdminNavBarGroup.Caption = "System admin";
            this.systemAdminNavBarGroup.Expanded = true;
            this.systemAdminNavBarGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.securitySetupGroupNBI)});
            this.systemAdminNavBarGroup.Name = "systemAdminNavBarGroup";
            this.systemAdminNavBarGroup.SmallImage = ((System.Drawing.Image)(resources.GetObject("systemAdminNavBarGroup.SmallImage")));
            // 
            // securitySetupGroupNBI
            // 
            this.securitySetupGroupNBI.Caption = "Security setup";
            this.securitySetupGroupNBI.Name = "securitySetupGroupNBI";
            this.securitySetupGroupNBI.SmallImage = ((System.Drawing.Image)(resources.GetObject("securitySetupGroupNBI.SmallImage")));
            // 
            // MainFrm
            // 
            this.ClientSize = new System.Drawing.Size(728, 527);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.langComboBoxRepItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup gLNavBarGroup;
        private DevExpress.XtraNavBar.NavBarItem mainAccountGroupNBI;
        private DevExpress.XtraBars.BarSubItem preferencesBarItem;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraNavBar.NavBarItem mainAccountNBI;
        private DevExpress.XtraNavBar.NavBarItem gLDimensionNBI;
        private DevExpress.XtraBars.BarEditItem langBI;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox langComboBoxRepItem;
        private DevExpress.XtraNavBar.NavBarGroup inentoryNavBarGroup;
        private DevExpress.XtraNavBar.NavBarItem inventStoreGroupNBI;
        private DevExpress.XtraBars.BarDockingMenuItem barDockingMenuItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
        private DevExpress.XtraBars.BarMdiChildrenListItem recentBarItem;
        private DevExpress.XtraBars.BarSubItem windowSubMenu;
        private DevExpress.XtraBars.BarButtonItem cascadeBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem tileVerticalBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem titleHorizontalBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem closeAllBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem arrangeIconsBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem labelSetupBarItem;
        private DevExpress.XtraNavBar.NavBarItem sequSetupBI;
        private DevExpress.XtraNavBar.NavBarItem jourSetupBI;
        private DevExpress.XtraNavBar.NavBarGroup systemAdminNavBarGroup;
        private DevExpress.XtraNavBar.NavBarItem securitySetupGroupNBI;
    }
}
