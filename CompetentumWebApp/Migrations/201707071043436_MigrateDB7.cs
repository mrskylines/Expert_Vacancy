namespace CompetentumWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB7 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.languages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        list_id = c.String(),
                        list_name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Resumes", "languageId", c => c.Int());
            CreateIndex("dbo.Resumes", "languageId");
            AddForeignKey("dbo.Resumes", "languageId", "dbo.languages", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Resumes", "languageId", "dbo.languages");
            DropIndex("dbo.Resumes", new[] { "languageId" });
            DropColumn("dbo.Resumes", "languageId");
            DropTable("dbo.languages");
        }
    }
}
