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
            InitFormBase(_callerArgs);
        }
        public virtual void ViewDetail(long? _PKey)
        {
            //using Args.CallerArgs which contain current record

            //Should be overrid on child forms to exposing logic to filter current form when called from another form 
        }
        private void InitFormBase(FormArgs _callerArgs=null)
        {
            FormArgs = new FormArgs(this) { CallerFormArgs = _callerArgs};
            FormGridManager = new Grid.GridManager();

        }
    }
}