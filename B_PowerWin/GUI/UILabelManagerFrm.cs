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
            grdMgr.Attach(uiLabelGC, uILabelLangTxtGC);
            //uiLabelGV.ValidateRow += (s, e) => {
            //    MySession.Session.Database.UILabels.AddOrUpdate(e.Row as UILabel);
            //     MySession.Session.Database.SaveChanges();
            // };
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
            //seedDatabaseLBI.ItemClick += (s, e) => {
            //    SeedDatabase.SeedUsers(MySession.Session.Database);
            //    SeedDatabase.SeedUILabels(MySession.Session.Database);
                
            //    SeedDatabase.SeedEnumTable(MySession.Session.Database);
            //};
            //saveLBI.ItemClick += (s, e) => {
            //    uILabelBindingSource.EndEdit();
            //    dbContext.ChangeTracker.DetectChanges();
                

            //    if(XtraMessageBox.Show("Save changes?","Save",MessageBoxButtons.OK) == DialogResult.OK)
            //    {
            //        dbContext.SaveChanges();
            //    }
                
            //};
        }

        private void InitData()
        {
            //Link each Grid View for belongs Class type

            dbContext = new B_PowerWin.AppDbContext();
            //// Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            //dbContext.UILabels.LoadAsync().ContinueWith(loadTask =>
            //{
            //    // Bind data to control when loading complete
            
            dbContext.UILabels.Include(X => X.BaseType.Lines).Load();
            uILabelBindingSource.DataSource = dbContext.UILabels.Local;    

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
