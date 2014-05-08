/*
 * Created by SharpDevelop.
 * User: ekadiyski
 * Date: 5/5/2014
 * Time: 6:05 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace MvcApplication1.Models
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
		public CmTeacher cmTeacher{get; set;}
	}
}
