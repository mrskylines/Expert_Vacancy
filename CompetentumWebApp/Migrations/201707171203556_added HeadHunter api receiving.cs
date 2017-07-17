namespace CompetentumWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedHeadHunterapireceiving : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Resumes", "SalaryAmount", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Resumes", "SalaryAmount", c => c.Int(nullable: false));
        }
    }
}
