namespace B_PowerWin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_0019 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.journal_type", name: "fSysSequence_Id", newName: "SysSequence_Id");
            RenameIndex(table: "dbo.journal_type", name: "IX_fSysSequence_Id", newName: "IX_SysSequence_Id");
            AddColumn("dbo.journal_type", "DetailSummary", c => c.Int(nullable: false));
            DropColumn("dbo.journal_type", "fDetailSummary");
        }
        
        public override void Down()
        {
            AddColumn("dbo.journal_type", "fDetailSummary", c => c.Int(nullable: false));
            DropColumn("dbo.journal_type", "DetailSummary");
            RenameIndex(table: "dbo.journal_type", name: "IX_SysSequence_Id", newName: "IX_fSysSequence_Id");
            RenameColumn(table: "dbo.journal_type", name: "SysSequence_Id", newName: "fSysSequence_Id");
        }
    }
}
