namespace Library_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAdminLogin1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.AdminLogins");
            AddColumn("dbo.AdminLogins", "Id", c => c.Long(nullable: false, identity: true));
            AddColumn("dbo.AdminLogins", "Name", c => c.String(maxLength: 50));
            AddPrimaryKey("dbo.AdminLogins", "Id");
            DropColumn("dbo.AdminLogins", "UserName");
            DropColumn("dbo.AdminLogins", "FullName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AdminLogins", "FullName", c => c.String(maxLength: 50));
            AddColumn("dbo.AdminLogins", "UserName", c => c.String(nullable: false, maxLength: 50));
            DropPrimaryKey("dbo.AdminLogins");
            DropColumn("dbo.AdminLogins", "Name");
            DropColumn("dbo.AdminLogins", "Id");
            AddPrimaryKey("dbo.AdminLogins", "UserName");
        }
    }
}
