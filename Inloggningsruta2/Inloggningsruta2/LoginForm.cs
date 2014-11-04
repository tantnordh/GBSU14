using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inloggningsruta2
{
	public partial class LoginForm : Form
	{
		private static UserManager _userManager = new UserManager();
		private static User _user;
		
		public event Action LoginAction;
		
		public LoginForm()
		{
			InitializeComponent();

			CreateMockUsers.Admin(_userManager);
			CreateMockUsers.Users(_userManager, 3);
		}

		private void clearBtn_Click(object sender, EventArgs e)
		{
			usernameBox.Text = string.Empty;
			passwordBox.Text = string.Empty;
			errorLbl.Visible = false;
		}

		private void loginBtn_Click(object sender, EventArgs e)
		{
			errorLbl.Visible = false;
			bool usernameEntered = UsernameEntered();
			bool usernameIsValid = false;
			if (usernameEntered)
				usernameIsValid = UsernameIsValid();

			bool passwordEntered = false;
			if (usernameIsValid)
				passwordEntered = PasswordEntered();

			bool passwordIsValid = false;
			if (passwordEntered)
				passwordIsValid = PassWordIsValid();

			if (passwordIsValid)
			{
				var userForm = new UserForm(_userManager);
				userForm.ShowDialog();
			}
		}

		private bool PassWordIsValid()
		{
			if (_user.Password != passwordBox.Text)
			{
				LoginAction = PasswordIsInvalid;
				LoginAction();
				return false;
			}

			return true;
		}
		private void PasswordIsInvalid()
		{
			errorLbl.Visible = true;
			errorLbl.Text = "Invalid password.";
		}

		private bool PasswordEntered()
		{
			if (passwordBox.Text == string.Empty)
			{
				LoginAction = PasswordNotEntered;
				LoginAction();
				return false;
			}

			return true;
		}
		private void PasswordNotEntered()
		{
			errorLbl.Visible = true;
			errorLbl.Text = "Enter password.";
		}

		private bool UsernameIsValid()
		{
			if (!(_userManager.Users.Where(u => u.Username.ToLower() == usernameBox.Text.ToLower()).ToList().Count > 0))
			{
				LoginAction = UsernameIsInvalid;
				LoginAction();
				return false;
			}

			_user = _userManager.Users.Single(u => u.Username.ToLower() == usernameBox.Text.ToLower());
			
			return true;
		}
		private void UsernameIsInvalid()
		{
			errorLbl.Visible = true;
			errorLbl.Text = "Username does not exist.";
		}

		private bool UsernameEntered()
		{
			if (usernameBox.Text == string.Empty)
			{
				LoginAction = UsernameNotEntered;
				LoginAction();
				return false;
			}

			return true;
		}
		private void UsernameNotEntered()
		{
			errorLbl.Visible = true;
			errorLbl.Text = "Enter username.";
		}
	}
}
