using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inloggningsruta
{
	public partial class LoginForm : Form
	{
		private static UserManager _userManager = new UserManager();

		public LoginForm()
		{
			CreateSomeUsers.CreateUsers(_userManager);
			InitializeComponent();
		}

		private void loginBtn_Click(object sender, EventArgs e)
		{
			bool usernameIsValid;
			if (usernameBox.Text != string.Empty)
			{
				usernameIsValid = CheckUsername();
			}
			else
			{
				usernameBox.ForeColor = Color.DarkRed;
				usernameBox.Text = "You forgot to enter a username.";
			}
			
		}

		private bool CheckUsername()
		{
			User user = _userManager.GetUsers().SingleOrDefault(u => u.Username == usernameBox.Text);
				if (user != null)
				{
					return true;
				}
			return false;
		}

		private void clearBtn_Click(object sender, EventArgs e)
		{
			usernameBox.Text = string.Empty;
			passwordBox.Text = string.Empty;
		}


	}
}
