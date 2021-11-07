namespace B_PowerWin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_00321 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.account_base", "GroupId");
            AddForeignKey("dbo.account_base", "GroupId", "dbo.account_group", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.account_base", "GroupId", "dbo.account_group");
            DropIndex("dbo.account_base", new[] { "GroupId" });
        }
    }
}
