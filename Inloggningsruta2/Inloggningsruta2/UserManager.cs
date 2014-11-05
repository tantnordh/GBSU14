using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Inloggningsruta2
{
	public class UserManager
	{
		public BindingList<User> Users { get; set; }

		public void CreateUser(string username, string password)
		{
			Users.Add(new User(username, password));
		}

		public void DeleteUser(User user)
		{
			Users.Remove(user);
		}

		public UserManager()
		{
			Users = new BindingList<User>();
		}
	}
}
