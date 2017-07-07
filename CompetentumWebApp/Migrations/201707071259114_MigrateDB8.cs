namespace CompetentumWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB8 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Resumes", "EmploymentName_Id", "dbo.EmploymentNames");
            DropIndex("dbo.Resumes", new[] { "EmploymentName_Id" });
            AddColumn("dbo.Resumes", "EmploymentName_Id1", c => c.Int());
            CreateIndex("dbo.Resumes", "EmploymentName_Id1");
            AddForeignKey("dbo.Resumes", "EmploymentName_Id1", "dbo.EmploymentNames", "Id");
            DropColumn("dbo.Resumes", "EmploymentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Resumes", "EmploymentId", c => c.Int());
            DropForeignKey("dbo.Resumes", "EmploymentName_Id1", "dbo.EmploymentNames");
            DropIndex("dbo.Resumes", new[] { "EmploymentName_Id1" });
            DropColumn("dbo.Resumes", "EmploymentName_Id1");
            CreateIndex("dbo.Resumes", "EmploymentName_Id");
            AddForeignKey("dbo.Resumes", "EmploymentName_Id", "dbo.EmploymentNames", "Id");
        }
    }
}
