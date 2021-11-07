namespace B_PowerWin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_00311 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ledger_posting_profile",
                c => new
                    {
                        ProfileId = c.String(nullable: false, maxLength: 100),
                        ProfileName = c.String(nullable: false, maxLength: 200),
                        ProfileType = c.Int(nullable: false),
                        AccountBaseType = c.Int(nullable: false),
                        LedgerPostingEntry = c.Int(nullable: false),
                        PostingModule = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProfileId);
            
            CreateTable(
                "dbo.ledger_posting_profile_setup",
                c => new
                    {
                        ProfileId = c.String(nullable: false, maxLength: 100),
                        LineNum = c.Int(nullable: false),
                        PostingScope = c.Int(nullable: false),
                        LineValue = c.Long(nullable: false),
                        LineDescription = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => new { t.ProfileId, t.LineNum })
                .ForeignKey("dbo.ledger_posting_profile", t => t.ProfileId, cascadeDelete: true)
                .Index(t => t.ProfileId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ledger_posting_profile_setup", "ProfileId", "dbo.ledger_posting_profile");
            DropIndex("dbo.ledger_posting_profile_setup", new[] { "ProfileId" });
            DropTable("dbo.ledger_posting_profile_setup");
            DropTable("dbo.ledger_posting_profile");
        }
    }
}
