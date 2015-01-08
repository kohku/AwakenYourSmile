namespace AwakenYourSmile.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClinicalHistoryMoreProperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClinicalHistories", "IntraoralExaminationBraces", c => c.String());
            AddColumn("dbo.ClinicalHistories", "IntraoralExaminationTonsils", c => c.String());
            AddColumn("dbo.ClinicalHistories", "IntraoralExaminationHardPalate", c => c.String());
            AddColumn("dbo.ClinicalHistories", "IntraoralExaminationSoftPalate", c => c.String());
            AddColumn("dbo.ClinicalHistories", "RightTerminalPlane", c => c.String());
            AddColumn("dbo.ClinicalHistories", "LeftTerminalPlane", c => c.String());
            AddColumn("dbo.ClinicalHistories", "RightMolarClass", c => c.String());
            AddColumn("dbo.ClinicalHistories", "LeftMolarClass", c => c.String());
            AddColumn("dbo.ClinicalHistories", "RightCanineClass", c => c.String());
            AddColumn("dbo.ClinicalHistories", "LeftCanineClass", c => c.String());
            AddColumn("dbo.ClinicalHistories", "Overbite", c => c.String());
            AddColumn("dbo.ClinicalHistories", "Overjet", c => c.String());
            AddColumn("dbo.ClinicalHistories", "UpperArchShape", c => c.String());
            AddColumn("dbo.ClinicalHistories", "InnerArchShape", c => c.String());
            AddColumn("dbo.ClinicalHistories", "Habits", c => c.String());
            AddColumn("dbo.ClinicalHistories", "FingerSucking", c => c.Boolean(nullable: false));
            AddColumn("dbo.ClinicalHistories", "FingerSuckingFrequency", c => c.String());
            AddColumn("dbo.ClinicalHistories", "FingerSuckingIntensity", c => c.String());
            AddColumn("dbo.ClinicalHistories", "FingerSuckingTime", c => c.String());
            AddColumn("dbo.ClinicalHistories", "AtypicalSwallowing", c => c.Boolean(nullable: false));
            AddColumn("dbo.ClinicalHistories", "AtypicalSwallowingFrequency", c => c.String());
            AddColumn("dbo.ClinicalHistories", "AtypicalSwallowingIntensity", c => c.String());
            AddColumn("dbo.ClinicalHistories", "AtypicalSwallowingTime", c => c.String());
            AddColumn("dbo.ClinicalHistories", "Bruxism", c => c.Boolean(nullable: false));
            AddColumn("dbo.ClinicalHistories", "BruxismFrequency", c => c.String());
            AddColumn("dbo.ClinicalHistories", "BruxismIntensity", c => c.String());
            AddColumn("dbo.ClinicalHistories", "BruxismTime", c => c.String());
            AddColumn("dbo.ClinicalHistories", "OralBreathing", c => c.Boolean(nullable: false));
            AddColumn("dbo.ClinicalHistories", "OralBreathingFrequency", c => c.String());
            AddColumn("dbo.ClinicalHistories", "OralBreathingIntensity", c => c.String());
            AddColumn("dbo.ClinicalHistories", "OralBreathingTime", c => c.String());
            AddColumn("dbo.ClinicalHistories", "Onychophagia", c => c.Boolean(nullable: false));
            AddColumn("dbo.ClinicalHistories", "OnychophagiaFrequency", c => c.String());
            AddColumn("dbo.ClinicalHistories", "OnychophagiaIntensity", c => c.String());
            AddColumn("dbo.ClinicalHistories", "OnychophagiaTime", c => c.String());
            AddColumn("dbo.ClinicalHistories", "DentalAnomalies", c => c.String());
            AddColumn("dbo.ClinicalHistories", "RadiographicFindings", c => c.String());
            AddColumn("dbo.ClinicalHistories", "DiagnosticImpressionCurrentCondition", c => c.String());
            AddColumn("dbo.ClinicalHistories", "PatientCooperationDuringScan", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClinicalHistories", "PatientCooperationDuringScan");
            DropColumn("dbo.ClinicalHistories", "DiagnosticImpressionCurrentCondition");
            DropColumn("dbo.ClinicalHistories", "RadiographicFindings");
            DropColumn("dbo.ClinicalHistories", "DentalAnomalies");
            DropColumn("dbo.ClinicalHistories", "OnychophagiaTime");
            DropColumn("dbo.ClinicalHistories", "OnychophagiaIntensity");
            DropColumn("dbo.ClinicalHistories", "OnychophagiaFrequency");
            DropColumn("dbo.ClinicalHistories", "Onychophagia");
            DropColumn("dbo.ClinicalHistories", "OralBreathingTime");
            DropColumn("dbo.ClinicalHistories", "OralBreathingIntensity");
            DropColumn("dbo.ClinicalHistories", "OralBreathingFrequency");
            DropColumn("dbo.ClinicalHistories", "OralBreathing");
            DropColumn("dbo.ClinicalHistories", "BruxismTime");
            DropColumn("dbo.ClinicalHistories", "BruxismIntensity");
            DropColumn("dbo.ClinicalHistories", "BruxismFrequency");
            DropColumn("dbo.ClinicalHistories", "Bruxism");
            DropColumn("dbo.ClinicalHistories", "AtypicalSwallowingTime");
            DropColumn("dbo.ClinicalHistories", "AtypicalSwallowingIntensity");
            DropColumn("dbo.ClinicalHistories", "AtypicalSwallowingFrequency");
            DropColumn("dbo.ClinicalHistories", "AtypicalSwallowing");
            DropColumn("dbo.ClinicalHistories", "FingerSuckingTime");
            DropColumn("dbo.ClinicalHistories", "FingerSuckingIntensity");
            DropColumn("dbo.ClinicalHistories", "FingerSuckingFrequency");
            DropColumn("dbo.ClinicalHistories", "FingerSucking");
            DropColumn("dbo.ClinicalHistories", "Habits");
            DropColumn("dbo.ClinicalHistories", "InnerArchShape");
            DropColumn("dbo.ClinicalHistories", "UpperArchShape");
            DropColumn("dbo.ClinicalHistories", "Overjet");
            DropColumn("dbo.ClinicalHistories", "Overbite");
            DropColumn("dbo.ClinicalHistories", "LeftCanineClass");
            DropColumn("dbo.ClinicalHistories", "RightCanineClass");
            DropColumn("dbo.ClinicalHistories", "LeftMolarClass");
            DropColumn("dbo.ClinicalHistories", "RightMolarClass");
            DropColumn("dbo.ClinicalHistories", "LeftTerminalPlane");
            DropColumn("dbo.ClinicalHistories", "RightTerminalPlane");
            DropColumn("dbo.ClinicalHistories", "IntraoralExaminationSoftPalate");
            DropColumn("dbo.ClinicalHistories", "IntraoralExaminationHardPalate");
            DropColumn("dbo.ClinicalHistories", "IntraoralExaminationTonsils");
            DropColumn("dbo.ClinicalHistories", "IntraoralExaminationBraces");
        }
    }
}
