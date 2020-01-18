using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_09_ThisKeyword
{
	public class User
	{

		public String firstName;
		public String lastName;
		public User()
				 : this("default_first", "default_last")
		{
		}

		public User(String firstName, String lastName)
		{

			this.firstName = firstName;
			this.lastName = lastName;
		}

		public string GetDetails()
		{
			return firstName + " " + lastName;
		}
	}
}
