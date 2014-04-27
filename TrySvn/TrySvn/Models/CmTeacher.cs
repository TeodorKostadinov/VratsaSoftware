/*
 * Created by SharpDevelop.
 * User: ekadiyski
 * Date: 4/27/2014
 * Time: 3:43 PM
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
		
		public int userID{get; set;}
		public User user{get; set;}
		
		public int clUniversityId{get; set;}
		public ClUniversity clUniversity{get; set;}
	}
}
