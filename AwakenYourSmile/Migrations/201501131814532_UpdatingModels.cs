namespace AwakenYourSmile.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatingModels : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ClinicalHistories", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ClinicalHistories", "Name", c => c.String());
        }
    }
}
