namespace B_PowerWin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_0041 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.account_base", name: "TaxGroup_Id", newName: "TaxGroupId");
            RenameIndex(table: "dbo.account_base", name: "IX_TaxGroup_Id", newName: "IX_TaxGroupId");
            AddColumn("dbo.tax_group", "TaxGroup_Id", c => c.Long());
            CreateIndex("dbo.tax_group", "TaxGroup_Id");
            AddForeignKey("dbo.tax_group", "TaxGroup_Id", "dbo.tax_group", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tax_group", "TaxGroup_Id", "dbo.tax_group");
            DropIndex("dbo.tax_group", new[] { "TaxGroup_Id" });
            DropColumn("dbo.tax_group", "TaxGroup_Id");
            RenameIndex(table: "dbo.account_base", name: "IX_TaxGroupId", newName: "IX_TaxGroup_Id");
            RenameColumn(table: "dbo.account_base", name: "TaxGroupId", newName: "TaxGroup_Id");
        }
    }
}
