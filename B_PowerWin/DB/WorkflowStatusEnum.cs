using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    public enum WorkflowStatusEnum
    {
        Draft = 10,//Draft is inital status for document 
        ReadyForApprove = 20,//Ready for apporve the status when document pass vaidation and then will be ready to starting approve rules
        Approving = 30,//Approving after first approve action applied to the document and still til Last Approve happened
        Approved = 40,//After all approve cycle member signed the document
        Rejected = -1,//These option will return document to Whom take ReadyForApprove 
        Posted = 100//Can not changed
    }
}
