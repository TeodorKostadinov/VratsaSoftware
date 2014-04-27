namespace TrySvn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TryAuthentication : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CmStudents", "cmUserID", "dbo.CmUsers");
            DropForeignKey("dbo.CmTeachers", "cmUserID", "dbo.CmUsers");
            DropIndex("dbo.CmStudents", new[] { "cmUserID" });
            DropIndex("dbo.CmTeachers", new[] { "cmUserID" });
           
            
            AddColumn("dbo.CmStudents", "title", c => c.String());
            AddColumn("dbo.CmStudents", "userID", c => c.Int(nullable: false));
            AddColumn("dbo.CmTeachers", "userID", c => c.Int(nullable: false));
            CreateIndex("dbo.CmStudents", "userID");
            CreateIndex("dbo.CmTeachers", "userID");
            AddForeignKey("dbo.CmStudents", "userID", "dbo.Users", "ID", cascadeDelete: true);
            AddForeignKey("dbo.CmTeachers", "userID", "dbo.Users", "ID", cascadeDelete: true);
            DropColumn("dbo.CmStudents", "yearStudy");
            DropColumn("dbo.CmStudents", "course");
            DropColumn("dbo.CmStudents", "cmUserID");
            DropColumn("dbo.CmTeachers", "cmUserID");
            DropTable("dbo.CmUsers");
        }
        
        public override void Down()
        {
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
            
            AddColumn("dbo.CmTeachers", "cmUserID", c => c.Int(nullable: false));
            AddColumn("dbo.CmStudents", "cmUserID", c => c.Int(nullable: false));
            AddColumn("dbo.CmStudents", "course", c => c.String());
            AddColumn("dbo.CmStudents", "yearStudy", c => c.Int(nullable: false));
            DropForeignKey("dbo.CmTeachers", "userID", "dbo.Users");
            DropForeignKey("dbo.CmStudents", "userID", "dbo.Users");
            DropIndex("dbo.CmTeachers", new[] { "userID" });
            DropIndex("dbo.CmStudents", new[] { "userID" });
            DropColumn("dbo.CmTeachers", "userID");
            DropColumn("dbo.CmStudents", "userID");
            DropColumn("dbo.CmStudents", "title");
            DropTable("dbo.Users");
            CreateIndex("dbo.CmTeachers", "cmUserID");
            CreateIndex("dbo.CmStudents", "cmUserID");
            AddForeignKey("dbo.CmTeachers", "cmUserID", "dbo.CmUsers", "ID", cascadeDelete: true);
            AddForeignKey("dbo.CmStudents", "cmUserID", "dbo.CmUsers", "ID", cascadeDelete: true);
        }
    }
}
