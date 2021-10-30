namespace B_PowerWin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_0020 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.sec_principal_user", "UserKey", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.sec_principal_user", "UserKey", c => c.Int(nullable: false));
        }
    }
}
