/*
 * Created by SharpDevelop.
 * User: ekadiyski
 * Date: 5/5/2014
 * Time: 6:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace MvcApplication1.Models
{
	/// <summary>
	/// Description of CmStudent.
	/// </summary>
	public class CmStudent
	{
		public int ID{get; set;}
		
		public int userProfileId{get; set;}
		public UserProfile userProfile{get; set;}
	}
}
