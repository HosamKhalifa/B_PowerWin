using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace B_PowerWin.GL.Forms
{
    public partial class JournalTypeSetupFrm : B_PowerWin.GUI.EditFormBase
    {
        public JournalTypeSetupFrm()
        {
            InitializeComponent();
            InitData();
        }
        public override void RefreshData()
        {
            dbContext = new AppDbContext();
            dbContext.JournalTypes.Load();
            jourTypeBS.DataSource = dbContext.JournalTypes.Local;
            jourTypeBS.ResetBindings(true);
            base.RefreshData();
        }
        private void InitData()
        {
            FormGridManager = new GUI.Grid.GridManager();
            jourTypeGC.DataSource = jourTypeBS;
            FormGridManager.Attach(jourTypeGC);
            //jourTypeGV.DataSourceChanged += (s, e) => {
            //    var gv = (s as GridView);
            //    if (gv.DataSource is BindingSource)
            //    {
            //        var lt_Rows = (gv.DataSource as BindingSource).List;
            //        foreach (var item in lt_Rows)
            //        {
            //            if (item is DB.JournalType)
            //            {
            //                (item as DB.JournalType).PropertyChanged += JournalTypeSetupFrm_PropertyChanged;
            //            }
            //        }


            //    }
            //};
            jourTypeGV.ValidateRow += (s, e) => {
                var lt_Row = (DB.JournalType)e.Row;
                if (lt_Row.JourType == DB.JournalTypeEnum.BudgetEntry)
                {
                    lt_Row.PostingLayer = DB.PostingLayerEnum.Bugdet;
                }
                else
                {
                    lt_Row.PostingLayer = DB.PostingLayerEnum.GL;
                }
            };
            //jourTypeBS.AddingNew += (s, e) => {
            //    e.NewObject = new DB.JournalType() { JourType = DB.JournalTypeEnum.InventReturnToVend, PostingLayer = DB.PostingLayerEnum.Bugdet, DetailSummary = DB.JournalTypeDetailSummaryEnum.Summery };
            //    (e.NewObject as DB.JournalType).PropertyChanged += JournalTypeSetupFrm_PropertyChanged;
                
            //};
            //jourTypeGV.InitNewRow += (s, e) => {
            //    var lt_Row = (DB.JournalType)(s as GridView).GetRow(e.RowHandle);
            //    lt_Row.OnInitNewRow(new DBEvents.InitNewRowEventArgs());
            //};
            RefreshData();

        }

        private void JournalTypeSetupFrm_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
           
           
        }
    }
}
