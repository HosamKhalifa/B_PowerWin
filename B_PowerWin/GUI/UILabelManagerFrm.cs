using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Data.Entity;
using B_PowerWin.DB;
using B_PowerWin.GUI.Grid;

namespace B_PowerWin.GUI
{
    public partial class UILabelManagerFrm : B_PowerWin.GUI.FormBase
    {
        B_PowerWin.AppDbContext dbContext;
        public UILabelManagerFrm()
        {
            InitializeComponent();
            InitData();
            InitEvents();

           
        }

        private void InitEvents()
        {
            var grdMgr = new GridManager();
            grdMgr.Attach(uiLabelGC, uILabelLangTxtGC);

            uiLabelGV.FocusedRowChanged += (s, e) => {
                var rec = uiLabelGV.GetRow(e.FocusedRowHandle) as UILabel;
                LoadLangTxt(rec);
            };
        }

        private void InitData()
        {
            //Link each Grid View for belongs Class type

            dbContext = new B_PowerWin.AppDbContext();
            //// Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            //dbContext.UILabels.LoadAsync().ContinueWith(loadTask =>
            //{
            //    // Bind data to control when loading complete
            uiLabelGC.DataSource = dbContext.UILabels.Include(X => X.BaseType.Lines).ToList();
            
            //}, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        private void LoadLangTxt(UILabel _label)
        {
            
            uILabelLangTxtGC.DataSource = dbContext.UILabelTxts.Local.Where(x => x.LabelId == _label.LabelId);
            if(dbContext.UILabelTxts.Where(x => x.LabelId == _label.LabelId).Count() == 0)
            {
                SeedDatabase.SeedUILabelLangTxt(dbContext, _label);
                uILabelLangTxtGC.DataSource = dbContext.UILabelTxts.Local.Where(x => x.LabelId == _label.LabelId);
            }
        }
    }
}
