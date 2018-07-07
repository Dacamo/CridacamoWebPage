namespace CridacamoWebPage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fkposts : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Posts", "Author", "dbo.AspNetUsers");
            DropIndex("dbo.Posts", new[] { "Author" });
            AlterColumn("dbo.Posts", "Author", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Posts", "Author");
            AddForeignKey("dbo.Posts", "Author", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "Author", "dbo.AspNetUsers");
            DropIndex("dbo.Posts", new[] { "Author" });
            AlterColumn("dbo.Posts", "Author", c => c.String(maxLength: 128));
            CreateIndex("dbo.Posts", "Author");
            AddForeignKey("dbo.Posts", "Author", "dbo.AspNetUsers", "Id");
        }
    }
}
