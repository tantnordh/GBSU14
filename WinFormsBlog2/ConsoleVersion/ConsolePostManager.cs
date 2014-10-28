using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesInCommon;

namespace ConsoleVersion
{
	public class ConsolePostManager : PostManager
	{
		public void PrintSinglePost(Post post)
		{
			string tags = GetTags(post);
			string info = SetPostInfo(post, tags);

			post.Title.PrintTitle();
			post.Text.PrintBodyText();
			info.PrintPostInfo();
			PrintComments(post); 
		}

		public void PrintComments(Post post)
		{
			string comments = "Kommentarer (" + post.Comments.Count + ")";
			if (post.Comments.Count > 0)
			{
				Console.WriteLine();
				comments.PrintSubTitle();
			}

			List<Comment> orderedComments = post.Comments.OrderByDescending(p => p.Date).ToList();
			for (int i = 0; i < orderedComments.Count; i++)
			{
				string info = SetCommentInfo(orderedComments[i]);
				info.PrintPostInfo();
				orderedComments[i].Text.PrintBodyText();
				Console.WriteLine();
			}
		}

		public void PrintPosts(List<Post> posts)
		{
			for (int i = 0; i < posts.Count; i++)
			{
				posts[i].Title.PrintTitle();
				posts[i].Text.PrintBodyText();
				Console.WriteLine();
			}
		}
	}
}
