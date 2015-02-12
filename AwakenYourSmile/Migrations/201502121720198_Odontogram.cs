namespace AwakenYourSmile.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Odontogram : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Odontograms",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Reference = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        LastUpdated = c.DateTime(),
                        LastUpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Odontograms");
        }
    }
}
