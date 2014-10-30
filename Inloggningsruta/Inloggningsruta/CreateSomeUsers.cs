using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inloggningsruta
{
	public static class CreateSomeUsers
	{
		public static void CreateUsers(UserManager userManager)
		{
			for (int i = 0; i < 5; i++)
			{
				userManager.CreateUser("user" + (i + 1), "password" + (i + 1));
			}
		}
	}
}
