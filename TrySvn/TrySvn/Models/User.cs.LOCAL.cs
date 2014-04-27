/*
 * Created by SharpDevelop.
 * User: Teodor
 * Date: 27-Apr-14
 * Time: 11:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TrySvn.Models
{
	/// <summary>
	/// Description of User.
	/// </summary>
	public class User
	{
		public int ID {get;set;}
		public String firstName {get;set;}
		public String lastName {get;set;}
		public String email {get;set;}
		public String password {get;set;}
	}
}
