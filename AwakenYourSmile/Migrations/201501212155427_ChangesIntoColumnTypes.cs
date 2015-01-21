namespace AwakenYourSmile.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesIntoColumnTypes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ClinicalHistories", "HospitalizedDate", c => c.DateTime());
            AlterColumn("dbo.ClinicalHistories", "HospitalizedReason", c => c.String());
            AlterColumn("dbo.ClinicalHistories", "MedicatedDate", c => c.DateTime());
            AlterColumn("dbo.ClinicalHistories", "MedicatedReason", c => c.String());
            AlterColumn("dbo.ClinicalHistories", "PrescribedDate", c => c.DateTime());
            AlterColumn("dbo.ClinicalHistories", "PrescribedReason", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ClinicalHistories", "PrescribedReason", c => c.Boolean(nullable: false));
            AlterColumn("dbo.ClinicalHistories", "PrescribedDate", c => c.Boolean(nullable: false));
            AlterColumn("dbo.ClinicalHistories", "MedicatedReason", c => c.Boolean(nullable: false));
            AlterColumn("dbo.ClinicalHistories", "MedicatedDate", c => c.Boolean(nullable: false));
            AlterColumn("dbo.ClinicalHistories", "HospitalizedReason", c => c.Boolean(nullable: false));
            AlterColumn("dbo.ClinicalHistories", "HospitalizedDate", c => c.Boolean(nullable: false));
        }
    }
}
