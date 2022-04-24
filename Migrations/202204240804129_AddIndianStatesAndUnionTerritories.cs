namespace Library_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIndianStatesAndUnionTerritories : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IndianStatesAndUnionTerritories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.IndianStatesAndUnionTerritories");
        }
    }
}
