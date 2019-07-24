namespace irakligdev.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial_migration : DbMigration
    {
        public override void Up()
        {

            CreateTable(
                "dbo.Words_EN",
                c => new
                {
                    Guid = c.Guid(nullable: false),
                    Word = c.String(nullable: false),
                })
                .PrimaryKey(t => t.Guid);


            CreateTable(
                "dbo.Words_KR",
                c => new
                {
                    Guid = c.Guid(nullable: false),
                    Word = c.String(nullable: false),
                })
                .PrimaryKey(t => t.Guid);


            CreateTable(
                "dbo.Words_Relation",
                c => new
                {
                    Guid = c.Guid(nullable: false),
                    Word_EN_Guid = c.Guid(nullable: false),
                    Word_KR_Guid = c.Guid(nullable: false),
                })
                .PrimaryKey(t => t.Guid);


            CreateTable(
                "dbo.Phrases_EN",
                c => new
                {
                    Guid = c.Guid(nullable: false),
                    Phrase = c.String(nullable: false),
                })
                .PrimaryKey(t => t.Guid);


            CreateTable(
                "dbo.Phrases_KR",
                c => new
                {
                    Guid = c.Guid(nullable: false),
                    Phrase = c.String(nullable: false),
                })
                .PrimaryKey(t => t.Guid);


            CreateTable(
                "dbo.Phrases_Relation",
                c => new
                {
                    Guid = c.Guid(nullable: false),
                    Phrase_EN_Guid = c.Guid(nullable: false),
                    Phrase_KR_Guid = c.Guid(nullable: false),
                })
                .PrimaryKey(t => t.Guid);

            AddForeignKey("dbo.Words_Relation", "Word_EN_Guid", "dbo.Words_EN", "Guid");
            AddForeignKey("dbo.Words_Relation", "Word_KR_Guid", "dbo.Words_KR", "Guid");
            AddForeignKey("dbo.Phrases_Relation", "Phrases_EN_Guid", "dbo.Phrases_EN", "Guid");
            AddForeignKey("dbo.Phrases_Relation", "Phrases_KR_Guid", "dbo.Phrases_KR", "Guid");
        }
        
        public override void Down()
        {
            DropTable("dbo.Words_EN");
            DropTable("dbo.Words_KR");
            DropTable("dbo.Words_Relation");
            DropTable("dbo.Phrases_EN");
            DropTable("dbo.Phrases_KR");
            DropTable("dbo.Phrases_Relation");
        }
    }
}
