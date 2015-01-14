namespace AwakenYourSmile.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddConfirmedBooked4Appointment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Appointments", "ConfirmedByUser", c => c.Boolean(nullable: false));
            AddColumn("dbo.Appointments", "Booked", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Appointments", "Booked");
            DropColumn("dbo.Appointments", "ConfirmedByUser");
        }
    }
}
