/*
 * Created by SharpDevelop.
 * User: ekadiyski
 * Date: 5/5/2014
 * Time: 6:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace MvcApplication1.Models
{
	/// <summary>
	/// Description of ClSubject.
	/// </summary>
	public class ClSubject
	{
		public int ID{get; set;}
		public string name{get; set;}
		
		public int clCategoryId{get; set;}
		public ClCategory clCategory{get; set;}
	}
}
