using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inloggningsruta
{
	public class UserManager
	{
		private List<User> _users;

		public List<User> GetUsers()
		{
			return _users;
		}

		public void CreateUser(string name, string password)
		{
			_users.Add(new User(name, password));
		}

		public UserManager()
		{
			_users = new List<User>();
		}
	}
}
