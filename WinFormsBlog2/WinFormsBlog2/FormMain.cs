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

			comboBoxSearch.DataSource = new List<string> { "Välj sökmetod", "Sök på rubrik", "Sök på datum", "Sök på tagg" };
			LoadComboBoxTitles();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			richTextBox1.Clear();
			RevealPostCreation();
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			PrintPosts(_postManager.Posts);
		}

		private void btnShowSingle_Click(object sender, EventArgs e)
		{
			_postManager.SelectedPost = (Post) comboBoxTitles.SelectedItem;
			PrintPost(_postManager.SelectedPost);
		}

		private void btnComment_Click(object sender, EventArgs e)
		{
			var commentForm = new FormComment(_postManager.SelectedPost, _commentManager);
			commentForm.ShowDialog();

			richTextBox1.Clear();
			_postManager.PrintSinglePost(richTextBox1, _postManager.SelectedPost);
		}

		private void btnQuit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (comboBoxSearch.SelectedIndex == 0)
			{
				txtSearch.Text = "Du har inte valt sökmetod.";
			}
			else if (comboBoxSearch.SelectedIndex == 1)
			{
				List<Post> foundPosts = _postManager.Posts.SearchByTitle(txtSearch.Text);
				PrintSearchResult(foundPosts);
			}
			else if (comboBoxSearch.SelectedIndex == 2)
			{
				List<Post> foundPosts = _postManager.Posts.SearchByDate(txtSearch.Text);
				PrintSearchResult(foundPosts);
			}
			else if (comboBoxSearch.SelectedIndex == 3)
			{
				List<Post> foundPosts = _postManager.Posts.SearchByTag(txtSearch.Text);
				PrintSearchResult(foundPosts);
			}
		}

		private void btnSavePost_Click(object sender, EventArgs e)
		{
			ConcealPostCreation();
			_postManager.CreatePost(txtRubrik.Text, txtBodyText.Text, txtTags.Text);
			PrintPost(_postManager.SelectedPost);
			LoadComboBoxTitles();
		}

		private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxSearch.SelectedIndex == 0)
			{
				txtSearch.Text = null;
			}
			else if (comboBoxSearch.SelectedIndex == 1)
			{
				txtSearch.Text = "Rubrik";
			}
			else if (comboBoxSearch.SelectedIndex == 2)
			{
				txtSearch.Text = "ÅÅÅÅ-MM-DD";
			}
			else if (comboBoxSearch.SelectedIndex == 3)
			{
				txtSearch.Text = "Tagg";
			}
		}

		private void LoadComboBoxTitles()
		{
			comboBoxTitles.DataSource = _postManager.Posts;
			comboBoxTitles.DisplayMember = "Title";
		}

		private void PrintPost(Post post)
		{
			richTextBox1.Clear();
			_postManager.PrintSinglePost(richTextBox1, post);
			RevealButtons();
		}

		private void PrintPosts(List<Post> posts)
		{
			richTextBox1.Clear();
			_postManager.PrintPosts(richTextBox1, posts);
			ConcealButtons();
		}

		private void PrintSearchResult(List<Post> foundPosts)
		{
			if (foundPosts.Count == 0)
			{
				string text = "Din sökning gav ingen träff.";
				text.PrintBodyText(richTextBox1);
				ConcealButtons();
			}
			else if (foundPosts.Count == 1)
			{
				_postManager.SelectedPost = foundPosts[0];
				PrintPost(_postManager.SelectedPost);
			}
			else
			{
				PrintPosts(foundPosts);
			}
		}

		private void ConcealPostCreation()
		{
			txtRubrik.Visible = false;
			txtBodyText.Visible = false;
			txtTags.Visible = false;
			btnSavePost.Visible = false;
		}

		private void RevealPostCreation()
		{
			txtRubrik.Visible = true;
			txtBodyText.Visible = true;
			txtTags.Visible = true;
			btnSavePost.Visible = true;

			ConcealButtons();
		}

		private void ConcealButtons()
		{
			btnComment.Visible = false;
			btnEdit.Visible = false;
			btnDelete.Visible = false;
		}

		private void RevealButtons()
		{
			btnComment.Visible = true;
			btnEdit.Visible = true;
			btnDelete.Visible = true;
		}

		private void ShiftFocus(object sender, EventArgs e)
		{
			SelectNextControl(comboBoxSearch, false, true, true, true);
		}
	}
}
