namespace TrySvn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudentSubjects : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ClSubjects",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        clCategoryId = c.Int(nullable: false),
                        clUniversityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ClCategories", t => t.clCategoryId, cascadeDelete: true)
                .ForeignKey("dbo.ClUniversities", t => t.clUniversityId, cascadeDelete: true)
                .Index(t => t.clCategoryId)
                .Index(t => t.clUniversityId);
            
            CreateTable(
                "dbo.CmStudentSubjects",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        cmStudentId = c.Int(nullable: false),
                        clSubjectId = c.Int(nullable: false),
                        cmTeacherId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ClSubjects", t => t.clSubjectId, cascadeDelete: true)
                .ForeignKey("dbo.CmStudents", t => t.cmStudentId)
                .ForeignKey("dbo.CmTeachers", t => t.cmTeacherId)
                .Index(t => t.clSubjectId)
                .Index(t => t.cmStudentId)
                .Index(t => t.cmTeacherId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CmStudentSubjects", "cmTeacherId", "dbo.CmTeachers");
            DropForeignKey("dbo.CmStudentSubjects", "cmStudentId", "dbo.CmStudents");
            DropForeignKey("dbo.CmStudentSubjects", "clSubjectId", "dbo.ClSubjects");
            DropForeignKey("dbo.ClSubjects", "clUniversityId", "dbo.ClUniversities");
            DropForeignKey("dbo.ClSubjects", "clCategoryId", "dbo.ClCategories");
            DropIndex("dbo.CmStudentSubjects", new[] { "cmTeacherId" });
            DropIndex("dbo.CmStudentSubjects", new[] { "cmStudentId" });
            DropIndex("dbo.CmStudentSubjects", new[] { "clSubjectId" });
            DropIndex("dbo.ClSubjects", new[] { "clUniversityId" });
            DropIndex("dbo.ClSubjects", new[] { "clCategoryId" });
            DropTable("dbo.CmStudentSubjects");
            DropTable("dbo.ClSubjects");
            DropTable("dbo.ClCategories");
        }
    }
}
