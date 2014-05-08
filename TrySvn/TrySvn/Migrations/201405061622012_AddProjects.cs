namespace TrySvn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProjects : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CmCompanies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        clCategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ClCategories", t => t.clCategoryId, cascadeDelete: true)
                .Index(t => t.clCategoryId);
            
            CreateTable(
                "dbo.CmCompanyRepresentatives",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        companyRole = c.String(),
                        userId = c.Int(nullable: false),
                        cmCompanyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CmCompanies", t => t.cmCompanyId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.userId, cascadeDelete: true)
                .Index(t => t.cmCompanyId)
                .Index(t => t.userId);
            
            CreateTable(
                "dbo.CmProjectDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        status = c.String(),
                        cmProjectId = c.Int(nullable: false),
                        cmStudentSubjectId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CmProjects", t => t.cmProjectId, cascadeDelete: true)
                .ForeignKey("dbo.CmStudentSubjects", t => t.cmStudentSubjectId, cascadeDelete: true)
                .Index(t => t.cmProjectId)
                .Index(t => t.cmStudentSubjectId);
            
            CreateTable(
                "dbo.CmProjects",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        data = c.String(),
                        cmCompanyId = c.Int(nullable: false),
                        clCategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ClCategories", t => t.clCategoryId)
                .ForeignKey("dbo.CmCompanies", t => t.cmCompanyId)
                .Index(t => t.clCategoryId)
                .Index(t => t.cmCompanyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CmProjectDetails", "cmStudentSubjectId", "dbo.CmStudentSubjects");
            DropForeignKey("dbo.CmProjectDetails", "cmProjectId", "dbo.CmProjects");
            DropForeignKey("dbo.CmProjects", "cmCompanyId", "dbo.CmCompanies");
            DropForeignKey("dbo.CmProjects", "clCategoryId", "dbo.ClCategories");
            DropForeignKey("dbo.CmCompanyRepresentatives", "userId", "dbo.Users");
            DropForeignKey("dbo.CmCompanyRepresentatives", "cmCompanyId", "dbo.CmCompanies");
            DropForeignKey("dbo.CmCompanies", "clCategoryId", "dbo.ClCategories");
            DropIndex("dbo.CmProjectDetails", new[] { "cmStudentSubjectId" });
            DropIndex("dbo.CmProjectDetails", new[] { "cmProjectId" });
            DropIndex("dbo.CmProjects", new[] { "cmCompanyId" });
            DropIndex("dbo.CmProjects", new[] { "clCategoryId" });
            DropIndex("dbo.CmCompanyRepresentatives", new[] { "userId" });
            DropIndex("dbo.CmCompanyRepresentatives", new[] { "cmCompanyId" });
            DropIndex("dbo.CmCompanies", new[] { "clCategoryId" });
            DropTable("dbo.CmProjects");
            DropTable("dbo.CmProjectDetails");
            DropTable("dbo.CmCompanyRepresentatives");
            DropTable("dbo.CmCompanies");
        }
    }
}
