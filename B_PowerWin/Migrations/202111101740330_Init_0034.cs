namespace B_PowerWin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init_0034 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.account_group", "GroupedBaseType_BaseTypeId", "dbo.base_type");
            DropIndex("dbo.account_group", new[] { "GroupedBaseType_BaseTypeId" });
            DropIndex("dbo.account_group", "AccountGroup_ReferenceNum_UQ");
            DropIndex("dbo.account_group", "AccountGroup_Name_UQ");
            CreateIndex("dbo.account_group", new[] { "ReferenceNum", "GroupedBaseTypeId" }, unique: true, name: "AccountGroup_ReferenceNum_UQ");
            CreateIndex("dbo.account_group", new[] { "Name", "GroupedBaseTypeId" }, unique: true, name: "AccountGroup_Name_UQ");
            DropColumn("dbo.account_group", "GroupedBaseType_BaseTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.account_group", "GroupedBaseType_BaseTypeId", c => c.Int(nullable: false));
            DropIndex("dbo.account_group", "AccountGroup_Name_UQ");
            DropIndex("dbo.account_group", "AccountGroup_ReferenceNum_UQ");
            CreateIndex("dbo.account_group", "Name", unique: true, name: "AccountGroup_Name_UQ");
            CreateIndex("dbo.account_group", "ReferenceNum", unique: true, name: "AccountGroup_ReferenceNum_UQ");
            CreateIndex("dbo.account_group", "GroupedBaseType_BaseTypeId");
            AddForeignKey("dbo.account_group", "GroupedBaseType_BaseTypeId", "dbo.base_type", "BaseTypeId", cascadeDelete: true);
        }
    }
}
