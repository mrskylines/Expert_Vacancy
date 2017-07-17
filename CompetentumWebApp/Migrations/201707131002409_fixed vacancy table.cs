namespace CompetentumWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixedvacancytable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Resumes", "VacancyStateId", c => c.Int());
            CreateIndex("dbo.Resumes", "VacancyStateId");
            AddForeignKey("dbo.Resumes", "VacancyStateId", "dbo.VacancyStates", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Resumes", "VacancyStateId", "dbo.VacancyStates");
            DropIndex("dbo.Resumes", new[] { "VacancyStateId" });
            DropColumn("dbo.Resumes", "VacancyStateId");
        }
    }
}
