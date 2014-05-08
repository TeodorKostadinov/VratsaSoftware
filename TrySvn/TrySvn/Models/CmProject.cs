/*
 * Created by SharpDevelop.
 * User: ekadiyski
 * Date: 5/6/2014
 * Time: 7:11 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TrySvn.Models
{
	/// <summary>
	/// Description of CmProject.
	/// </summary>
	public class CmProject
	{
		public int ID{get; set;}
		public string title {get; set;}
		public string data{get; set;}
		
		public int cmCompanyId{get; set;}
		public CmCompany cmCompany{get; set;}
		
		public int clCategoryId{get; set;}
		public ClCategory clCateogry{get; set;}
	}
}
