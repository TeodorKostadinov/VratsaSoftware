/*
 * Created by SharpDevelop.
 * User: ekadiyski
 * Date: 5/4/2014
 * Time: 5:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace TrySvn.Models
{
	/// <summary>
	/// Description of StudendCoursesContext.
	/// </summary>
	public class StudendCoursesContext : DbContext
	{
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<CmStudentCourse>()
				.HasRequired(c => c.cmStudent)
				.WithMany()
				.WillCascadeOnDelete(false);
				
			modelBuilder.Entity<CmStudentCourse>()
			    .HasRequired(s => s.cmTeacher)
			    .WithMany()
			    .WillCascadeOnDelete(false);
			    
   			base.OnModelCreating(modelBuilder);
		}
		
	}
}
