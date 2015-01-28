namespace AwakenYourSmile.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovingExtraFunction : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Appointments", "ConfirmedByUser");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Appointments", "ConfirmedByUser", c => c.Boolean(nullable: false));
        }
    }
}
