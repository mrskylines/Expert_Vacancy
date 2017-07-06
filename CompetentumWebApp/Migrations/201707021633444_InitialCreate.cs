namespace CompetentumWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Resumes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        last_name = c.String(),
                        first_name = c.String(),
                        middle_name = c.String(),
                        age = c.Int(nullable: false),
                        birth_date = c.String(),
                        CityName = c.String(),
                        MetroName = c.String(),
                        RelocationName = c.String(),
                        IsTripReadyName = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Resumes");
        }
    }
}
