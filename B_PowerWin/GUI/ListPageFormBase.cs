using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace B_PowerWin.GUI
{
    public partial class ListPageFormBase : B_PowerWin.GUI.FormBase
    {
        public AppDbContext dbContext { get; set; }
        public ListPageFormBase():base()
        {
            InitializeComponent();
        }
        public ListPageFormBase(FormArgs _callerArgs):base(_callerArgs)
        {
            InitializeComponent();
        }
        public virtual void RefreshData()
        {
            //Override on childs
        }
    }
}
