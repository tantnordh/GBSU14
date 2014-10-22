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
	public partial class FormComment : Form
	{
		private static Post _post;
		private static CommentManager _commentManager;

		public FormComment(Post post, CommentManager commentManager)
		{
			InitializeComponent();

			_post = post;
			_commentManager = commentManager;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			_post.Comments.Add(_commentManager.CreateComment(txtName.Text, txtComment.Text));
			this.Close();
		}
	}
}
