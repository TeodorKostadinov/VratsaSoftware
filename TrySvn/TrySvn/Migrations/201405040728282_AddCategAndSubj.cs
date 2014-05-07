namespace TrySvn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategAndSubj : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        category = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ClSubjects",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        clUniversityId = c.Int(nullable: false),
                        clCategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ClCategories", t => t.clCategoryId, cascadeDelete: true)
                .ForeignKey("dbo.ClUniversities", t => t.clUniversityId, cascadeDelete: true)
                .Index(t => t.clCategoryId)
                .Index(t => t.clUniversityId);
            
            CreateTable(
                "dbo.CmStudentCourses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        cmStudentId = c.Int(nullable: false),
                        clSubjectId = c.Int(nullable: false),
                        cmTeacherId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ClSubjects", t => t.clSubjectId, cascadeDelete: true)
                .ForeignKey("dbo.CmStudents", t => t.cmStudentId, cascadeDelete: true)
                .ForeignKey("dbo.CmTeachers", t => t.cmTeacherId, cascadeDelete: true)
                .Index(t => t.clSubjectId)
                .Index(t => t.cmStudentId)
                .Index(t => t.cmTeacherId);           
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CmStudentCourses", "cmTeacherId", "dbo.CmTeachers");
            DropForeignKey("dbo.CmStudentCourses", "cmStudentId", "dbo.CmStudents");
            DropForeignKey("dbo.CmStudentCourses", "clSubjectId", "dbo.ClSubjects");
            DropForeignKey("dbo.ClSubjects", "clUniversityId", "dbo.ClUniversities");
            DropForeignKey("dbo.ClSubjects", "clCategoryId", "dbo.ClCategories");
            DropIndex("dbo.CmStudentCourses", new[] { "cmTeacherId" });
            DropIndex("dbo.CmStudentCourses", new[] { "cmStudentId" });
            DropIndex("dbo.CmStudentCourses", new[] { "clSubjectId" });
            DropIndex("dbo.ClSubjects", new[] { "clUniversityId" });
            DropIndex("dbo.ClSubjects", new[] { "clCategoryId" });
            DropTable("dbo.CmStudentCourses");
            DropTable("dbo.ClSubjects");
            DropTable("dbo.ClCategories");
        }
    }
}
