namespace AwakenYourSmile.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AppointmentCancelledFlag : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Appointments", "Cancelled", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Appointments", "Cancelled");
        }
    }
}
