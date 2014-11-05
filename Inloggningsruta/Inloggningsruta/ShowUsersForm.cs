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
	public partial class ShowUsersForm : Form
	{
		public ShowUsersForm(UserManager usermanager, User user)
		{
			InitializeComponent();

			userGrid.DataSource = usermanager.GetUsers();
			userGrid.Columns[0].Visible = false;
			userGrid.Columns[2].Visible = false;
			userGrid.Columns[3].Visible = false;
			userGrid.Columns[4].Visible = false;
			userGrid.Columns[5].Visible = false;
		}



		private void quitBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
