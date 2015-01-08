namespace AwakenYourSmile.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClinicalHistory1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClinicalHistories",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(),
                        NickName = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.Int(),
                        BirthDate = c.DateTime(),
                        Address = c.String(),
                        Address2 = c.String(),
                        CityState = c.String(),
                        PhoneNumber = c.String(),
                        School = c.String(),
                        FatherName = c.String(),
                        FatherPhoneNumber = c.String(),
                        FatherOccupation = c.String(),
                        FatherEmail = c.String(),
                        MotherName = c.String(),
                        MotherPhoneNumber = c.String(),
                        MotherOccupation = c.String(),
                        MotherEmail = c.String(),
                        ReasonForVisit = c.String(),
                        ReasonOther = c.String(),
                        RecommendedBy = c.String(),
                        FirstVisit = c.Boolean(nullable: false),
                        FirstVisitReason = c.String(),
                        PreviousVisitExperience = c.Int(nullable: false),
                        ReactionToPreviousVisits = c.Int(nullable: false),
                        AnxietyGrade = c.Int(nullable: false),
                        ExpectedReactionGrade = c.Int(nullable: false),
                        PerformanceAtSchool = c.Int(nullable: false),
                        Motivation = c.String(),
                        HasBeenAnesthetized = c.Boolean(nullable: false),
                        AdverseReactionToAnesthesia = c.Boolean(nullable: false),
                        ReactionToAnesthesia = c.String(),
                        SelfCleaningTooth = c.Boolean(nullable: false),
                        CleaningTimes = c.Int(nullable: false),
                        UsedPacifier = c.Boolean(nullable: false),
                        UsedBabyBottle = c.Boolean(nullable: false),
                        Thumbsucking = c.Boolean(nullable: false),
                        BitingNails = c.Boolean(nullable: false),
                        HabitsDetails = c.String(),
                        BreastFed = c.Boolean(nullable: false),
                        BreastFedDetails = c.String(),
                        FeedingType = c.Int(nullable: false),
                        ImmunizationsBox = c.String(),
                        Room = c.String(),
                        PregnacyBirthProblems = c.Boolean(nullable: false),
                        OverallHealth = c.Int(nullable: false),
                        Allergic = c.Boolean(nullable: false),
                        SpontaneousBleedingNose = c.Boolean(nullable: false),
                        SpontaneousBleedingNoseDate = c.DateTime(nullable: false),
                        SpontaneousBleedingNoseReason = c.String(),
                        ReceivedBloodTransfusions = c.Boolean(nullable: false),
                        BloodTransfusionsDate = c.DateTime(nullable: false),
                        BloodTransfusionsReason = c.String(),
                        Hospitalized = c.Boolean(nullable: false),
                        HospitalizedDate = c.Boolean(nullable: false),
                        HospitalizedReason = c.Boolean(nullable: false),
                        Medicated = c.Boolean(nullable: false),
                        MedicatedDate = c.Boolean(nullable: false),
                        MedicatedReason = c.Boolean(nullable: false),
                        Prescribed = c.Boolean(nullable: false),
                        PrescribedDate = c.Boolean(nullable: false),
                        PrescribedReason = c.Boolean(nullable: false),
                        Measles = c.Boolean(nullable: false),
                        Asthma = c.Boolean(nullable: false),
                        RenalDisease = c.Boolean(nullable: false),
                        HeartDisease = c.Boolean(nullable: false),
                        ChickenPox = c.Boolean(nullable: false),
                        Leukemia = c.Boolean(nullable: false),
                        Anemia = c.Boolean(nullable: false),
                        Diabetes = c.Boolean(nullable: false),
                        Hepatitis = c.Boolean(nullable: false),
                        Hemophilia = c.Boolean(nullable: false),
                        Hiv = c.Boolean(nullable: false),
                        Epilepsy = c.Boolean(nullable: false),
                        Hereditaries = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        LastUpdated = c.DateTime(),
                        LastUpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ClinicalHistories");
        }
    }
}
