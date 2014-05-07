/*
 * Created by SharpDevelop.
 * User: ekadiyski
 * Date: 5/6/2014
 * Time: 12:49 PM
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
		public int ID {get; set;}
		public string name{get; set;}
		
		public int clCategoryId{get; set;}
		public ClCategory clCategory{get; set;}
		
		public int clUniversityId{get; set;}
		public ClUniversity clUniversity{get; set;}
	}
}
