
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace B_PowerWin.GUI.Grid
{
    public partial class PreviewXtraGridHeaderXtraForm : FormBase
    {
        public List<string> HeaderTexts { set; get; }
        public PreviewXtraGridHeaderXtraForm()
        {
           
            InitializeComponent();
          

        }

        #region Members

        List<string> headerTexts;

        #endregion

        #region Properties

        #endregion

        #region Methods

        #endregion

        #region EventHandlers

        private void closeSimpleButton_Click(object sender, EventArgs e)
        {
            HeaderTexts = new List<string>();
            HeaderTexts.Add(textEdit1.Text);//left
            HeaderTexts.Add(textEdit2.Text);//middle
            HeaderTexts.Add(textEdit3.Text);//right
            

            this.Close();
        }

        #endregion

    }
}
