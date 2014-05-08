/*
 * Created by SharpDevelop.
 * User: ekadiyski
 * Date: 5/6/2014
 * Time: 7:13 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TrySvn.Models
{
	/// <summary>
	/// Description of CmProjectDetail.
	/// </summary>
	public class CmProjectDetail
	{
		public int ID{get; set;}
		public string status{get; set;}
		
		public int cmProjectId{get; set;}
		public CmProject cmProject{get; set;}
		
		public int cmStudentSubjectId{get; set;}
		public CmStudentSubject cmStudentSubject{get; set;}
	}
}
