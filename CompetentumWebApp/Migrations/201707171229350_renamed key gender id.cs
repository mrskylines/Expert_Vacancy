namespace CompetentumWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renamedkeygenderid : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Resumes", name: "GenderId", newName: "Gender_Id");
            RenameIndex(table: "dbo.Resumes", name: "IX_GenderId", newName: "IX_Gender_Id");
            AddColumn("dbo.Resumes", "GenderUserId", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Resumes", "GenderUserId");
            RenameIndex(table: "dbo.Resumes", name: "IX_Gender_Id", newName: "IX_GenderId");
            RenameColumn(table: "dbo.Resumes", name: "Gender_Id", newName: "GenderId");
        }
    }
}
