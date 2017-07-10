namespace CompetentumWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.educationalLevels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Id_name = c.String(),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EmploymentNames",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Id_name = c.String(),
                        Employement_Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.languageLevels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Id_name = c.String(),
                        Level_name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Id_name = c.String(),
                        ScheduleName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Resumes", "EmploymentId", c => c.Int());
            AddColumn("dbo.Resumes", "ScheduleId", c => c.Int());
            AddColumn("dbo.Resumes", "educationalLevelId", c => c.Int());
            AddColumn("dbo.Resumes", "languageLevelId", c => c.Int());
            AddColumn("dbo.Resumes", "EmploymentName_Id", c => c.Int());
            CreateIndex("dbo.Resumes", "ScheduleId");
            CreateIndex("dbo.Resumes", "educationalLevelId");
            CreateIndex("dbo.Resumes", "languageLevelId");
            CreateIndex("dbo.Resumes", "EmploymentName_Id");
            AddForeignKey("dbo.Resumes", "educationalLevelId", "dbo.educationalLevels", "Id");
            AddForeignKey("dbo.Resumes", "EmploymentName_Id", "dbo.EmploymentNames", "Id");
            AddForeignKey("dbo.Resumes", "languageLevelId", "dbo.languageLevels", "Id");
            AddForeignKey("dbo.Resumes", "ScheduleId", "dbo.Schedules", "Id");
            DropColumn("dbo.Resumes", "EmploymentName");
            DropColumn("dbo.Resumes", "ScheduleName");
            DropColumn("dbo.Resumes", "ElementaryName");
            DropColumn("dbo.Resumes", "ElementaryYear");
            DropColumn("dbo.Resumes", "PrimaryName");
            DropColumn("dbo.Resumes", "PrimaryOrganization");
            DropColumn("dbo.Resumes", "PrimaryResult");
            DropColumn("dbo.Resumes", "PrimaryYear");
            DropColumn("dbo.Resumes", "LevelName");
            DropColumn("dbo.Resumes", "LanguageName");
            DropColumn("dbo.Resumes", "LanguageLevel");
            DropColumn("dbo.Resumes", "IndustryAreaName");
            DropColumn("dbo.Resumes", "IndustryName");
            DropColumn("dbo.Resumes", "ExperienceStart");
            DropColumn("dbo.Resumes", "ExperienceEnd");
            DropColumn("dbo.Resumes", "ExperienceDescription");
            DropColumn("dbo.Resumes", "CitizenshipName");
            DropColumn("dbo.Resumes", "WorkTicketName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Resumes", "WorkTicketName", c => c.String());
            AddColumn("dbo.Resumes", "CitizenshipName", c => c.String());
            AddColumn("dbo.Resumes", "ExperienceDescription", c => c.String());
            AddColumn("dbo.Resumes", "ExperienceEnd", c => c.String());
            AddColumn("dbo.Resumes", "ExperienceStart", c => c.String());
            AddColumn("dbo.Resumes", "IndustryName", c => c.String());
            AddColumn("dbo.Resumes", "IndustryAreaName", c => c.String());
            AddColumn("dbo.Resumes", "LanguageLevel", c => c.String());
            AddColumn("dbo.Resumes", "LanguageName", c => c.String());
            AddColumn("dbo.Resumes", "LevelName", c => c.String());
            AddColumn("dbo.Resumes", "PrimaryYear", c => c.Int(nullable: false));
            AddColumn("dbo.Resumes", "PrimaryResult", c => c.String());
            AddColumn("dbo.Resumes", "PrimaryOrganization", c => c.String());
            AddColumn("dbo.Resumes", "PrimaryName", c => c.String());
            AddColumn("dbo.Resumes", "ElementaryYear", c => c.Int(nullable: false));
            AddColumn("dbo.Resumes", "ElementaryName", c => c.String());
            AddColumn("dbo.Resumes", "ScheduleName", c => c.String());
            AddColumn("dbo.Resumes", "EmploymentName", c => c.String());
            DropForeignKey("dbo.Resumes", "ScheduleId", "dbo.Schedules");
            DropForeignKey("dbo.Resumes", "languageLevelId", "dbo.languageLevels");
            DropForeignKey("dbo.Resumes", "EmploymentName_Id", "dbo.EmploymentNames");
            DropForeignKey("dbo.Resumes", "educationalLevelId", "dbo.educationalLevels");
            DropIndex("dbo.Resumes", new[] { "EmploymentName_Id" });
            DropIndex("dbo.Resumes", new[] { "languageLevelId" });
            DropIndex("dbo.Resumes", new[] { "educationalLevelId" });
            DropIndex("dbo.Resumes", new[] { "ScheduleId" });
            DropColumn("dbo.Resumes", "EmploymentName_Id");
            DropColumn("dbo.Resumes", "languageLevelId");
            DropColumn("dbo.Resumes", "educationalLevelId");
            DropColumn("dbo.Resumes", "ScheduleId");
            DropColumn("dbo.Resumes", "EmploymentId");
            DropTable("dbo.Schedules");
            DropTable("dbo.languageLevels");
            DropTable("dbo.EmploymentNames");
            DropTable("dbo.educationalLevels");
        }
    }
}
