namespace AwakenYourSmile.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Odontogram1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Odontograms", "Treatment", c => c.String());
            AddColumn("dbo.Odontograms", "Notes", c => c.String());
            DropColumn("dbo.Odontograms", "Reference");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Odontograms", "Reference", c => c.String());
            DropColumn("dbo.Odontograms", "Notes");
            DropColumn("dbo.Odontograms", "Treatment");
        }
    }
}
