namespace Library_Management_System.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateIndianStatesAndUnionTerritories : DbMigration
    {
        public override void Up()
        {
            // 28 States
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('Andhra Pradesh')");
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('Arunachal Pradesh')");
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('Assam')");
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('Bihar')");
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('Chhattisgarh')");
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('Goa')");
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('Gujarat')");
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('Haryana')");
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('Himachal Pradesh')");
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('Jharkhand')");
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('Karnataka')");
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('Kerala')");
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('Madhya Pradesh')");
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('Maharashtra')");
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('Manipur')");
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('Meghalaya')");
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('Mizoram')");
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('Nagaland')");
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('Odisha')");
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('Punjab')");
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('Rajasthan')");
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('Sikkim')");
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('Tamil Nadu')");
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('Telangana')");
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('Tripura')");
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('Uttarakhand')");
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('Uttar Pradesh')");
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('West Bengal')");

            // 8 Union Territories
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('Andaman and Nicobar Islands')");
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('Chandigarh')");
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('Dadra and Nagar Haveli and Daman & Diu')");
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('The Government of NCT of Delhi')");
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('Jammu & Kashmir')");
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('Ladakh')");
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('Lakshadweep')");
            Sql("INSERT INTO IndianStatesAndUnionTerritories (Name) VALUES('Puducherry')");
        }

        public override void Down()
        {
        }
    }
}
