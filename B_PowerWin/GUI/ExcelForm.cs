
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using B_PowerWin.SharedExt;
using DevExpress.XtraSpreadsheet;
using System.Linq;
using DevExpress.XtraSpreadsheet.Forms;
using DevExpress.XtraSpreadsheet.Commands;

namespace B_PowerWin.GUI
{
    public partial class ExcelForm : FormBase
    {
        public ExcelForm()
        {
            InitializeComponent();
        }

        #region Members

        #endregion

        #region Properties

        #endregion

        #region Methods
        public void OpenExcelFile(Stream excelFileStream)
        {
            excelFileStream.Seek(0, SeekOrigin.Begin);
            spreadsheetControl1.LoadDocument(excelFileStream, DevExpress.Spreadsheet.DocumentFormat.Xls);

        }

        public void OpenExcelFile(byte[] excelFileBytes)
        {
            try
            {
                Stream stream = new MemoryStream(excelFileBytes);
                OpenExcelFile(stream);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.GetFullExceptionErrMessage());
            }
        }

        public void OpenExcelFile(string excelFile)
        {

            spreadsheetControl1.LoadDocument(excelFile);

        }

        public void OpenFromClipboard()
        {
            SpreadsheetCommand pasteCommand = spreadsheetControl1.CreateCommand(SpreadsheetCommandId.PasteSelection);
            SpreadsheetCommand insertTable = spreadsheetControl1.CreateCommand(SpreadsheetCommandId.InsertTable);
            pasteCommand.Execute();
            if (insertTable.CanExecute())
            {
                insertTable.Execute();
            }

        }
      

      


        #endregion

        #region EventHandlers

        #endregion


    }
}
