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
	public partial class FormNewPost : Form
	{
		private static PostManager _postmanager;

		public FormNewPost(PostManager postmanager)
		{
			InitializeComponent();
			_postmanager = postmanager;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			_postmanager.CreatePost(txtTitle.Text, txtText.Text, txtTags.Text);
			this.Close();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
