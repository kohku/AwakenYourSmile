namespace AwakenYourSmile.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IncludingBusinessBase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Appointments", "DateCreated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Appointments", "CreatedBy", c => c.String());
            AddColumn("dbo.Appointments", "LastUpdated", c => c.DateTime());
            AddColumn("dbo.Appointments", "LastUpdatedBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Appointments", "LastUpdatedBy");
            DropColumn("dbo.Appointments", "LastUpdated");
            DropColumn("dbo.Appointments", "CreatedBy");
            DropColumn("dbo.Appointments", "DateCreated");
        }
    }
}
