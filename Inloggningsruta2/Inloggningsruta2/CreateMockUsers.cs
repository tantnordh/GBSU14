using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inloggningsruta2
{
	public class CreateMockUsers
	{
		public static void Users(UserManager userManager, int number)
		{
			string username;
			string password;

			for (int i = 0; i < number; i++)
			{
				username = "user" + (i + 1);
				password = "pass" + (i + 1);
				userManager.Users.Add(new User(username, password));
				userManager.Users[i].FirstName = "name" + (i + 1);
				userManager.Users[i].SurName = "sur" + (i + 1);
				userManager.Users[i].Age = 30 + i;
			}
		}

		public static void Admin(UserManager userManager)
		{
			User admin = new User("admin", "pass");
			admin.Admin = true;
			admin.FirstName = "administrator";
			admin.SurName = "adminsson";
			admin.Age = 90;
			userManager.Users.Add(admin);
		}
	}
}
