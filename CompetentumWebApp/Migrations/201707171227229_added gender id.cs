namespace CompetentumWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedgenderid : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Genders", "GenderId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Genders", "GenderId");
        }
    }
}
