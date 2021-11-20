namespace B_PowerWin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_0040 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.tax_code", name: "ApTaxAccount_Id", newName: "ApTaxAccountId");
            RenameColumn(table: "dbo.tax_code", name: "ArTaxAccount_Id", newName: "ArTaxAccountId");
            RenameColumn(table: "dbo.tax_code", name: "SettlementTaxAccount_Id", newName: "SettlementTaxAccountId");
            RenameIndex(table: "dbo.tax_code", name: "IX_ArTaxAccount_Id", newName: "IX_ArTaxAccountId");
            RenameIndex(table: "dbo.tax_code", name: "IX_ApTaxAccount_Id", newName: "IX_ApTaxAccountId");
            RenameIndex(table: "dbo.tax_code", name: "IX_SettlementTaxAccount_Id", newName: "IX_SettlementTaxAccountId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.tax_code", name: "IX_SettlementTaxAccountId", newName: "IX_SettlementTaxAccount_Id");
            RenameIndex(table: "dbo.tax_code", name: "IX_ApTaxAccountId", newName: "IX_ApTaxAccount_Id");
            RenameIndex(table: "dbo.tax_code", name: "IX_ArTaxAccountId", newName: "IX_ArTaxAccount_Id");
            RenameColumn(table: "dbo.tax_code", name: "SettlementTaxAccountId", newName: "SettlementTaxAccount_Id");
            RenameColumn(table: "dbo.tax_code", name: "ArTaxAccountId", newName: "ArTaxAccount_Id");
            RenameColumn(table: "dbo.tax_code", name: "ApTaxAccountId", newName: "ApTaxAccount_Id");
        }
    }
}
