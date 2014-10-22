﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsBlog2
{
	public class PostManager
	{
		private static int _id;

		public List<Post> Posts { get; private set; }
		public Post SelectedPost { get; set; }

		public void CreatePost(string title, string text, string tags)
		{
			Post post = new Post(_id, DateTime.Now, title, text);

			if (tags != null)
				post.Tags = new List<string>(tags.Split(','));

			Posts.Add(post);

			_id++;
		}

		public PostManager()
		{
			_id = 1;
			Posts = new List<Post>();
		}

		public void PrintSinglePost(RichTextBox richTextBox1, Post post)
		{
			string tags = GetTags(post);
			string info = SetPostInfo(post, tags);

			post.Title.PrintTitle(richTextBox1);
			post.Text.PrintBodyText(richTextBox1);
			info.PrintPostInfo(richTextBox1);
			PrintComments(post, richTextBox1);
		}

		private void PrintComments(Post post, RichTextBox richTextBox)
		{
			string comments = "Comments";
			if (post.Comments.Count > 0)
			{
				comments.PrintSubTitle(richTextBox);
			}

			List<Comment> orderedComments = post.Comments.OrderByDescending(p => p.Date).ToList();
			for (int i = 0; i < orderedComments.Count; i++)
			{
				string info = SetCommentInfo(orderedComments[i]);
				info.PrintBodyText(richTextBox);
				orderedComments[i].Text.PrintBodyText(richTextBox);
				richTextBox.AppendText(Environment.NewLine);
			}
		}

		private string SetCommentInfo(Comment comment)
		{
			return "Datum: " + comment.Date.ToShortDateString() + " | Namn: " + comment.Name;
		}

		private static string SetPostInfo(Post post, string tags)
		{
			string info;
			if (tags != string.Empty)
			{
				info = "Datum: " + post.Date.ToShortDateString() + " | " + "Taggar: " + tags;
			}
			else
			{
				info = "Datum: " + post.Date.ToShortDateString();
			}
			return info;
		}

		private static string GetTags(Post post)
		{
			string tags = string.Empty;
			if (post.Tags != null)
			{
				tags = post.Tags[0];
				if (post.Tags.Count > 1)
				{
					for (int i = 1; i < post.Tags.Count; i++)
					{
						tags += ", " + post.Tags[i];
					}
				}
			}
			return tags;
		}
		

		public void PrintAllPosts(RichTextBox richTextBox1)
		{
			for (int i = 0; i < Posts.Count; i++)
			{
				Posts[i].Title.PrintTitle(richTextBox1);
				Posts[i].Text.PrintBodyText(richTextBox1);
				richTextBox1.AppendText(Environment.NewLine);
			}
		}
	}
}
