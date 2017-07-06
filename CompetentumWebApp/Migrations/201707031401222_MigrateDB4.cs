namespace CompetentumWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Resumes", "StateDate", c => c.String());
            AddColumn("dbo.Resumes", "InterviewDate", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Resumes", "InterviewDate");
            DropColumn("dbo.Resumes", "StateDate");
        }
    }
}
