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
	/// Description of CmTeacher.
	/// </summary>
	public class CmTeacher
	{
		public int ID{get; set;}
		
		public int userProfileId{get; set;}
		public UserProfile userProfile{get; set;}
	}
}
