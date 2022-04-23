namespace Library_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBook : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Genre = c.String(),
                        AuthorId = c.Long(nullable: false),
                        PublisherId = c.Long(nullable: false),
                        PublishDate = c.String(maxLength: 50),
                        Language = c.String(maxLength: 50),
                        Edition = c.String(),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NoOfPages = c.Int(nullable: false),
                        Description = c.String(),
                        ActualStock = c.Long(nullable: false),
                        CurrentStock = c.Long(nullable: false),
                        BookImageLink = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .ForeignKey("dbo.Publishers", t => t.PublisherId, cascadeDelete: true)
                .Index(t => t.AuthorId)
                .Index(t => t.PublisherId);
            
            CreateTable(
                "dbo.Publishers",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "PublisherId", "dbo.Publishers");
            DropForeignKey("dbo.Books", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "PublisherId" });
            DropIndex("dbo.Books", new[] { "AuthorId" });
            DropTable("dbo.Publishers");
            DropTable("dbo.Books");
        }
    }
}
