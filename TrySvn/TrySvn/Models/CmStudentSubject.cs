/*
 * Created by SharpDevelop.
 * User: ekadiyski
 * Date: 5/6/2014
 * Time: 12:50 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TrySvn.Models
{
	/// <summary>
	/// Description of CmStudentSubject.
	/// </summary>
	public class CmStudentSubject
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
