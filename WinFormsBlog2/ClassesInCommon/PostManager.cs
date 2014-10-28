using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesInCommon
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
			SelectedPost = post;

			_id++;
		}

		public string SetCommentInfo(Comment comment)
		{
			return "Datum: " + comment.Date.ToShortDateString() + " | Namn: " + comment.Name;
		}

		public string SetPostInfo(Post post, string tags)
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

		public string GetTags(Post post)
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

		public void DeletePost()
		{
			Posts = Posts.Where(p => p != SelectedPost).ToList();
			SelectedPost = null;
		}

		public PostManager()
		{
			_id = 1;
			Posts = new List<Post>();
		}
	}
}
