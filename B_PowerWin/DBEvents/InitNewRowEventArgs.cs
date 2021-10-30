using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DBEvents
{
    public delegate void InitNewRowHandler(object sender, InitNewRowEventArgs e);
    public class InitNewRowEventArgs:EventArgs
    {
        public InitNewRowEventArgs()
        {

        }

    }
}
