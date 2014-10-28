using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassesInCommon;

namespace WinFormsVersion
{
	public class WFPostManager : PostManager
	{
		public void PrintSinglePost(RichTextBox richTextBox1, Post post)
		{
			string tags = GetTags(post);
			string info = SetPostInfo(post, tags);

			post.Title.PrintTitle(richTextBox1);
			post.Text.PrintBodyText(richTextBox1);
			info.PrintPostInfo(richTextBox1);
			PrintComments(post, richTextBox1); 
		}

		public void PrintComments(Post post, RichTextBox richTextBox)
		{
			string comments = "Kommentarer (" + post.Comments.Count + ")";
			if (post.Comments.Count > 0)
			{
				richTextBox.AppendText(Environment.NewLine);
				comments.PrintSubTitle(richTextBox);
			}

			List<Comment> orderedComments = post.Comments.OrderByDescending(p => p.Date).ToList();
			for (int i = 0; i < orderedComments.Count; i++)
			{
				string info = SetCommentInfo(orderedComments[i]);
				info.PrintPostInfo(richTextBox);
				orderedComments[i].Text.PrintBodyText(richTextBox);
				richTextBox.AppendText(Environment.NewLine);
			}
		}

		public void PrintPosts(RichTextBox richTextBox1, List<Post> posts)
		{
			for (int i = 0; i < posts.Count; i++)
			{
				posts[i].Title.PrintTitle(richTextBox1);
				posts[i].Text.PrintBodyText(richTextBox1);
				richTextBox1.AppendText(Environment.NewLine);
			}
		}
	}
}
