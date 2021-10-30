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
using System.Data.Entity.Migrations;
using DevExpress.XtraEditors;
using B_PowerWin.SharedExt;
namespace B_PowerWin.GUI
{
    public partial class UILabelManagerFrm : B_PowerWin.GUI.EditFormBase
    {
       
        public UILabelManagerFrm()
        {
            InitializeComponent();
            InitData();
            InitEvents();

           
        }

        private void InitEvents()
        {
            var grdMgr = new GridManager();
            grdMgr.Attach(uiLabelGC);

            bar1.AddItem(buildLabaelsBI);
            uiLabelGV.FocusedRowChanged += (s, e) => {
                try
                {
                    var rec = uiLabelGV.GetRow(e.FocusedRowHandle) as UILabel;
                    LoadLangTxt(rec);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.GetFullExceptionErrMessage());
                }
               
            };
            buildLabaelsBI.ItemClick += (s, e) => {
                DB.SeedDatabase.SeedEnumTable(MySession.Session.Database);
                DB.SeedDatabase.SeedUILabels(MySession.Session.Database);
               
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
            
            dbContext.UILabels.Include(X => X.LangTxts).Include(x=> x.BaseType).Load();
            uILabelBindingSource.DataSource = dbContext.UILabels.Local;    

            //}, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        private void LoadLangTxt(UILabel _label)
        {
            //if (dbContext.UILabelTxts.Where(x => x.LabelId == _label.LabelId).Count() == 0)
            //{
            //    SeedDatabase.SeedUILabelLangTxt(dbContext, _label);
            //}

            //dbContext.UILabelTxts.Local.Where(x => x.LabelId == _label.LabelId);
            

        }

        private void entityTypeButtons_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
          
        }
    }
}
