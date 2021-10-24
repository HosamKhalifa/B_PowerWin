namespace B_PowerWin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_00032 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.line_base", "BaseType_BaseTypeId", "dbo.base_type");
            DropIndex("dbo.line_base", new[] { "BaseType_BaseTypeId" });
            AddColumn("dbo.line_base", "BaseType", c => c.Int(nullable: false));
            AlterColumn("dbo.line_base", "BaseType_BaseTypeId", c => c.Int());
            CreateIndex("dbo.line_base", "BaseType_BaseTypeId");
            AddForeignKey("dbo.line_base", "BaseType_BaseTypeId", "dbo.base_type", "BaseTypeId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.line_base", "BaseType_BaseTypeId", "dbo.base_type");
            DropIndex("dbo.line_base", new[] { "BaseType_BaseTypeId" });
            AlterColumn("dbo.line_base", "BaseType_BaseTypeId", c => c.Int(nullable: false));
            DropColumn("dbo.line_base", "BaseType");
            CreateIndex("dbo.line_base", "BaseType_BaseTypeId");
            AddForeignKey("dbo.line_base", "BaseType_BaseTypeId", "dbo.base_type", "BaseTypeId", cascadeDelete: true);
        }
    }
}
