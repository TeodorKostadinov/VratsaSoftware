using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TrySvn.Models
{
    public class TrySvnContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<TrySvn.Models.TrySvnContext>());

    	
		public DbSet<TrySvn.Models.FirstModel> FirstModels { get; set; }
    	
		public DbSet<TrySvn.Models.Agency> Agencies { get; set; }
		public DbSet<TrySvn.Models.User> Users { get; set; }
    	
		public DbSet<TrySvn.Models.CmUser> CmUsers { get; set; }
    	
		public DbSet<TrySvn.Models.ClUniversity> ClUniversities { get; set; }
    	
		public DbSet<TrySvn.Models.CmStudent> CmStudents { get; set; }
    	
		public DbSet<TrySvn.Models.CmTeacher> CmTeachers { get; set; }
    }
}