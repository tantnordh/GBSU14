using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassesInCommon;

namespace WinFormsVersion
{
	public partial class FormMain : Form
	{
		private static WFPostManager _postManager;
		private static CommentManager _commentManager;

		public FormMain()
		{
			InitializeComponent();

			_postManager = new WFPostManager();
			_commentManager = new CommentManager();
			GenerateTestPosts.GetPosts(3, _postManager, _commentManager);

			comboBoxSearch.DataSource = new List<string> { "Välj sökmetod", "Sök på rubrik", "Sök på datum", "Sök på tagg" };
			LoadComboBoxTitles();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			RevealPostCreation();
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			ConcealExtras();
			PrintPosts(_postManager.Posts);
		}

		private void btnShowSingle_Click(object sender, EventArgs e)
		{
			ConcealExtras();
			_postManager.SelectedPost = (Post) comboBoxTitles.SelectedItem;
			PrintPost(_postManager.SelectedPost);
		}

		private void btnComment_Click(object sender, EventArgs e)
		{
			var commentForm = new FormComment(_postManager.SelectedPost, _commentManager);
			commentForm.ShowDialog();

			mainBox.Clear();
			ConcealPostEdit();
			_postManager.PrintSinglePost(mainBox, _postManager.SelectedPost);
		}

		private void btnQuit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (comboBoxSearch.SelectedIndex == 0)
			{
				txtSearch.Text = "Du har inte valt sökmetod";
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
			_postManager.CreatePost(txtTitle.Text, txtBodyText.Text, txtTags.Text);
			PrintPost(_postManager.SelectedPost);
			LoadComboBoxTitles();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			RevealPostEdit();
		}

		private void btnSaveChanges_Click(object sender, EventArgs e)
		{
			_postManager.SelectedPost.Title = txtTitle.Text;
			_postManager.SelectedPost.Text = txtBodyText.Text;
			_postManager.SelectedPost.Tags = new List<string>(txtTags.Text.Split(','));

			ConcealPostEdit();
			PrintPost(_postManager.SelectedPost);
			LoadComboBoxTitles();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			_postManager.DeletePost();
			mainBox.Clear();
			ConcealButtons();
			LoadComboBoxTitles();
		}

		private void LoadComboBoxTitles()
		{
			comboBoxTitles.DataSource = null;
			comboBoxTitles.DataSource = _postManager.Posts;
			comboBoxTitles.DisplayMember = "Title";
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

		private void PrintPost(Post post)
		{
			mainBox.Clear();
			_postManager.PrintSinglePost(mainBox, post);
			RevealButtons();
		}

		private void PrintPosts(List<Post> posts)
		{
			mainBox.Clear();
			_postManager.PrintPosts(mainBox, posts);
			ConcealButtons();
		}

		private void PrintSearchResult(List<Post> foundPosts)
		{
			ConcealExtras();

			if (foundPosts.Count == 0)
			{
				mainBox.Clear();
				string text = "Din sökning gav ingen träff.";
				text.PrintBodyText(mainBox);
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

		private void ConcealExtras()
		{
			ConcealPostEdit();
			ConcealPostCreation();
		}

		private void ConcealPostCreation()
		{
			txtTitle.Visible = false;
			txtBodyText.Visible = false;
			txtTags.Visible = false;
			btnSavePost.Visible = false;
			btnCreate.Visible = true;
		}

		private void RevealPostCreation()
		{
			mainBox.Clear();
			txtTitle.Visible = true;
			txtBodyText.Visible = true;
			txtTags.Visible = true;
			btnCreate.Visible = false;
			btnSavePost.Visible = true;

			ConcealButtons();
		}

		private void ConcealPostEdit()
		{
			txtTitle.Visible = false;
			txtBodyText.Visible = false;
			txtTags.Visible = false;
			btnSaveChanges.Visible = false;
			btnEdit.Visible = true;
		}

		private void RevealPostEdit()
		{
			mainBox.Clear();
			txtTitle.Visible = true;
			txtTitle.Text = _postManager.SelectedPost.Title;
			txtBodyText.Visible = true;
			txtBodyText.Text = _postManager.SelectedPost.Text;
			txtTags.Visible = true;
			txtTags.Text = _postManager.GetTags(_postManager.SelectedPost);
			btnEdit.Visible = false;
			btnSaveChanges.Visible = true;
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
