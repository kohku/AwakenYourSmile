namespace AwakenYourSmile.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AilmentAge : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClinicalHistories", "AilmentAge", c => c.String());
            AddColumn("dbo.ClinicalHistories", "LowerArchShape", c => c.String());
            DropColumn("dbo.ClinicalHistories", "InnerArchShape");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ClinicalHistories", "InnerArchShape", c => c.String());
            DropColumn("dbo.ClinicalHistories", "LowerArchShape");
            DropColumn("dbo.ClinicalHistories", "AilmentAge");
        }
    }
}
