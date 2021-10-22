using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace B_PowerWin
{
    public partial class MainFrm : B_PowerWin.GUI.FormBase
    {
        public MainFrm()
        {
            InitializeComponent();
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
        }
    }
}
