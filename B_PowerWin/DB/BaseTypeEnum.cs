using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.DB
{
    public enum BaseTypeEnum
    {
        None=-1,
        MainAccount=1000,
        MainAccountGroup=1001,
        Customer = 1002,
        CustomerGroup=1003,
        Vendor = 1004,
        VendorGroup=1005,
        Item=1006,
        ItemSize=1007,
        ItemColor = 1008,
        ItemBatch = 1009,
        JournalType = 1010,
        LedgerJournal = 1011,
        PaymentTerm = 1012,
        SecPrincipalRoleMem = 1013,
        TaxCode = 1014,
        TaxCodeValueSetup=1015,
        TaxGroup = 1016,
        TaxGroupMemberSetup = 1017,
        DimDefault = 1018,
        InventDimDefault = 1019,
        Bank = 1020,
        Employee = 1021,
        ItemBatchSerial = 1022,
        ItemVariants = 1023,
        Pos = 1024,
        Cash=1025,
        AccountGroup=1026,
        SecPrincipalRole=1027,
        SecPrincipalUser=1028,
        Purpose = 1029,
        Project = 1030,
        Equipment = 1031,
        Department = 1032,
        Site = 1033,
        InventStore = 1034,
        BusinessUnit = 1035
    }
}
