using B_PowerWin.GUI.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace B_PowerWin.GL.Forms
{
    public partial class GLJournal : B_PowerWin.GUI.EditFormBase
    {
        public GLJournal():base()
        {
            InitializeComponent();
            InitData();
        }
        public override void RefreshData()
        {
            base.RefreshData();
            

        }
        private void InitData()
        {
            dbContext = new AppDbContext();
            GridManager.SetupEditForm(gLJournalGV, new List<string>() {
                                      DB.DocumentGL.DocumentBaseFields.ReferenceNum,
                                      DB.DocumentGL.DocumentBaseFields.DocDescription,
                                      DB.DocumentGL.DocumentBaseFields.TransDate,
                                      DB.DocumentGL.DocumentGLFields.CurrencyCode,
                                      DB.DocumentGL.DocumentGLFields.CurrencyExch  
            });
        }
    }
}
