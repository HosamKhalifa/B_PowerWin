using B_PowerWin.Properties;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraNavBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace B_PowerWin
{
    public partial class MainFrm : DevExpress.XtraEditors.XtraForm
    {
        DevExpress.XtraTabbedMdi.XtraTabbedMdiManager MainXtraTabbedMdiManager;
        public MainFrm()
        {
            InitializeComponent();
            SkinManage();
            InitMainMenu();
         
            

            InitGLMenu();
            InitInventoryMenu();
            InitSalesMenu();
            InitHRMenu();
            InitBankAndCashMenu();
            InitSystemAdminMenu();
        }

        private void InitHRMenu()
        {
            employeeBI.LinkClicked += (s, e) => {
                var frm = new HR.Forms.EmployeeFrm () { Text = (s as NavBarItem).Caption, MdiParent = this, WindowState = FormWindowState.Maximized };
                frm.Show();
            };
        }

        private void InitBankAndCashMenu()
        {
            bankBI.LinkClicked += (s, e) => {
                var frm = new GL.Forms.BankFrm() { Text = (s as NavBarItem).Caption, MdiParent = this, WindowState = FormWindowState.Maximized };
                frm.Show();
            };
            cashBI.LinkClicked += (s, e) => {
                var frm = new GL.Forms.CashFrm() { Text = (s as NavBarItem).Caption, MdiParent = this, WindowState = FormWindowState.Maximized };
                frm.Show();
            };

        }

        private void InitSystemAdminMenu()
        {
            securitySetupGroupNBI.LinkClicked += (s, e) => {


                var frm = new Sec.SecPrincipalFrm() { Text = (s as NavBarItem).Caption, MdiParent = this, WindowState = FormWindowState.Maximized };
                frm.Show();

            };
            companySetupNBI.LinkClicked += (s, e) => {


                var frm = new GL.Forms.CompanySetupFrm() { Text = (s as NavBarItem).Caption, MdiParent = this, WindowState = FormWindowState.Maximized };
                frm.Show();

            };

        }

        private void InitMainMenu()
        {
            //Setup XtraTabbedMdiManager
            if (MySession.Session.User.UseMdiTabbedManager)
            {
                MainXtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
                MainXtraTabbedMdiManager.Controller = this.barAndDockingController1;
                MainXtraTabbedMdiManager.MdiParent = this;
            }

            labelSetupBarItem.ItemClick += (s, e) => {
                var frm = new GUI.UILabelManagerFrm() { MdiParent = this, WindowState = FormWindowState.Maximized };
                frm.Show();
            };
            userOptionsBI.ItemClick += (s, e) => {
                var frm = new Sec.UserOptionsFrm() {  MdiParent = this, WindowState = FormWindowState.Maximized };
                frm.Show();
            };
            cascadeBarButtonItem.ItemClick += (s, e) => { LayoutMdi(MdiLayout.Cascade); };
            titleHorizontalBarButtonItem.ItemClick += (s, e) => { LayoutMdi(MdiLayout.TileHorizontal); };
            tileVerticalBarButtonItem.ItemClick += (s, e) => { LayoutMdi(MdiLayout.TileVertical); };
            arrangeIconsBarButtonItem.ItemClick += (s, e) => { LayoutMdi(MdiLayout.ArrangeIcons); };
            closeAllBarButtonItem.ItemClick += (s, e) =>
            {
                foreach (Form childForm in MdiChildren)
                {
                    childForm.Close();
                }
            };
        }

        private void InitInventoryMenu()
        {
            //InventoryStore
            inventStoreGroupNBI.LinkClicked += (s, e) => {
                var frm = new Invent.InventStoreFrm() { Text = (s as NavBarItem).Caption, MdiParent = this, WindowState = FormWindowState.Maximized };
                frm.Show();
            };
            //Item&Services
            itemAndServicesSetupNBI.LinkClicked += (s, e) => {
                var frm = new Invent.ItemFrm() { Text = (s as NavBarItem).Caption, MdiParent = this, WindowState = FormWindowState.Maximized };
                frm.Show();
            };
        }

        private void InitSalesMenu()
        {
            //Posting profile setup
            salesPostingProfileBI.LinkClicked += (s, e) => {


                var frm = new GL.Forms.PostingProfileSetupFrm(DB.LedgerPostingModuleEnum.Sales) { Text = (s as NavBarItem).Caption, MdiParent = this, WindowState = FormWindowState.Maximized };
                frm.Show();

            };
            //Customers
            customerBI.LinkClicked += (s, e) => {


                var frm = new Sales.Forms.CustomerFrm() { Text = (s as NavBarItem).Caption, MdiParent = this, WindowState = FormWindowState.Maximized };
                frm.Show();

            };
        }

        private void InitGLMenu()
        {
            //Main account group
            mainAccountGroupNBI.LinkClicked += (s, e) => {
                e.Link.Item.Tag = DB.BaseTypeEnum.MainAccountGroup;
                var frm = new GL.Forms.MainAccountGroupFrm() { Text = (s as NavBarItem).Caption, MdiParent = this, WindowState = FormWindowState.Maximized };
                frm.Show();
            };
            //Main Account
            mainAccountTreeNBI.LinkClicked += (s, e) => {

                e.Link.Item.Tag = DB.BaseTypeEnum.MainAccount;
                var frm = new GL.Forms.MainAccountTreeFrm() { Text = (s as NavBarItem).Caption, MdiParent = this, WindowState = FormWindowState.Maximized };
                frm.Show();

            };
            mainAccountNBI.LinkClicked += (s, e) => {

                e.Link.Item.Tag = DB.BaseTypeEnum.MainAccount;
                var frm = new GL.Forms.MainAccountFrm() { Text = (s as NavBarItem).Caption, MdiParent = this, WindowState = FormWindowState.Maximized };
                frm.Show();

            };
            //GL Dimensions setup
            gLDimensionNBI.LinkClicked += (s, e) => {

                
                var frm = new GL.Forms.GLDimensionSetup() { Text = (s as NavBarItem).Caption, MdiParent = this, WindowState = FormWindowState.Maximized };
                frm.Show();

            };
            //Sequences setup
            sequSetupBI.LinkClicked += (s, e) => {


                var frm = new GL.Forms.SysSequenceSetupFrm() { Text = (s as NavBarItem).Caption, MdiParent = this, WindowState = FormWindowState.Maximized };
                frm.Show();

            };
            //Sequences setup
            jourSetupBI.LinkClicked += (s, e) => {
                var frm = new GL.Forms.JournalTypeSetupFrm() { Text = (s as NavBarItem).Caption, MdiParent = this, WindowState = FormWindowState.Maximized };
                frm.Show();
            };
            //Tax setup
            taxSetupBI.LinkClicked += (s, e) => {
                var frm = new GL.Forms.TaxSetupFrm() { Text = (s as NavBarItem).Caption, MdiParent = this, WindowState = FormWindowState.Maximized };
                frm.Show();
            };

        }

        private void SkinManage()
        {

            UserLookAndFeel.Default.SkinName = Settings.Default["AppSkinName"].ToString();

            this.Shown += (s, e) => {
                langBI.EditValue = Settings.Default["LangId"].ToString();

            };
            this.FormClosing += (s, e) =>
            {
                Settings.Default["AppSkinName"] = UserLookAndFeel.Default.SkinName;
                Settings.Default["LangId"] = langBI.EditValue.ToString();
                Settings.Default.Save();
            };

        }














    }
}
