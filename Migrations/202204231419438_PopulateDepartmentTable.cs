namespace Library_Management_System.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateDepartmentTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Departments (Name) VALUES ('Aerospace Engineering')");
            Sql("INSERT INTO Departments (Name) VALUES ('Aeronautical Engineering')");
            Sql("INSERT INTO Departments (Name) VALUES ('Agriculture Engineering')");
            Sql("INSERT INTO Departments (Name) VALUES ('Artificial Intelligence')");
            Sql("INSERT INTO Departments (Name) VALUES ('Automobile Engineering')");

            Sql("INSERT INTO Departments (Name) VALUES ('Biotechnology Engineering')");

            Sql("INSERT INTO Departments (Name) VALUES ('Chemical Engineering')");
            Sql("INSERT INTO Departments (Name) VALUES ('Civil Engineering')");
            Sql("INSERT INTO Departments (Name) VALUES ('Computer Science')");

            Sql("INSERT INTO Departments (Name) VALUES ('Data Science and Engineering')");

            Sql("INSERT INTO Departments (Name) VALUES ('Electrical and Electronics Engineering')");
            Sql("INSERT INTO Departments (Name) VALUES ('Electrical Engineering')");
            Sql("INSERT INTO Departments (Name) VALUES ('Electronics and Communications Engineering')");
            Sql("INSERT INTO Departments (Name) VALUES ('Electronics Engineering')");

            Sql("INSERT INTO Departments (Name) VALUES ('Food Technology')");
            Sql("INSERT INTO Departments (Name) VALUES ('Footware Engineering')");

            Sql("INSERT INTO Departments (Name) VALUES ('Genetic Engineering')");

            Sql("INSERT INTO Departments (Name) VALUES ('Information Technology')");

            Sql("INSERT INTO Departments (Name) VALUES ('Mechanical Engineering')");
            Sql("INSERT INTO Departments (Name) VALUES ('Marine Engineering')");

            Sql("INSERT INTO Departments (Name) VALUES ('Nanotechnology')");

            Sql("INSERT INTO Departments (Name) VALUES ('Petroleum Engineering')");
            Sql("INSERT INTO Departments (Name) VALUES ('Plastic Engineering')");
            Sql("INSERT INTO Departments (Name) VALUES ('Production Engineering')");

            Sql("INSERT INTO Departments (Name) VALUES ('Robotics Engineering')");

            Sql("INSERT INTO Departments (Name) VALUES ('Software Engineering')");

            Sql("INSERT INTO Departments (Name) VALUES ('Telecommunication Engineering')");
        }

        public override void Down()
        {
        }
    }
}
