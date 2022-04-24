namespace Library_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudentTeacherMember : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.StudentMembers", "DateOfBirth", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TeacherMembers", "DateOfBirth", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TeacherMembers", "DateOfBirth", c => c.String(maxLength: 50));
            AlterColumn("dbo.StudentMembers", "DateOfBirth", c => c.String(maxLength: 50));
        }
    }
}
