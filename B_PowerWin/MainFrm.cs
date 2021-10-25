using B_PowerWin.Properties;
using DevExpress.LookAndFeel;
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
        public MainFrm()
        {
            InitializeComponent();
            SkinManage();
            preferencesBarItem.ItemClick += (s, e) => {
                var frm = new GUI.UILabelManagerFrm() { MdiParent = this, WindowState = FormWindowState.Maximized };
                frm.Show();
            };
            

            InitGLMenu();
        }

        private void InitGLMenu()
        {
            //Main account group
            mainAccountGroupNBI.LinkClicked += (s, e) => {
                e.Link.Item.Tag = DB.BaseTypeEnum.MainAccountGroup;
                var frm = new GL.Forms.MainAccountGroupFrm() { MdiParent = this, WindowState = FormWindowState.Maximized };
                frm.Show();
            };
            //Main Account
            mainAccountNBI.LinkClicked += (s, e) => {

                e.Link.Item.Tag = DB.BaseTypeEnum.MainAccount;
                var frm = new GL.Forms.MainAccountFrm() { MdiParent = this, WindowState = FormWindowState.Maximized };
                frm.Show();

            };
            //GL Dimensions setup
            gLDimensionNBI.LinkClicked += (s, e) => {

                
                var frm = new GL.Forms.GLDimensionSetup() { MdiParent = this, WindowState = FormWindowState.Maximized };
                frm.Show();

            };
        }

        private void SkinManage()
        {

            UserLookAndFeel.Default.SkinName = Settings.Default["AppSkinName"].ToString();
            this.FormClosing += (s, e) =>
            {
                Settings.Default["AppSkinName"] = UserLookAndFeel.Default.SkinName;
                Settings.Default.Save();
            };
        }













    }
}
