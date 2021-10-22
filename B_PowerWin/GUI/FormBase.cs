using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace B_PowerWin.GUI
{
    public partial class FormBase : DevExpress.XtraEditors.XtraForm
    {
        public FormArgs FormArgs { get; set; }
        public GUI.Grid.GridManager FormGridManager { get; set; }
        public FormBase()
        {
            InitializeComponent();
            InitFormBase();
        }
        public FormBase(FormArgs _callerArgs)
        {
            FormArgs.CallerFormArgs = _callerArgs;
            InitializeComponent();
            InitFormBase();
        }

        private void InitFormBase()
        {
            FormGridManager = new Grid.GridManager();

        }
    }
}