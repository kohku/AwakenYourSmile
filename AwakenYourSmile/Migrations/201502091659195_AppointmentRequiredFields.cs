namespace AwakenYourSmile.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AppointmentRequiredFields : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Appointments", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Appointments", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Appointments", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Appointments", "PhoneNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Appointments", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Appointments", "Email", c => c.String());
            AlterColumn("dbo.Appointments", "LastName", c => c.String());
            AlterColumn("dbo.Appointments", "FirstName", c => c.String());
        }
    }
}
