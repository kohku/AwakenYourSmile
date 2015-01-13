namespace AwakenYourSmile.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullableDates : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ClinicalHistories", "SpontaneousBleedingNoseDate", c => c.DateTime());
            AlterColumn("dbo.ClinicalHistories", "BloodTransfusionsDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ClinicalHistories", "BloodTransfusionsDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ClinicalHistories", "SpontaneousBleedingNoseDate", c => c.DateTime(nullable: false));
        }
    }
}
