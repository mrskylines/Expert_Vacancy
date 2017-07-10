namespace CompetentumWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB10 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Resumes", "StateId", "dbo.States");
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GenderName = c.String(),
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
            
            AddColumn("dbo.Resumes", "SourceId", c => c.Int());
            AddColumn("dbo.Resumes", "GenderId", c => c.Int());
            AddColumn("dbo.Resumes", "State_Id", c => c.Int());
            CreateIndex("dbo.Resumes", "SourceId");
            CreateIndex("dbo.Resumes", "GenderId");
            CreateIndex("dbo.Resumes", "State_Id");
            AddForeignKey("dbo.Resumes", "GenderId", "dbo.Genders", "Id");
            AddForeignKey("dbo.Resumes", "SourceId", "dbo.States", "Id");
            AddForeignKey("dbo.Resumes", "SourceId", "dbo.Sources", "Id");
            AddForeignKey("dbo.Resumes", "State_Id", "dbo.States", "Id");
            DropColumn("dbo.Resumes", "Source");
            DropColumn("dbo.Resumes", "gender_Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Resumes", "gender_Name", c => c.String());
            AddColumn("dbo.Resumes", "Source", c => c.String());
            DropForeignKey("dbo.Resumes", "State_Id", "dbo.States");
            DropForeignKey("dbo.Resumes", "SourceId", "dbo.Sources");
            DropForeignKey("dbo.Resumes", "SourceId", "dbo.States");
            DropForeignKey("dbo.Resumes", "GenderId", "dbo.Genders");
            DropIndex("dbo.Resumes", new[] { "State_Id" });
            DropIndex("dbo.Resumes", new[] { "GenderId" });
            DropIndex("dbo.Resumes", new[] { "SourceId" });
            DropColumn("dbo.Resumes", "State_Id");
            DropColumn("dbo.Resumes", "GenderId");
            DropColumn("dbo.Resumes", "SourceId");
            DropTable("dbo.Sources");
            DropTable("dbo.Genders");
            AddForeignKey("dbo.Resumes", "StateId", "dbo.States", "Id");
        }
    }
}
