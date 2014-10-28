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
			Console.Clear();
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
			Console.Clear();
			string titlePlusNumber;
			for (int i = 0; i < posts.Count; i++)
			{
				titlePlusNumber = "(" + (i+1) + ") " + posts[i].Title;
				titlePlusNumber.PrintTitle();
				posts[i].Text.PrintBodyText();
				Console.WriteLine();
			}
		}

		public void PrintTitles(List<Post> posts)
		{
			string titlePlusNumber;
			for (int i = 0; i < posts.Count; i++)
			{
				titlePlusNumber = "(" + (i + 1) + ") " + posts[i].Title;
				titlePlusNumber.PrintBodyText();
			}
		}
	}
}
