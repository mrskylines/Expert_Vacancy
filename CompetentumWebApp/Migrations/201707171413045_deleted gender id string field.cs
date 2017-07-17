namespace CompetentumWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedgenderidstringfield : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Resumes", "GenderId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Resumes", "GenderId", c => c.String());
        }
    }
}
