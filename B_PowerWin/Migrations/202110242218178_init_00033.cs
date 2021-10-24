namespace B_PowerWin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_00033 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.sec_principal_user", "SkinName", c => c.String(maxLength: 50));
            AddColumn("dbo.sec_principal_user", "LangId", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            DropColumn("dbo.sec_principal_user", "LangId");
            DropColumn("dbo.sec_principal_user", "SkinName");
        }
    }
}
