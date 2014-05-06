/*
 * Created by SharpDevelop.
 * User: ekadiyski
 * Date: 5/4/2014
 * Time: 10:21 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TrySvn.Models
{
	/// <summary>
	/// Description of ClSubject.
	/// </summary>
	public class ClSubject
	{
		public int ID{get; set;}
		public string Name{get; set;}
		
		public int clUniversityId{get; set;}
		public ClUniversity clUniversity{get; set;}
		
		public int clCategoryId{get; set;}
		public ClCategory clCategory{get; set;}
	}
}
