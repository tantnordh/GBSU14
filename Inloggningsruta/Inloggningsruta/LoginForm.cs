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
		private event Action loginAction;

		private static UserManager _userManager = new UserManager();

		public LoginForm()
		{
			CreateMockUsers.Add(5, _userManager);
			InitializeComponent();
		}

		private void clearBtn_Click(object sender, EventArgs e)
		{
			usernameBox.Text = string.Empty;
			passwordBox.Text = string.Empty;
			usernameMessageLbl.Text = string.Empty;
		}

		private void loginBtn_Click(object sender, EventArgs e)
		{
			HideMessageLabel();
			bool usernameExists = UsernameExists();
			bool passwordIsCorrect = false;
			if (usernameExists)
			{
				passwordIsCorrect = PasswordIsCorrect();
			}

			if (usernameExists && passwordIsCorrect)
			{
				var showUsers = new ShowUsersForm(_userManager, _userManager.GetUsers().Single(u => u.Username == usernameBox.Text));
				showUsers.ShowDialog();
				this.Close();
			}
		}

		private bool UsernameExists()
		{
			if (usernameBox.Text == string.Empty)
			{
				loginAction = UsernameIsEmpty;
				loginAction();
				return false;
			}

			List<User> usernameMatches = _userManager.GetUsers().Where(u => u.Username.ToLower() == usernameBox.Text.ToLower()).ToList();
			if (usernameMatches.Count == 0)
			{
				loginAction = UsernameDoesNotExist;
				loginAction();
				return false;
			}

			return true;
		}
		private bool PasswordIsCorrect()
		{
			if (passwordBox.Text == string.Empty)
			{
				loginAction = PasswordIsEmpty;
				loginAction();
				return false;
			}

			bool passwordIsCorrect = CheckPassword(_userManager.GetUsers().Single(u => u.Username == usernameBox.Text));
			if (!passwordIsCorrect)
			{
				loginAction = IncorrectPassword;
				loginAction();
				return false;
			}

			return true;
		}
		private bool CheckPassword(User user)
		{
			if (user.Password != passwordBox.Text)
				return false;

			return true;
		}

		private void UsernameDoesNotExist()
		{
			usernameMessageLbl.Text = "That username does not exist.";
			usernameMessageLbl.Visible = true;
		}
		private void IncorrectPassword()
		{
			usernameMessageLbl.Text = "Incorrect password.";
			usernameMessageLbl.Visible = true;
		}
		private void UsernameIsEmpty()
		{
			usernameMessageLbl.Text = "You forgot to type in your username.";
			usernameMessageLbl.Visible = true;
		}
		private void PasswordIsEmpty()
		{
			usernameMessageLbl.Text = "You forgot to type in your password.";
			usernameMessageLbl.Visible = true;
		}

		private void HideMessageLabel()
		{
			usernameMessageLbl.Visible = false;
		}
	}
}
