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
		private static List<User> _users;

		public UserForm(UserManager userManager)
		{
			InitializeComponent();
			_users = userManager.Users.OrderBy(u => u.Username).ToList();
			userList.DataSource = _users;
			userList.DisplayMember = "Username";
		}

		private void ShowUserInfo(object sender, EventArgs e)
		{
			nameLbl.Text = "First name: " + _users.SingleOrDefault(u => u.Username == userList.SelectedValue.ToString()).FirstName;
		}

	}
}
