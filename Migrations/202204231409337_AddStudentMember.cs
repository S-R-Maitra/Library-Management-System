namespace Library_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudentMember : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentMembers",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                        PhoneNo = c.Long(),
                        EmailId = c.String(),
                        DateOfBirth = c.String(maxLength: 50),
                        State = c.String(),
                        City = c.String(),
                        Pincode = c.String(),
                        Address = c.String(),
                        Password = c.String(),
                        DepartmentID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentID, cascadeDelete: true)
                .Index(t => t.DepartmentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentMembers", "DepartmentID", "dbo.Departments");
            DropIndex("dbo.StudentMembers", new[] { "DepartmentID" });
            DropTable("dbo.StudentMembers");
        }
    }
}
