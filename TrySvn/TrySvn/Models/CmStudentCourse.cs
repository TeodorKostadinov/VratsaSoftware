/*
 * Created by SharpDevelop.
 * User: ekadiyski
 * Date: 5/4/2014
 * Time: 10:26 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrySvn.Models
{
	/// <summary>
	/// Description of CmStudentCourse.
	/// </summary>
	public class CmStudentCourse
	{
		public int ID{get; set;}
		
		public int cmStudentId{get; set;}
		public CmStudent cmStudent{get; set;}
		
		public int clSubjectId{get; set;}
		public ClSubject clSubject{get; set;}
		
		public int cmTeacherId{get; set;}
		[ForeignKey("cmTeacherId")]
		public CmTeacher cmTeacher{get; set;}
	}
}
