namespace CompetentumWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedVacancytable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vacancies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VacancyName = c.String(),
                        VacancyStateId = c.Int(),
                        VacancyCreationDate = c.String(),
                        VacancyInitiator = c.String(),
                        VacancyRegion = c.String(),
                        VacancyGroup = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.VacancyStates", t => t.VacancyStateId)
                .Index(t => t.VacancyStateId);
            
            CreateTable(
                "dbo.VacancyStates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VacancyStateName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VacancyResumes",
                c => new
                    {
                        Vacancy_Id = c.Int(nullable: false),
                        Resume_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Vacancy_Id, t.Resume_Id })
                .ForeignKey("dbo.Vacancies", t => t.Vacancy_Id, cascadeDelete: true)
                .ForeignKey("dbo.Resumes", t => t.Resume_Id, cascadeDelete: true)
                .Index(t => t.Vacancy_Id)
                .Index(t => t.Resume_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vacancies", "VacancyStateId", "dbo.VacancyStates");
            DropForeignKey("dbo.VacancyResumes", "Resume_Id", "dbo.Resumes");
            DropForeignKey("dbo.VacancyResumes", "Vacancy_Id", "dbo.Vacancies");
            DropIndex("dbo.VacancyResumes", new[] { "Resume_Id" });
            DropIndex("dbo.VacancyResumes", new[] { "Vacancy_Id" });
            DropIndex("dbo.Vacancies", new[] { "VacancyStateId" });
            DropTable("dbo.VacancyResumes");
            DropTable("dbo.VacancyStates");
            DropTable("dbo.Vacancies");
        }
    }
}
