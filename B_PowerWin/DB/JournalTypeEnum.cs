using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    public enum JournalTypeEnum
    {
        GLEntry=10,BudgetEntry=11,

        VendInvoice=20,VendNote=21,VendPayment=22,VendCollection=23,PurchOrder=24,
        
        CustInvoice=30,CustNote=31,CustPayment=32,CustCollection=33,SalesOrder=34,

        InventReceipt=40,InventReturnToVend=41,InventToProd=42,InventFromProd=43,InventTransfer=44
        


    }
}
