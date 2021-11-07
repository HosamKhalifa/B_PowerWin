using B_PowerWin.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_PowerWin.GL.Forms
{
    public partial class SysSequenceSetupFrm : EditFormBase
    {
        public SysSequenceSetupFrm()
        {
            InitializeComponent();
            InitData();
        }

        public override void RefreshData()
        {
            dbContext = new AppDbContext();
            dbContext.SysSequences.Load();
            dbContext.BaseTypes.Where(x => x.RecordTypeType == DB.BaseTypeTypeEnum.Account).Load();
            sequBS.DataSource = dbContext.SysSequences.Local;
            baseTypeBindingSource.DataSource = dbContext.BaseTypes.Local;

            sequBS.ResetBindings(true);
            base.RefreshData();
        }

        private void InitData()
        {
            FormGridManager = new GUI.Grid.GridManager();
            FormGridManager.Attach(sequGC);
            sequGC.DataSource = sequBS;
            RefreshData();
        }

    }
}
