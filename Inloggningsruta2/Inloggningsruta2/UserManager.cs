using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inloggningsruta2
{
	public class UserManager
	{
		public List<User> Users { get; set; }
		public User SelectedUser { get; set; }

		public void CreateUser(string username, string password)
		{
			Users.Add(new User(username, password));
		}

		public void DeleteUser(User user)
		{
			Users.Remove(user);
			SelectedUser = null;
		}

		public UserManager()
		{
			Users = new List<User>();
		}
	}
}
