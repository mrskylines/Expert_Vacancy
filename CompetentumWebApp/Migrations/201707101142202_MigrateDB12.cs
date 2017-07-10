namespace CompetentumWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB12 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Resumes", new[] { "State_Id" });
            DropColumn("dbo.Resumes", "StateId");
            RenameColumn(table: "dbo.Resumes", name: "State_Id", newName: "StateId");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Resumes", name: "StateId", newName: "State_Id");
            AddColumn("dbo.Resumes", "StateId", c => c.Int());
            CreateIndex("dbo.Resumes", "State_Id");
        }
    }
}
