namespace CompetentumWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Resumes", "Commentary", c => c.String());
            AddColumn("dbo.Resumes", "gender_Name", c => c.String());
            DropColumn("dbo.Resumes", "age");
            DropColumn("dbo.Resumes", "RelocationName");
            DropColumn("dbo.Resumes", "IsTripReadyName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Resumes", "IsTripReadyName", c => c.String());
            AddColumn("dbo.Resumes", "RelocationName", c => c.String());
            AddColumn("dbo.Resumes", "age", c => c.Int(nullable: false));
            DropColumn("dbo.Resumes", "gender_Name");
            DropColumn("dbo.Resumes", "Commentary");
        }
    }
}
