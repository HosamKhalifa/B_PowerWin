namespace B_PowerWin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_0042 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tax_group", "TaxGroup_Id", "dbo.tax_group");
            DropIndex("dbo.tax_group", new[] { "TaxGroup_Id" });
            AddColumn("dbo.doc_base", "TaxGroupId", c => c.Long());
            AddColumn("dbo.doc_line", "DebitFC", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.doc_line", "CreditFC", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.doc_line", "DebitCC", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.doc_line", "CreditCC", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.doc_line", "LineValueFC", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.doc_line", "LineValueCC", c => c.Decimal(precision: 18, scale: 2));
            CreateIndex("dbo.doc_base", "TaxGroupId");
            AddForeignKey("dbo.doc_base", "TaxGroupId", "dbo.tax_group", "Id");
            DropColumn("dbo.tax_group", "TaxGroup_Id");
            DropColumn("dbo.doc_base", "TaxGroup");
            DropColumn("dbo.doc_line", "LineValue");
        }
        
        public override void Down()
        {
            AddColumn("dbo.doc_line", "LineValue", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.doc_base", "TaxGroup", c => c.Long());
            AddColumn("dbo.tax_group", "TaxGroup_Id", c => c.Long());
            DropForeignKey("dbo.doc_base", "TaxGroupId", "dbo.tax_group");
            DropIndex("dbo.doc_base", new[] { "TaxGroupId" });
            DropColumn("dbo.doc_line", "LineValueCC");
            DropColumn("dbo.doc_line", "LineValueFC");
            DropColumn("dbo.doc_line", "CreditCC");
            DropColumn("dbo.doc_line", "DebitCC");
            DropColumn("dbo.doc_line", "CreditFC");
            DropColumn("dbo.doc_line", "DebitFC");
            DropColumn("dbo.doc_base", "TaxGroupId");
            CreateIndex("dbo.tax_group", "TaxGroup_Id");
            AddForeignKey("dbo.tax_group", "TaxGroup_Id", "dbo.tax_group", "Id");
        }
    }
}
