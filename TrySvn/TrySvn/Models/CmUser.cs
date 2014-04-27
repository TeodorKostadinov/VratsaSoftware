/*
 * Created by SharpDevelop.
 * User: ekadiyski
 * Date: 4/27/2014
 * Time: 12:34 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TrySvn.Models
{
	/// <summary>
	/// Description of CmUser.
	/// </summary>
	public class CmUser
	{
		public int ID {get; set;}
		public String email{get; set;}
		public String password{get; set;}
		public String firstName{get; set;}
		public String lastName{get; set;}
	}
}
