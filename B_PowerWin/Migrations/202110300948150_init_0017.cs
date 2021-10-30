namespace B_PowerWin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_0017 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.journal_type", "SequId", "dbo.sys_sequence");
            DropIndex("dbo.journal_type", new[] { "SequId" });
            AddColumn("dbo.journal_type", "fSysSequence_Id", c => c.Long());
            AddColumn("dbo.journal_type", "fSequGenerateAtPosting", c => c.Boolean(nullable: false));
            AddColumn("dbo.journal_type", "fDetailSummary", c => c.Int(nullable: false));
            AddColumn("dbo.journal_type", "fAmountsInclueTax", c => c.Boolean(nullable: false));
            CreateIndex("dbo.journal_type", "fSysSequence_Id");
            AddForeignKey("dbo.journal_type", "fSysSequence_Id", "dbo.sys_sequence", "Id");
            DropColumn("dbo.journal_type", "SequGenerateAtPosting");
            DropColumn("dbo.journal_type", "DetailSummary");
            DropColumn("dbo.journal_type", "AmountsInclueTax");
        }
        
        public override void Down()
        {
            AddColumn("dbo.journal_type", "AmountsInclueTax", c => c.Boolean(nullable: false));
            AddColumn("dbo.journal_type", "DetailSummary", c => c.Int(nullable: false));
            AddColumn("dbo.journal_type", "SequGenerateAtPosting", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.journal_type", "fSysSequence_Id", "dbo.sys_sequence");
            DropIndex("dbo.journal_type", new[] { "fSysSequence_Id" });
            DropColumn("dbo.journal_type", "fAmountsInclueTax");
            DropColumn("dbo.journal_type", "fDetailSummary");
            DropColumn("dbo.journal_type", "fSequGenerateAtPosting");
            DropColumn("dbo.journal_type", "fSysSequence_Id");
            CreateIndex("dbo.journal_type", "SequId");
            AddForeignKey("dbo.journal_type", "SequId", "dbo.sys_sequence", "Id");
        }
    }
}
