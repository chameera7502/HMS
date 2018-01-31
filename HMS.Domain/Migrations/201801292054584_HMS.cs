namespace HMS.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HMS : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Guests",
                c => new
                    {
                        GuestID = c.Int(nullable: false, identity: true),
                        ContactNumber = c.String(maxLength: 15),
                        Name = c.String(maxLength: 100),
                        Address = c.String(maxLength: 200),
                        Status = c.Boolean(nullable: false),
                        RoomManagment_id = c.Int(),
                    })
                .PrimaryKey(t => t.GuestID)
                .ForeignKey("dbo.RoomManagments", t => t.RoomManagment_id)
                .Index(t => t.RoomManagment_id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        PaymentType = c.Int(nullable: false),
                        PaymentDate = c.DateTime(nullable: false),
                        paymentAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BalancePayment = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Guest_GuestID = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Guests", t => t.Guest_GuestID)
                .Index(t => t.Guest_GuestID);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationID = c.Int(nullable: false, identity: true),
                        phone = c.String(),
                        FromDate = c.DateTime(nullable: false),
                        ToDate = c.DateTime(nullable: false),
                        Guest_GuestID = c.Int(),
                    })
                .PrimaryKey(t => t.ReservationID)
                .ForeignKey("dbo.Guests", t => t.Guest_GuestID)
                .Index(t => t.Guest_GuestID);
            
            CreateTable(
                "dbo.RoomManagments",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Reservation_ReservationID = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Reservations", t => t.Reservation_ReservationID)
                .Index(t => t.Reservation_ReservationID);
            
           /* CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomID = c.Int(nullable: false, identity: true),
                        type = c.String(),
                        status = c.Short(nullable: false),
                        Narration = c.String(),
                        RoomManagment_id = c.Int(),
                    })
                .PrimaryKey(t => t.RoomID)
                .ForeignKey("dbo.RoomManagments", t => t.RoomManagment_id)
                .Index(t => t.RoomManagment_id);*/
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rooms", "RoomManagment_id", "dbo.RoomManagments");
            DropForeignKey("dbo.RoomManagments", "Reservation_ReservationID", "dbo.Reservations");
            DropForeignKey("dbo.Guests", "RoomManagment_id", "dbo.RoomManagments");
            DropForeignKey("dbo.Reservations", "Guest_GuestID", "dbo.Guests");
            DropForeignKey("dbo.Payments", "Guest_GuestID", "dbo.Guests");
            DropIndex("dbo.Rooms", new[] { "RoomManagment_id" });
            DropIndex("dbo.RoomManagments", new[] { "Reservation_ReservationID" });
            DropIndex("dbo.Reservations", new[] { "Guest_GuestID" });
            DropIndex("dbo.Payments", new[] { "Guest_GuestID" });
            DropIndex("dbo.Guests", new[] { "RoomManagment_id" });
            DropTable("dbo.Rooms");
            DropTable("dbo.RoomManagments");
            DropTable("dbo.Reservations");
            DropTable("dbo.Payments");
            DropTable("dbo.Guests");
        }
    }
}
