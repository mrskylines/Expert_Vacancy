namespace CompetentumWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Resumes", "profarea_name", c => c.String());
            AddColumn("dbo.Resumes", "SalaryAmount", c => c.Int(nullable: false));
            AddColumn("dbo.Resumes", "SalaryCurrency", c => c.String());
            AddColumn("dbo.Resumes", "EmploymentName", c => c.String());
            AddColumn("dbo.Resumes", "ScheduleName", c => c.String());
            AddColumn("dbo.Resumes", "ElementaryName", c => c.String());
            AddColumn("dbo.Resumes", "ElementaryYear", c => c.Int(nullable: false));
            AddColumn("dbo.Resumes", "PrimaryName", c => c.String());
            AddColumn("dbo.Resumes", "PrimaryOrganization", c => c.String());
            AddColumn("dbo.Resumes", "PrimaryResult", c => c.String());
            AddColumn("dbo.Resumes", "PrimaryYear", c => c.Int(nullable: false));
            AddColumn("dbo.Resumes", "LevelName", c => c.String());
            AddColumn("dbo.Resumes", "LanguageName", c => c.String());
            AddColumn("dbo.Resumes", "LanguageLevel", c => c.String());
            AddColumn("dbo.Resumes", "IndustryAreaName", c => c.String());
            AddColumn("dbo.Resumes", "IndustryName", c => c.String());
            AddColumn("dbo.Resumes", "ExperienceCompany", c => c.String());
            AddColumn("dbo.Resumes", "ExperiencePosition", c => c.String());
            AddColumn("dbo.Resumes", "ExperienceStart", c => c.String());
            AddColumn("dbo.Resumes", "ExperienceEnd", c => c.String());
            AddColumn("dbo.Resumes", "ExperienceDescription", c => c.String());
            AddColumn("dbo.Resumes", "skills", c => c.String());
            AddColumn("dbo.Resumes", "CitizenshipName", c => c.String());
            AddColumn("dbo.Resumes", "WorkTicketName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Resumes", "WorkTicketName");
            DropColumn("dbo.Resumes", "CitizenshipName");
            DropColumn("dbo.Resumes", "skills");
            DropColumn("dbo.Resumes", "ExperienceDescription");
            DropColumn("dbo.Resumes", "ExperienceEnd");
            DropColumn("dbo.Resumes", "ExperienceStart");
            DropColumn("dbo.Resumes", "ExperiencePosition");
            DropColumn("dbo.Resumes", "ExperienceCompany");
            DropColumn("dbo.Resumes", "IndustryName");
            DropColumn("dbo.Resumes", "IndustryAreaName");
            DropColumn("dbo.Resumes", "LanguageLevel");
            DropColumn("dbo.Resumes", "LanguageName");
            DropColumn("dbo.Resumes", "LevelName");
            DropColumn("dbo.Resumes", "PrimaryYear");
            DropColumn("dbo.Resumes", "PrimaryResult");
            DropColumn("dbo.Resumes", "PrimaryOrganization");
            DropColumn("dbo.Resumes", "PrimaryName");
            DropColumn("dbo.Resumes", "ElementaryYear");
            DropColumn("dbo.Resumes", "ElementaryName");
            DropColumn("dbo.Resumes", "ScheduleName");
            DropColumn("dbo.Resumes", "EmploymentName");
            DropColumn("dbo.Resumes", "SalaryCurrency");
            DropColumn("dbo.Resumes", "SalaryAmount");
            DropColumn("dbo.Resumes", "profarea_name");
        }
    }
}
