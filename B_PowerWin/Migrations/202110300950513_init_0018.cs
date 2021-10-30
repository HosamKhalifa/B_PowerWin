namespace B_PowerWin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_0018 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.journal_type", "SequGenerateAtPosting", c => c.Boolean(nullable: false));
            AddColumn("dbo.journal_type", "AmountsInclueTax", c => c.Boolean(nullable: false));
            DropColumn("dbo.journal_type", "fSequGenerateAtPosting");
            DropColumn("dbo.journal_type", "fAmountsInclueTax");
        }
        
        public override void Down()
        {
            AddColumn("dbo.journal_type", "fAmountsInclueTax", c => c.Boolean(nullable: false));
            AddColumn("dbo.journal_type", "fSequGenerateAtPosting", c => c.Boolean(nullable: false));
            DropColumn("dbo.journal_type", "AmountsInclueTax");
            DropColumn("dbo.journal_type", "SequGenerateAtPosting");
        }
    }
}
