using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inloggningsruta
{
	public static class CreateMockUsers
	{
		public static void Add(int number, UserManager userManager)
		{
			string username;
			string password;

			userManager.CreateUser("admin", "pass");
			User admin = userManager.GetUsers().Single(u => u.Username == "admin");
			admin.Admin = true;

			for (int i = 0; i < number; i++)
			{
				username = "user" + (i + 1);
				password = "pass" + (i + 1);
				userManager.CreateUser(username, password);
			}
		}
	}
}
