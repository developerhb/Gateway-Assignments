namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Number = c.Guid(nullable: false),
                        Name = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        Mobile = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Number = c.Guid(nullable: false),
                        CustomerID = c.Int(nullable: false),
                        LicensePlate = c.String(),
                        Make = c.String(),
                        Model = c.String(),
                        RegistrationDate = c.String(),
                        ChessisNumber = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Mechanics",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Number = c.Guid(nullable: false),
                        Name = c.String(),
                        Email = c.String(),
                        Contact = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Number = c.Guid(nullable: false),
                        MechanicID = c.Int(nullable: false),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                        Time = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Mechanics", t => t.MechanicID, cascadeDelete: true)
                .Index(t => t.MechanicID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Services", "MechanicID", "dbo.Mechanics");
            DropForeignKey("dbo.Vehicles", "CustomerID", "dbo.Customers");
            DropIndex("dbo.Services", new[] { "MechanicID" });
            DropIndex("dbo.Vehicles", new[] { "CustomerID" });
            DropTable("dbo.Services");
            DropTable("dbo.Mechanics");
            DropTable("dbo.Vehicles");
            DropTable("dbo.Customers");
        }
    }
}
