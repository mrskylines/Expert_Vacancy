namespace CompetentumWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedtablecommentaries : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Commentaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CommentaryText = c.String(),
                        CommentaryDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Resumes", "CommentaryId", c => c.Int());
            CreateIndex("dbo.Resumes", "CommentaryId");
            AddForeignKey("dbo.Resumes", "CommentaryId", "dbo.Commentaries", "Id");
            DropColumn("dbo.Resumes", "Commentary");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Resumes", "Commentary", c => c.String());
            DropForeignKey("dbo.Resumes", "CommentaryId", "dbo.Commentaries");
            DropIndex("dbo.Resumes", new[] { "CommentaryId" });
            DropColumn("dbo.Resumes", "CommentaryId");
            DropTable("dbo.Commentaries");
        }
    }
}
