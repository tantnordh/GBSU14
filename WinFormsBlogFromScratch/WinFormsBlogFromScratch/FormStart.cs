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

			comboBoxBlogs.DataSource = blogmanager.GetBlogs();
			comboBoxBlogs.DisplayMember = "Title";
		}

		private void btnNewBlog_Click(object sender, EventArgs e)
		{
			var createNewBlog = new FormCreateNewBlog();
			createNewBlog.ShowDialog();
		}

		private void btnGoToBlog_Click(object sender, EventArgs e)
		{

		}
	}
}
