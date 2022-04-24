using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using B_PowerWin.DB;

namespace B_PowerWin.GL.UXC
{
    public partial class GLLineEditorXUC : XtraUserControl
    {
        public LedgerLineTypeEnum LedgerLineType { get; set; }
        public DocumentLine LineBase { get; set; }
        public DimDefault DefaultDimension { get; set; }

        public GLLineEditorXUC()
        {
            InitializeComponent();
           

        }

        public void InitObject(LedgerLineTypeEnum _type)
        {
            this.LedgerLineType = _type;
        }

        private void creditFCLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
