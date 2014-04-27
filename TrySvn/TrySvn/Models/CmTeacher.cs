/*
 * Created by SharpDevelop.
 * User: ekadiyski
 * Date: 4/27/2014
 * Time: 12:46 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TrySvn.Models
{
	/// <summary>
	/// Description of CmTeacher.
	/// </summary>
	public class CmTeacher
	{
		public int ID{get; set;}
		public String title{get; set;}
		
		public int cmUserID{get; set;}
		public CmUser cmUser{get; set;}
		
		public int clUniversityId{get; set;}
		public ClUniversity clUniversity{get; set;}
	}
}
