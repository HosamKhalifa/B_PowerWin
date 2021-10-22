using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.Xpo;
using System.Linq;

using DevExpress.Data.Filtering;
namespace B_PowerWin.GUI.Grid
{
    public class PreviewXtraGrid
    {
        public FormBase ParentForm { get; set; }
        public PreviewXtraGrid(DevExpress.XtraGrid.GridControl gc)
        {
            if (gc.Tag is PreviewXtraGridInfo)
            {
                this.grdInfo = (PreviewXtraGridInfo)gc.Tag;
            }
            if (gc.Tag is XtraGridViewInfo)
            {
                this.grdInfo = ((XtraGridViewInfo)gc.Tag).PreviewGridInfo;
            }

            InitObj(gc);

            SetViewsOptions(gc);//To allow print filter info

            gcPrintableComponentLink.Component = gc;


        }

        public PreviewXtraGrid(DevExpress.XtraPivotGrid.PivotGridControl pvgc)
        {
            if (pvgc.Tag is PreviewXtraGridInfo)
            {
                this.grdInfo = (PreviewXtraGridInfo)pvgc.Tag;
            }
            if (pvgc.Tag is XtraGridViewInfo)
            {
                this.grdInfo = ((XtraGridViewInfo)pvgc.Tag).PreviewGridInfo;
            }
            InitObj(pvgc);
            SetViewsOptions(pvgc);
            gcPrintableComponentLink.Component = pvgc;
        }

        public PreviewXtraGrid(DevExpress.XtraCharts.ChartControl chart)
        {
            InitObj(chart);
            gcPrintableComponentLink.Component = chart;

        }

        public PreviewXtraGrid(DevExpress.XtraTreeList.TreeList treeLst)
        {
            InitObj(treeLst);
            gcPrintableComponentLink.Component = treeLst;

        }




        #region Members

        private DevExpress.XtraPrinting.PrintingSystem printingSystem1;
        private DevExpress.XtraPrinting.PrintableComponentLink gcPrintableComponentLink;

        private PreviewXtraGridInfo grdInfo;

        #endregion

        #region Properties
        public DevExpress.XtraPrinting.PrintableComponentLink PrintableGridLink
        {
            set { this.gcPrintableComponentLink = value; }
            get { return this.gcPrintableComponentLink; }
        }
        #endregion

        #region Methods

        private void InitObj(Control cntrl)
        {
            this.ParentForm = (FormBase)cntrl.FindForm();
            string parentFormName = this.ParentForm.Text;
            string leftHeaderText = "", rightHeaderText = "", middleHeaderText = "";
            this.printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem();
            this.gcPrintableComponentLink = new DevExpress.XtraPrinting.PrintableComponentLink();

            // printingSystem1
            // 
            this.printingSystem1.Links.AddRange(new object[] {
            this.gcPrintableComponentLink});
            this.printingSystem1.Watermark.Text = "Runtime Inquiry";
            this.printingSystem1.Watermark.ShowBehind = false;
            this.printingSystem1.Watermark.ForeColor = System.Drawing.Color.LightGray;


            this.printingSystem1.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.Watermark, DevExpress.XtraPrinting.CommandVisibility.None);
            this.printingSystem1.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.Customize, DevExpress.XtraPrinting.CommandVisibility.None);
            this.printingSystem1.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportXls, DevExpress.XtraPrinting.CommandVisibility.None);
            this.printingSystem1.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportXlsx, DevExpress.XtraPrinting.CommandVisibility.None);
            this.printingSystem1.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportHtm, DevExpress.XtraPrinting.CommandVisibility.None);
            this.printingSystem1.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.SendXls, DevExpress.XtraPrinting.CommandVisibility.None);
            this.printingSystem1.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.SendXlsx, DevExpress.XtraPrinting.CommandVisibility.None);
            this.printingSystem1.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.EditPageHF, DevExpress.XtraPrinting.CommandVisibility.None);

            //Get default header from app code 
            if (grdInfo != null)
            {
                leftHeaderText = grdInfo.PageLeftHeader;
                middleHeaderText = grdInfo.PageMiddleHeader;
                rightHeaderText = grdInfo.PageRightHeader;

            }
            //Get any user defined headers or
            List<string> headerTexts = new List<string>();
            PreviewXtraGridHeaderXtraForm frm = new PreviewXtraGridHeaderXtraForm();
            
            frm.Show();
            if (frm.HeaderTexts != null)
            {
                //List<string> headerTexts = (List<string>)FormRecord.ObjectParm;
                leftHeaderText += Environment.NewLine + frm.HeaderTexts[0];
                middleHeaderText += Environment.NewLine + frm.HeaderTexts[1];
                rightHeaderText += Environment.NewLine + frm.HeaderTexts[2];
            }



            this.gcPrintableComponentLink.PageHeaderFooter = new DevExpress.XtraPrinting.PageHeaderFooter(new DevExpress.XtraPrinting.PageHeaderArea(new string[] {
                String.Format("FinERP {0}{1}{2}", parentFormName, Environment.NewLine, leftHeaderText),
                middleHeaderText,
                rightHeaderText}, new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))), DevExpress.XtraPrinting.BrickAlignment.Near), new DevExpress.XtraPrinting.PageFooterArea(new string[] {
                "[Page # of Pages #]",
                "PrintedBy:" + MySession.Session.UserId,
                "[Date Printed][Time Printed]"}, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), DevExpress.XtraPrinting.BrickAlignment.Near));
            this.gcPrintableComponentLink.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.gcPrintableComponentLink.PrintingSystem = this.printingSystem1;
            this.gcPrintableComponentLink.PrintingSystemBase = this.printingSystem1;


        }

        public void ShowPreviewDialog()
        {
            gcPrintableComponentLink.ShowPreviewDialog();

        }

        private void SetViewsOptions(DevExpress.XtraGrid.GridControl gc)
        {
            foreach (DevExpress.XtraGrid.Views.Grid.GridView v in gc.Views)
            {
                v.OptionsPrint.PrintFilterInfo = true;

            }
        }

        private void SetViewsOptions(DevExpress.XtraPivotGrid.PivotGridControl pvgc)
        {
            pvgc.OptionsPrint.PrintHeadersOnEveryPage = true;
            pvgc.OptionsPrint.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            pvgc.OptionsPrint.PageSettings.Landscape = true;
            pvgc.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.True;

        }

        private void SetViewsOptions(DevExpress.XtraReports.UI.XtraReport rpt)
        {
            rpt.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.Watermark, DevExpress.XtraPrinting.CommandVisibility.None);
            rpt.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.Customize, DevExpress.XtraPrinting.CommandVisibility.None);
            rpt.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportXls, DevExpress.XtraPrinting.CommandVisibility.None);
            rpt.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportXlsx, DevExpress.XtraPrinting.CommandVisibility.None);
            rpt.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportHtm, DevExpress.XtraPrinting.CommandVisibility.None);
            rpt.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.SendXls, DevExpress.XtraPrinting.CommandVisibility.None);
            rpt.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.SendXlsx, DevExpress.XtraPrinting.CommandVisibility.None);


        }

        #endregion

        #region EventHandlers

        #endregion


    }


}
