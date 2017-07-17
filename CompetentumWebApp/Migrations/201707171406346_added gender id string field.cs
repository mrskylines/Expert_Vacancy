namespace CompetentumWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedgenderidstringfield : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Resumes", "GenderId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Resumes", "GenderId");
        }
    }
}
