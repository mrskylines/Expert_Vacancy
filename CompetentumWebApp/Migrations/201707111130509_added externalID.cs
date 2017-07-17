namespace CompetentumWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedexternalID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Resumes", "ExternalId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Resumes", "ExternalId");
        }
    }
}
