using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.GUI.Grid
{
    public class PreviewXtraGridInfo
    {
        public PreviewXtraGridInfo()
        {

        }


        #region Members
        string pageMiddleHeader = "";
        string pageLeftHeader = "";
        string pageRightHeader = "";


        #endregion

        #region Properties

        public string PageMiddleHeader
        {
            set { pageMiddleHeader = value; }
            get { return pageMiddleHeader; }
        }
        public string PageLeftHeader
        {
            set { pageLeftHeader = value; }
            get { return pageLeftHeader; }
        }
        public string PageRightHeader
        {
            set { pageRightHeader = value; }
            get { return pageRightHeader; }
        }


        #endregion

        #region Methods
        public void AttachToGrid(DevExpress.XtraGrid.GridControl gc)
        {
            if (gc.Tag is XtraGridViewInfo)
            {
                ((XtraGridViewInfo)gc.Tag).PreviewGridInfo = this;
            }
            else
            {
                gc.Tag = this;
            }
        }

        public void AttachToGrid(DevExpress.XtraPivotGrid.PivotGridControl pvc)
        {
            if (pvc.Tag is XtraGridViewInfo)
            {
                ((XtraGridViewInfo)pvc.Tag).PreviewGridInfo = this;
            }
            else
            {
                pvc.Tag = this;
            }
        }

        public void AttachToGrid(DevExpress.XtraCharts.ChartControl chart)
        {
            if (chart.Tag is XtraGridViewInfo)
            {
                ((XtraGridViewInfo)chart.Tag).PreviewGridInfo = this;
            }
            else
            {
                chart.Tag = this;
            }
        }

        public void SetPageMiddleHeaderLines(params string[] lines)
        {
            foreach (string lin in lines)
            {
                this.pageMiddleHeader += Environment.NewLine + lin;
            }
        }

        public void SetPageRightHeaderLines(params string[] lines)
        {
            foreach (string lin in lines)
            {
                this.pageRightHeader += Environment.NewLine + lin;
            }
        }

        public void SetPageLeftHeaderLines(params string[] lines)
        {
            foreach (string lin in lines)
            {
                this.pageLeftHeader += Environment.NewLine + lin;
            }
        }

        public string GetTimeRangeString(DateTime fromDate, DateTime toDate)
        {
            string line = string.Format(" From : {0} To: {1} ", fromDate.ToShortDateString(), toDate.ToShortDateString());
            return line;


        }

        public string GetTimeRangeString(int fromPID, int toPID)
        {
            //string fromPName = GlobalMethods.SQLSelectScalar(String.Format("SELECT FP.FinPeriodName FROM FinancialPeriodTable FP WHERE FP.FinPeriodID = {0} ", fromPID)).ToString();
            //string toPName = GlobalMethods.SQLSelectScalar(String.Format("SELECT FP.FinPeriodName FROM FinancialPeriodTable FP WHERE FP.FinPeriodID = {0} ", toPID)).ToString();
            //string line = string.Format(" From : {0} To: {1} ", fromPName, toPName);
            //return line;
            return "";


        }


        #endregion

        #region EventHandlers

        #endregion

    }

}
