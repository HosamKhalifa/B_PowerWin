namespace B_PowerWin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_0039 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tax_code_value_setup", "TaxCodeId", c => c.Long(nullable: false));
            AlterColumn("dbo.tax_code_value_setup", "FromDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tax_code_value_setup", "FromAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.tax_code_value_setup", "ToAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.tax_code_value_setup", "TaxValue", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.tax_group_member_setup", "TaxGroupId", c => c.Long(nullable: false));
            AlterColumn("dbo.tax_group_member_setup", "TaxCodeId", c => c.Long(nullable: false));
            CreateIndex("dbo.tax_code_value_setup", "TaxCodeId");
            CreateIndex("dbo.tax_group_member_setup", "TaxGroupId");
            CreateIndex("dbo.tax_group_member_setup", "TaxCodeId");
            AddForeignKey("dbo.tax_code_value_setup", "TaxCodeId", "dbo.tax_code", "Id");
            AddForeignKey("dbo.tax_group_member_setup", "TaxGroupId", "dbo.tax_group", "Id");
            AddForeignKey("dbo.tax_group_member_setup", "TaxCodeId", "dbo.tax_code", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tax_group_member_setup", "TaxCodeId", "dbo.tax_code");
            DropForeignKey("dbo.tax_group_member_setup", "TaxGroupId", "dbo.tax_group");
            DropForeignKey("dbo.tax_code_value_setup", "TaxCodeId", "dbo.tax_code");
            DropIndex("dbo.tax_group_member_setup", new[] { "TaxCodeId" });
            DropIndex("dbo.tax_group_member_setup", new[] { "TaxGroupId" });
            DropIndex("dbo.tax_code_value_setup", new[] { "TaxCodeId" });
            AlterColumn("dbo.tax_group_member_setup", "TaxCodeId", c => c.Long());
            AlterColumn("dbo.tax_group_member_setup", "TaxGroupId", c => c.Long());
            AlterColumn("dbo.tax_code_value_setup", "TaxValue", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.tax_code_value_setup", "ToAmount", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.tax_code_value_setup", "FromAmount", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.tax_code_value_setup", "FromDate", c => c.DateTime());
            AlterColumn("dbo.tax_code_value_setup", "TaxCodeId", c => c.Long());
        }
    }
}
