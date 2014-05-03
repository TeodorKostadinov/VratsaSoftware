namespace TrySvn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeCmStudent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CmStudents", "courseYear", c => c.Byte(nullable: false));
            AddColumn("dbo.CmStudents", "course", c => c.String());
            DropColumn("dbo.CmStudents", "title");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CmStudents", "title", c => c.String());
            DropColumn("dbo.CmStudents", "course");
            DropColumn("dbo.CmStudents", "courseYear");
        }
    }
}
