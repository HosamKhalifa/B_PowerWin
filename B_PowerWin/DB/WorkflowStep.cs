using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    public enum WorkflowStep
    {
        MakeItReady = 10,
        Approve = 20,
        Reopen = 30,
        Reject = 40,
        Post = 50,
        Unpost = 60
    }
}
