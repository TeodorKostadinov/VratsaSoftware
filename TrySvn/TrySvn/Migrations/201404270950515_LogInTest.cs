namespace TrySvn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LogInTest : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClUniversities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        uniName = c.String(),
                        uniCity = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CmStudents",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        yearStudy = c.Int(nullable: false),
                        course = c.String(),
                        cmUserID = c.Int(nullable: false),
                        clUniversityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ClUniversities", t => t.clUniversityId, cascadeDelete: true)
                .ForeignKey("dbo.CmUsers", t => t.cmUserID, cascadeDelete: true)
                .Index(t => t.clUniversityId)
                .Index(t => t.cmUserID);
            
            CreateTable(
                "dbo.CmUsers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        email = c.String(),
                        password = c.String(),
                        firstName = c.String(),
                        lastName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CmTeachers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        cmUserID = c.Int(nullable: false),
                        clUniversityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ClUniversities", t => t.clUniversityId, cascadeDelete: true)
                .ForeignKey("dbo.CmUsers", t => t.cmUserID, cascadeDelete: true)
                .Index(t => t.clUniversityId)
                .Index(t => t.cmUserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CmTeachers", "cmUserID", "dbo.CmUsers");
            DropForeignKey("dbo.CmTeachers", "clUniversityId", "dbo.ClUniversities");
            DropForeignKey("dbo.CmStudents", "cmUserID", "dbo.CmUsers");
            DropForeignKey("dbo.CmStudents", "clUniversityId", "dbo.ClUniversities");
            DropIndex("dbo.CmTeachers", new[] { "cmUserID" });
            DropIndex("dbo.CmTeachers", new[] { "clUniversityId" });
            DropIndex("dbo.CmStudents", new[] { "cmUserID" });
            DropIndex("dbo.CmStudents", new[] { "clUniversityId" });
            DropTable("dbo.CmTeachers");
            DropTable("dbo.CmUsers");
            DropTable("dbo.CmStudents");
            DropTable("dbo.ClUniversities");
        }
    }
}
