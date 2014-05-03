/*
 * Created by SharpDevelop.
 * User: ID
 * Date: 4/26/2014
 * Time: 5:12 PM
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
		public int ID {get; set;}
		public string FirstName {get; set;}
		public string LastName {get; set;}
		public string Email {get; set;}
		public string Password {get; set;}
		
		public override string ToString(){
			return this.FirstName + " " + this.LastName;
		}
	}
}
