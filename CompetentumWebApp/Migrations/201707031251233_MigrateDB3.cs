namespace CompetentumWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.States",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StateName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Resumes", "Source", c => c.String());
            AddColumn("dbo.Resumes", "StateId", c => c.Int());
            CreateIndex("dbo.Resumes", "StateId");
            AddForeignKey("dbo.Resumes", "StateId", "dbo.States", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Resumes", "StateId", "dbo.States");
            DropIndex("dbo.Resumes", new[] { "StateId" });
            DropColumn("dbo.Resumes", "StateId");
            DropColumn("dbo.Resumes", "Source");
            DropTable("dbo.States");
        }
    }
}
