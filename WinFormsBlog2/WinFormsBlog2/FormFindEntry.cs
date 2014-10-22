using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsBlog2
{
	public partial class FormFindEntry : Form
	{
		private static PostManager _postManager;

		public FormFindEntry(PostManager postManager)
		{
			InitializeComponent();

			_postManager = postManager;

			comboBoxTitles.DataSource = _postManager.Posts;
			comboBoxTitles.DisplayMember = "Title";
		}

		private void btnChooseFromCombo_Click(object sender, EventArgs e)
		{
			_postManager.SelectedPost = (Post) comboBoxTitles.SelectedItem;
			this.Close();
		}
	}
}
