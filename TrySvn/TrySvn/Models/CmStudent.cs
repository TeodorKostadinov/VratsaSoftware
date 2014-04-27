/*
 * Created by SharpDevelop.
 * User: ekadiyski
 * Date: 4/27/2014
 * Time: 12:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TrySvn.Models
{
	/// <summary>
	/// Description of CmStudent.
	/// </summary>
	public class CmStudent
	{
		public int ID{get; set;}
		public int yearStudy{get; set;}
		public String course{get; set;}
		
		public int cmUserID{get; set;}
		public CmUser cmUser{get; set;}
		
		public int clUniversityId{get; set;}
		public ClUniversity clUniversity{get; set;}
		
	}
}
