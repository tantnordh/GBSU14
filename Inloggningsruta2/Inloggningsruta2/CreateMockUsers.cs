using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inloggningsruta2
{
	public class CreateMockUsers
	{
		public static void AdminAndUsers(UserManager userManager, int number)
		{
			User admin = new User("admin", "pass");
			admin.Admin = true;
			admin.FirstName = "administrator";
			admin.SurName = "adminsson";
			admin.Age = 90;

			userManager.Users.Add(admin);

			string username;
			string password;

			for (int i = 0; i < number; i++)
			{
				username = "user" + (i + 1);
				password = "pass" + (i + 1);

				User user = new User(username, password);
				user.FirstName = "name" + (i + 1);
				user.SurName = "sur" + (i + 1);
				user.Age = 30 + i;

				userManager.Users.Add(user);
			}
		}
	}
}
