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

			LoadUserList();
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
			_userManager.SelectedUser = (User)userList.SelectedItem;

			userInfoBox.Clear();
			userInfoBox.AppendText("First name: " + _userManager.SelectedUser.FirstName);
			userInfoBox.AppendText("\nSurname: " + _userManager.SelectedUser.SurName);
			userInfoBox.AppendText("\nAge: " + _userManager.SelectedUser.Age.ToString());
			userInfoBox.AppendText("\nBlocked: " + _userManager.SelectedUser.LockedAccount.ToString());
		}

		private void blockBtn_Click(object sender, EventArgs e)
		{
			_userManager.SelectedUser.LockedAccount = true;
		}

		private void unblockBtn_Click(object sender, EventArgs e)
		{
			_userManager.SelectedUser.LockedAccount = false;
		}

		private void deleteBtn_Click(object sender, EventArgs e)
		{
			_userManager.DeleteUser(_userManager.SelectedUser);
			userInfoBox.Clear();
			LoadUserList();
		}

		private void LoadUserList()
		{
			userList.DataSource = null;
			userList.DataSource = _userManager.Users;
			userList.DisplayMember = "Username";
		}
	}
}
