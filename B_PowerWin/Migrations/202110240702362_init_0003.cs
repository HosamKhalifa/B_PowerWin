namespace B_PowerWin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_0003 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.enum_table",
                c => new
                    {
                        SysName = c.String(nullable: false, maxLength: 120),
                        ValueId = c.Int(nullable: false),
                        ValueName = c.String(maxLength: 120),
                    })
                .PrimaryKey(t => new { t.SysName, t.ValueId });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.enum_table");
        }
    }
}
