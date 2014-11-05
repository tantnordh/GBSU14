using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inloggningsruta
{
	public class UserManager
	{
		private static List<User> _users = new List<User>();

		public List<User> GetUsers()
		{
			return _users;
		}

		public void CreateUser(string username, string password)
		{
			_users.Add(new User(username, password));
		}
	}
}