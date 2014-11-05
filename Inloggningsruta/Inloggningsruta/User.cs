using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inloggningsruta
{
	public class User
	{
		public bool Admin { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string FirstName { get; set; }
		public string SurName { get; set; }
		public int Age { get; set; }

		public User(string username, string password)
		{
			Admin = false;
			Username = username;
			Password = password;
		}
	}
}
