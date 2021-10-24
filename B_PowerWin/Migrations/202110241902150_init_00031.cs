namespace B_PowerWin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_00031 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.line_base", "BaseType_BaseTypeId", "dbo.base_type");
            DropIndex("dbo.line_base", new[] { "BaseType_BaseTypeId" });
            AlterColumn("dbo.line_base", "CreatedBy", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.line_base", "CreatedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.line_base", "ModifiedBy", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.line_base", "BaseType_BaseTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.line_base", "BaseType_BaseTypeId");
            AddForeignKey("dbo.line_base", "BaseType_BaseTypeId", "dbo.base_type", "BaseTypeId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.line_base", "BaseType_BaseTypeId", "dbo.base_type");
            DropIndex("dbo.line_base", new[] { "BaseType_BaseTypeId" });
            AlterColumn("dbo.line_base", "BaseType_BaseTypeId", c => c.Int());
            AlterColumn("dbo.line_base", "ModifiedBy", c => c.String(maxLength: 50));
            AlterColumn("dbo.line_base", "CreatedAt", c => c.DateTime());
            AlterColumn("dbo.line_base", "CreatedBy", c => c.String(maxLength: 50));
            CreateIndex("dbo.line_base", "BaseType_BaseTypeId");
            AddForeignKey("dbo.line_base", "BaseType_BaseTypeId", "dbo.base_type", "BaseTypeId");
        }
    }
}
