namespace B_PowerWin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_0032 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ledger_posting_profile_setup", "LedgerPostingEntry", c => c.Int(nullable: false));
            AddColumn("dbo.ledger_posting_profile_setup", "CVBC_MainAccount", c => c.Long());
            AddColumn("dbo.ledger_posting_profile_setup", "InventoryControl_MainAccount", c => c.Long());
            AddColumn("dbo.ledger_posting_profile_setup", "SalesRevenue_MainAccount", c => c.Long());
            AddColumn("dbo.ledger_posting_profile_setup", "CostOfGoodsSold_MainAccount", c => c.Long());
            AddColumn("dbo.ledger_posting_profile_setup", "DeferredRevenue_MainAcount", c => c.Long());
            AddColumn("dbo.ledger_posting_profile_setup", "UnInvoicedAR_MainAccount", c => c.Long());
            AddColumn("dbo.ledger_posting_profile_setup", "UnderInspectionInventory_MainAccount", c => c.Long());
            AddColumn("dbo.ledger_posting_profile_setup", "UnderInspectionVendor_MainAccount", c => c.Long());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ledger_posting_profile_setup", "UnderInspectionVendor_MainAccount");
            DropColumn("dbo.ledger_posting_profile_setup", "UnderInspectionInventory_MainAccount");
            DropColumn("dbo.ledger_posting_profile_setup", "UnInvoicedAR_MainAccount");
            DropColumn("dbo.ledger_posting_profile_setup", "DeferredRevenue_MainAcount");
            DropColumn("dbo.ledger_posting_profile_setup", "CostOfGoodsSold_MainAccount");
            DropColumn("dbo.ledger_posting_profile_setup", "SalesRevenue_MainAccount");
            DropColumn("dbo.ledger_posting_profile_setup", "InventoryControl_MainAccount");
            DropColumn("dbo.ledger_posting_profile_setup", "CVBC_MainAccount");
            DropColumn("dbo.ledger_posting_profile_setup", "LedgerPostingEntry");
        }
    }
}
