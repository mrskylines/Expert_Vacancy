namespace CompetentumWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Currencies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CurrencyName = c.String(),
                        CurrencyAbbr = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Resumes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SourceId = c.Int(),
                        StateId = c.Int(),
                        StateDate = c.String(),
                        InterviewDate = c.String(),
                        Commentary = c.String(),
                        ResumeId = c.String(),
                        last_name = c.String(),
                        first_name = c.String(),
                        middle_name = c.String(),
                        GenderId = c.Int(),
                        birth_date = c.String(),
                        CityName = c.String(),
                        MetroName = c.String(),
                        PhoneNumber = c.String(),
                        SpecializationName = c.String(),
                        profarea_name = c.String(),
                        SalaryAmount = c.Int(nullable: false),
                        CurrencyId = c.Int(),
                        EmploymentNameId = c.Int(),
                        ScheduleId = c.Int(),
                        educationalLevelId = c.Int(),
                        languageId = c.Int(),
                        languageLevelId = c.Int(),
                        ExperienceCompany = c.String(),
                        ExperiencePosition = c.String(),
                        skills = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Currencies", t => t.CurrencyId)
                .ForeignKey("dbo.educationalLevels", t => t.educationalLevelId)
                .ForeignKey("dbo.EmploymentNames", t => t.EmploymentNameId)
                .ForeignKey("dbo.Genders", t => t.GenderId)
                .ForeignKey("dbo.languages", t => t.languageId)
                .ForeignKey("dbo.languageLevels", t => t.languageLevelId)
                .ForeignKey("dbo.Schedules", t => t.ScheduleId)
                .ForeignKey("dbo.Sources", t => t.SourceId)
                .ForeignKey("dbo.States", t => t.StateId)
                .Index(t => t.SourceId)
                .Index(t => t.StateId)
                .Index(t => t.GenderId)
                .Index(t => t.CurrencyId)
                .Index(t => t.EmploymentNameId)
                .Index(t => t.ScheduleId)
                .Index(t => t.educationalLevelId)
                .Index(t => t.languageId)
                .Index(t => t.languageLevelId);
            
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
                "dbo.Genders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GenderName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.languages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        list_id = c.String(),
                        list_name = c.String(),
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
            
            CreateTable(
                "dbo.Sources",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SourceName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StateName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Resumes", "StateId", "dbo.States");
            DropForeignKey("dbo.Resumes", "SourceId", "dbo.Sources");
            DropForeignKey("dbo.Resumes", "ScheduleId", "dbo.Schedules");
            DropForeignKey("dbo.Resumes", "languageLevelId", "dbo.languageLevels");
            DropForeignKey("dbo.Resumes", "languageId", "dbo.languages");
            DropForeignKey("dbo.Resumes", "GenderId", "dbo.Genders");
            DropForeignKey("dbo.Resumes", "EmploymentNameId", "dbo.EmploymentNames");
            DropForeignKey("dbo.Resumes", "educationalLevelId", "dbo.educationalLevels");
            DropForeignKey("dbo.Resumes", "CurrencyId", "dbo.Currencies");
            DropIndex("dbo.Resumes", new[] { "languageLevelId" });
            DropIndex("dbo.Resumes", new[] { "languageId" });
            DropIndex("dbo.Resumes", new[] { "educationalLevelId" });
            DropIndex("dbo.Resumes", new[] { "ScheduleId" });
            DropIndex("dbo.Resumes", new[] { "EmploymentNameId" });
            DropIndex("dbo.Resumes", new[] { "CurrencyId" });
            DropIndex("dbo.Resumes", new[] { "GenderId" });
            DropIndex("dbo.Resumes", new[] { "StateId" });
            DropIndex("dbo.Resumes", new[] { "SourceId" });
            DropTable("dbo.States");
            DropTable("dbo.Sources");
            DropTable("dbo.Schedules");
            DropTable("dbo.languageLevels");
            DropTable("dbo.languages");
            DropTable("dbo.Genders");
            DropTable("dbo.EmploymentNames");
            DropTable("dbo.educationalLevels");
            DropTable("dbo.Resumes");
            DropTable("dbo.Currencies");
        }
    }
}
