namespace AwakenYourSmile.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CompletingHistorialClinical : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClinicalHistories", "PregnacyBirthProblemsDetails", c => c.String());
            AddColumn("dbo.ClinicalHistories", "AllergicDetails", c => c.String());
            AddColumn("dbo.ClinicalHistories", "Bruises", c => c.Boolean(nullable: false));
            AddColumn("dbo.ClinicalHistories", "BruisesDate", c => c.DateTime());
            AddColumn("dbo.ClinicalHistories", "BruisesReason", c => c.String());
            AddColumn("dbo.ClinicalHistories", "Others", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClinicalHistories", "Others");
            DropColumn("dbo.ClinicalHistories", "BruisesReason");
            DropColumn("dbo.ClinicalHistories", "BruisesDate");
            DropColumn("dbo.ClinicalHistories", "Bruises");
            DropColumn("dbo.ClinicalHistories", "AllergicDetails");
            DropColumn("dbo.ClinicalHistories", "PregnacyBirthProblemsDetails");
        }
    }
}
