namespace B_PowerWin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_0043 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.user_parameter",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        UserKey = c.Int(),
                        QueryBaseType = c.Int(nullable: false),
                        StartDate = c.DateTime(),
                        EndDate = c.DateTime(),
                        StartTransDayId = c.Int(),
                        EndTransDayId = c.Int(),
                        CustomerListExp = c.String(maxLength: 1000),
                        VendorListExp = c.String(maxLength: 1000),
                        StoreListExp = c.String(maxLength: 1000),
                        SiteListExp = c.String(maxLength: 1000),
                        DeptListExp = c.String(maxLength: 1000),
                        EqupListExp = c.String(maxLength: 1000),
                        BusinessUnitListExp = c.String(maxLength: 1000),
                        ItemListExp = c.String(maxLength: 1000),
                        ItemInventoryListExp = c.String(maxLength: 1000),
                        ItemServiceListExp = c.String(maxLength: 1000),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.line_base", t => t.Id)
                .Index(t => t.Id)
                .Index(t => new { t.UserKey, t.QueryBaseType }, unique: true, name: "user_parameter_uq");
            
            AddColumn("dbo.doc_base", "DocDescription", c => c.String(maxLength: 250));
            AlterColumn("dbo.doc_base", "TransDayId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.user_parameter", "Id", "dbo.line_base");
            DropIndex("dbo.user_parameter", "user_parameter_uq");
            DropIndex("dbo.user_parameter", new[] { "Id" });
            AlterColumn("dbo.doc_base", "TransDayId", c => c.Int());
            DropColumn("dbo.doc_base", "DocDescription");
            DropTable("dbo.user_parameter");
        }
    }
}
