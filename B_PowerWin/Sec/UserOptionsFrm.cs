using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace B_PowerWin.Sec
{
    public partial class UserOptionsFrm : B_PowerWin.GUI.EditFormBase
    {
        public UserOptionsFrm():base()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            dbContext = new AppDbContext();
            
            RefreshData();

        }
        public override void RefreshData()
        {
            dbContext.SecPrincipalUsers.Where(x => x.PrincipalId == MySession.Session.UserId).Load();
            secPrincipalUserBindingSource.DataSource = dbContext.SecPrincipalUsers.Local;
            secPrincipalUserBindingSource.ResetBindings(true);
            dataLayoutControl1.DataSource = secPrincipalUserBindingSource;

            base.RefreshData();

        }

    }
}
