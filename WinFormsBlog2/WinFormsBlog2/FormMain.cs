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
	public partial class FormMain : Form
	{
		private static PostManager _postManager;
		private static CommentManager _commentManager;

		public FormMain()
		{
			InitializeComponent();

			_postManager = new PostManager();
			_commentManager = new CommentManager();
			GenerateTestPosts.GetPosts(3, _postManager, _commentManager);
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			var createForm = new FormNewPost(_postManager);
			createForm.ShowDialog();

			richTextBox1.Clear();
			_postManager.PrintAllPosts(richTextBox1);

			btnComment.Visible = false;
			btnEdit.Visible = false;
			btnDelete.Visible = false;
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			richTextBox1.Clear();
			_postManager.PrintAllPosts(richTextBox1);

			btnComment.Visible = false;
			btnEdit.Visible = false;
			btnDelete.Visible = false;
		}

		private void btnShowSingle_Click(object sender, EventArgs e)
		{
			var findEntryForm = new FormFindEntry(_postManager);
			findEntryForm.ShowDialog();

			richTextBox1.Clear();
			_postManager.PrintSinglePost(richTextBox1, _postManager.SelectedPost);

			btnComment.Visible = true;
			btnEdit.Visible = true;
			btnDelete.Visible = true;
		}

		private void btnComment_Click(object sender, EventArgs e)
		{
			var commentForm = new FormComment(_postManager.SelectedPost, _commentManager);
			commentForm.ShowDialog();

			richTextBox1.Clear();
			_postManager.PrintSinglePost(richTextBox1, _postManager.SelectedPost);
		}
	}
}
