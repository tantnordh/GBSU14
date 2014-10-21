using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsBlogFromScratch
{
	public partial class FormStart : Form
	{
		public static BlogManager BlogManager { get; private set; }

		public FormStart(BlogManager blogmanager)
		{
			InitializeComponent();
			BlogManager = blogmanager;
			LoadData();
		}

		private void LoadData()
		{
			comboBoxBlogs.DataSource = null;
			comboBoxBlogs.DisplayMember = "Name";
			comboBoxBlogs.DataSource = BlogManager.GetBlogs();
		}

		private void btnNewBlog_Click(object sender, EventArgs e)
		{
			var createNewBlog = new FormCreateNewBlog();
			if (createNewBlog.ShowDialog() == DialogResult.Cancel)
				LoadData();
		}

		private void btnGoToBlog_Click(object sender, EventArgs e)
		{
			Blog chosenBlog = BlogManager.GetBlogs().Single(b => b.Name == comboBoxBlogs.Text);
			var enterBlog = new FormMenu(chosenBlog);
			enterBlog.ShowDialog();
		}
	}
}
