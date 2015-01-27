namespace Rainbow.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixingIssue : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UploadedFiles",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ApplicationName = c.String(),
                        ParentID = c.Guid(),
                        FileName = c.String(),
                        Description = c.String(),
                        Data = c.Binary(),
                        ContentType = c.String(),
                        ContentLength = c.Int(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        LastUpdated = c.DateTime(),
                        LastUpdatedBy = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UploadedFiles");
        }
    }
}
