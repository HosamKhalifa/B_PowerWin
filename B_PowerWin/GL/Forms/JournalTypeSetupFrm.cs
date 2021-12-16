using B_PowerWin.DB;
using B_PowerWin.GUI.Grid;
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
            jourTypeBS.AddingNew += (s, e) => {
                e.NewObject = new DB.JournalType() {
                    PostingLayer = DB.PostingLayerEnum.GL,
                    DetailSummary = DB.JournalTypeDetailSummaryEnum.Detail,
                    SequGenerateAtPosting= true,
                    AmountsInclueTax = true,
                    WFStatus  = DB.WorkflowStatusEnum.Draft
                };
            };
               
            ;
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

            GridManager.SetupEditForm(jourTypeGV, new List<string>() {
                JournalType.JournalTypeFields.JourName,
                JournalType.JournalTypeFields.JourType,
                JournalType.JournalTypeFields.PostingLayer,
                JournalType.JournalTypeFields.SequId,
                JournalType.JournalTypeFields.SequGenerateAtPosting,
                JournalType.JournalTypeFields.DetailSummary,
                JournalType.JournalTypeFields.AmountsInclueTax

            });

            RefreshData();

        }

        private void JournalTypeSetupFrm_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
           
           
        }
    }
}
