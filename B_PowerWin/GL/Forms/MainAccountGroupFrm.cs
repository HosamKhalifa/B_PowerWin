using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace B_PowerWin.GL.Forms
{
    public partial class MainAccountGroupFrm : B_PowerWin.GUI.FormBase
    {
        public MainAccountGroupFrm()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            FormGridManager.Attach(mainAccountGroupGC);
            mainAccountGroupBindingSource.DataSource =  MySession.Session.Database.MainAccountGroups.Local;

           
        }
    }
}
