namespace CompetentumWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedmanytomanyexperiencejob : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExperienceJobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExperienceJobName = c.String(),
                        ExperienceJobPosition = c.String(),
                        ExperienceJobStart = c.String(),
                        ExperienceJobEnd = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ExperienceJobResumes",
                c => new
                    {
                        ExperienceJob_Id = c.Int(nullable: false),
                        Resume_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ExperienceJob_Id, t.Resume_Id })
                .ForeignKey("dbo.ExperienceJobs", t => t.ExperienceJob_Id, cascadeDelete: true)
                .ForeignKey("dbo.Resumes", t => t.Resume_Id, cascadeDelete: true)
                .Index(t => t.ExperienceJob_Id)
                .Index(t => t.Resume_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExperienceJobResumes", "Resume_Id", "dbo.Resumes");
            DropForeignKey("dbo.ExperienceJobResumes", "ExperienceJob_Id", "dbo.ExperienceJobs");
            DropIndex("dbo.ExperienceJobResumes", new[] { "Resume_Id" });
            DropIndex("dbo.ExperienceJobResumes", new[] { "ExperienceJob_Id" });
            DropTable("dbo.ExperienceJobResumes");
            DropTable("dbo.ExperienceJobs");
        }
    }
}
