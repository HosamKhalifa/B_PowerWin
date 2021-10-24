namespace B_PowerWin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_0002 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.sec_principal_role_mem", "AccessType", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.sec_principal_role_mem", "AccessType");
        }
    }
}
