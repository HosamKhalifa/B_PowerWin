namespace B_PowerWin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_0031 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.account_group", "Id", "dbo.account_base");
            AddColumn("dbo.account_group", "GroupedBaseTypeId", c => c.Int(nullable: false));
            AddColumn("dbo.account_group", "ReferenceNum", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.account_group", "Name", c => c.String(nullable: false, maxLength: 100));
            CreateIndex("dbo.account_group", "ReferenceNum", unique: true, name: "AccountGroup_ReferenceNum_UQ");
            CreateIndex("dbo.account_group", "Name", unique: true, name: "AccountGroup_Name_UQ");
            AddForeignKey("dbo.account_group", "Id", "dbo.line_base", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.account_group", "Id", "dbo.line_base");
            DropIndex("dbo.account_group", "AccountGroup_Name_UQ");
            DropIndex("dbo.account_group", "AccountGroup_ReferenceNum_UQ");
            DropColumn("dbo.account_group", "Name");
            DropColumn("dbo.account_group", "ReferenceNum");
            DropColumn("dbo.account_group", "GroupedBaseTypeId");
            AddForeignKey("dbo.account_group", "Id", "dbo.account_base", "Id");
        }
    }
}
