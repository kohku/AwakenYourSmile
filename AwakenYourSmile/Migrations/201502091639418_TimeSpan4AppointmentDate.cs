namespace AwakenYourSmile.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TimeSpan4AppointmentDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Appointments", "AppointmentTime", c => c.Time(nullable: false, precision: 7));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Appointments", "AppointmentTime");
        }
    }
}
