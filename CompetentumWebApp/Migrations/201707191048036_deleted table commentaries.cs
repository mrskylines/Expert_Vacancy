namespace CompetentumWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedtablecommentaries : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Resumes", "CommentaryId", "dbo.Commentaries");
            DropIndex("dbo.Resumes", new[] { "CommentaryId" });
            AddColumn("dbo.Resumes", "Commentary", c => c.String());
            DropColumn("dbo.Resumes", "CommentaryId");
            DropTable("dbo.Commentaries");
        }
        
        public override void Down()
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
            DropColumn("dbo.Resumes", "Commentary");
            CreateIndex("dbo.Resumes", "CommentaryId");
            AddForeignKey("dbo.Resumes", "CommentaryId", "dbo.Commentaries", "Id");
        }
    }
}
