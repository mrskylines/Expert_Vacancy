namespace CompetentumWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixedvacancytablekey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Resumes", "VacancyStateId", "dbo.VacancyStates");
            DropIndex("dbo.Resumes", new[] { "VacancyStateId" });
            DropColumn("dbo.Resumes", "VacancyStateId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Resumes", "VacancyStateId", c => c.Int());
            CreateIndex("dbo.Resumes", "VacancyStateId");
            AddForeignKey("dbo.Resumes", "VacancyStateId", "dbo.VacancyStates", "Id");
        }
    }
}
