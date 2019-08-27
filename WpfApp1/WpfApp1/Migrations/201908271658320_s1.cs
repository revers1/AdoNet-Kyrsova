namespace WpfApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class s1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblAnswers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Answer = c.String(nullable: false),
                        IsCorrect = c.Boolean(nullable: false),
                        Id_Question = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblCreateExam", t => t.Id_Question, cascadeDelete: true)
                .Index(t => t.Id_Question);
            
            CreateTable(
                "dbo.tblCreateExam",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quastion = c.String(nullable: false),
                        Price_Q = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblLoginPanel",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Log = c.String(nullable: false),
                        Pass = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblAnswers", "Id_Question", "dbo.tblCreateExam");
            DropIndex("dbo.tblAnswers", new[] { "Id_Question" });
            DropTable("dbo.tblLoginPanel");
            DropTable("dbo.tblCreateExam");
            DropTable("dbo.tblAnswers");
        }
    }
}
