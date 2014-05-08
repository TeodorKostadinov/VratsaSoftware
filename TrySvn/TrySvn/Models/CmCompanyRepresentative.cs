/*
 * Created by SharpDevelop.
 * User: ekadiyski
 * Date: 5/6/2014
 * Time: 7:06 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TrySvn.Models
{
	/// <summary>
	/// Description of CmCompanyRepresentative.
	/// </summary>
	public class CmCompanyRepresentative
	{
		public int ID{get; set;}
		public string companyRole{get; set;}
		
		public int userId{get; set;}
		public User user{get; set;}
		
		public int cmCompanyId{get; set;}
		public CmCompany cmCompany{get; set;}
	}
}
