namespace Library_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudentBookIssue : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentBookIssues",
                c => new
                    {
                        MemberId = c.Long(nullable: false),
                        BookId = c.Long(nullable: false),
                        MemberName = c.String(maxLength: 50),
                        BookName = c.String(),
                        IssueDate = c.String(maxLength: 50),
                        DueDate = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => new { t.MemberId, t.BookId });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudentBookIssues");
        }
    }
}
