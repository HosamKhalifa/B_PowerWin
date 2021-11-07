namespace B_PowerWin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_0033 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.account_base", "ParnetId", c => c.Long());
            AddColumn("dbo.account_base", "ParentIdList", c => c.String(maxLength: 500));
            AddColumn("dbo.account_base", "ParentNameList", c => c.String(maxLength: 1000));
            DropColumn("dbo.line_base", "ParnetId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.line_base", "ParnetId", c => c.Long());
            DropColumn("dbo.account_base", "ParentNameList");
            DropColumn("dbo.account_base", "ParentIdList");
            DropColumn("dbo.account_base", "ParnetId");
        }
    }
}
