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
	public partial class UserForm : Form
	{
		private static User _currentUser;
		private static UserManager _userManager;
		private static User _selectedUser;

		public UserForm(UserManager userManager, User currentUser)
		{
			InitializeComponent();
			_userManager = userManager;
			_currentUser = currentUser;

			if (currentUser.Admin)
			{
				UserIsAdmin();
			}
			else
			{
				UserIsNotAdmin();
			}

			userList.DataSource = _userManager.Users;
			userList.DisplayMember = "Username";
		}

		private void UserIsNotAdmin()
		{
			this.Width = 260;
			blockBtn.Visible = false;
			unblockBtn.Visible = false;
			deleteBtn.Visible = false;
			userInfoBox.Height = 186;
		}

		private void UserIsAdmin()
		{
			this.Width = 445;
			blockBtn.Visible = true;
			unblockBtn.Visible = true;
			deleteBtn.Visible = true;
			userInfoBox.Height = 99;
		}

		private void userList_SelectedIndexChanged(object sender, EventArgs e)
		{
			_selectedUser = (User)userList.SelectedItem;
			LoadUserInfo();
		}

		private void blockBtn_Click(object sender, EventArgs e)
		{
			_selectedUser.LockedAccount = true;
			LoadUserInfo();
		}

		private void unblockBtn_Click(object sender, EventArgs e)
		{
			_selectedUser.LockedAccount = false;
			LoadUserInfo();
		}

		private void deleteBtn_Click(object sender, EventArgs e)
		{
			_userManager.DeleteUser(_selectedUser);
		}

		private void LoadUserInfo()
		{
			userInfoBox.Clear();
			userInfoBox.AppendText("First name: " + _selectedUser.FirstName);
			userInfoBox.AppendText("\nSurname: " + _selectedUser.SurName);
			userInfoBox.AppendText("\nAge: " + _selectedUser.Age.ToString());
			userInfoBox.AppendText("\nBlocked: " + _selectedUser.LockedAccount.ToString());
		}
	}
}
