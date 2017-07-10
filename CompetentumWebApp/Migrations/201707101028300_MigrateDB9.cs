namespace CompetentumWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB9 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Resumes", name: "EmploymentName_Id1", newName: "EmploymentNameId");
            RenameIndex(table: "dbo.Resumes", name: "IX_EmploymentName_Id1", newName: "IX_EmploymentNameId");
            DropColumn("dbo.Resumes", "EmploymentName_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Resumes", "EmploymentName_Id", c => c.Int());
            RenameIndex(table: "dbo.Resumes", name: "IX_EmploymentNameId", newName: "IX_EmploymentName_Id1");
            RenameColumn(table: "dbo.Resumes", name: "EmploymentNameId", newName: "EmploymentName_Id1");
        }
    }
}
