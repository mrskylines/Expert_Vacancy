namespace CompetentumWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Currencies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CurrencyName = c.String(),
                        CurrencyAbbr = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Resumes", "CurrencyId", c => c.Int());
            CreateIndex("dbo.Resumes", "CurrencyId");
            AddForeignKey("dbo.Resumes", "CurrencyId", "dbo.Currencies", "Id");
            DropColumn("dbo.Resumes", "SalaryCurrency");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Resumes", "SalaryCurrency", c => c.String());
            DropForeignKey("dbo.Resumes", "CurrencyId", "dbo.Currencies");
            DropIndex("dbo.Resumes", new[] { "CurrencyId" });
            DropColumn("dbo.Resumes", "CurrencyId");
            DropTable("dbo.Currencies");
        }
    }
}
