using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    public enum LedgerPostingEntryEnum
    {
        None                    = 0,
        CustARAccount           = 1,
        Bank                    = 2,
        Cash                    = 3,       
        VendAPAccount           = 4,

        GL_Manual               = 99999,

        POS_SalesInvoice        = 100,
        POS_Collection_Cash     = 102,
        POS_Collection_Visa     = 103,
        POS_Collection_Points   = 104,
        POS_Collection_Credit   = 105,
        POS_BuyFromCutomer      = 106,
        
        CostOfGoodsSold         = 200,
        
        PurchaseBill            = 300       
        //Return well be reversing for all sales entry 
        //Services will be selected at posting profile by Item Type

        //Inventory receipts will create Entry 
        //Invoice Creation will reversing Inventory receipts and Credting Vendor & Debting Inventory Control


    }
}
