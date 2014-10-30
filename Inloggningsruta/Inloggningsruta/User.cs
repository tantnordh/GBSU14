using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inloggningsruta
{
	public class User
	{
		public string Username { get; set; }
		public string Password { get; private set; }
		public string FirstName { get; set; }
		public string SurName { get; set; }
		public int Age { get; set; }

		public User(string userName, string passWord)
		{
			Username = userName;
			Password = passWord;
		}
	}
}
