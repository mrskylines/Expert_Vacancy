namespace CompetentumWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Resumes", "SpecializationName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Resumes", "SpecializationName");
        }
    }
}
