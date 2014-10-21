using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBlog
{
	public static class Print
	{
		public static void PrintPostSummary(Post post)
		{
			ColorScheme.Header1();
			Console.WriteLine(post.Date.ToShortDateString() + " | " + post.Title.ToUpper());
			ColorScheme.General();
			Console.WriteLine(post.Text);
			Console.WriteLine();
		}

		public static void PrintPost(Post post)
		{
			List<string> tagList = new List<string>();
			for (int i = 0; i < post.Tags.Count; i++)
			{
				tagList.Add(post.Tags[i]);
			}
			string tagsAsString = string.Join(", ", tagList.ToArray());

			PrintPostSummary(post);
			ColorScheme.Header2();
			Console.WriteLine("InläggsID: " + post.Id + " | Taggar: " + tagsAsString + "\n\n");

			if (post.Comments.Count != 0)
			{
				ColorScheme.Header1();
				Console.WriteLine("KOMMENTARER");
			}
			for (int i = 0; i < post.Comments.Count; i++)
			{
				PrintComment(post.Comments[i]);
				Console.WriteLine();
			}
		}

		private static void PrintComment(Comment comment)
		{
			ColorScheme.Header2();
			Console.WriteLine("KommentarsID: " + comment.Id + " | " + comment.Date.ToShortDateString() + " | " + comment.Name + " säger:");
			ColorScheme.General();
			Console.WriteLine(comment.Text);
		}

		public static void PrintNoResult()
		{
			Console.WriteLine("Inlägget du söker går inte att finna.");
		}

		public static void PrintEntryTitles(List<Post> matches)
		{
			if (matches.Count == 0)
			{
				PrintNoResult();
				return;
			}
			if (matches.Count == 1)
			{
				PrintAllEntries(matches);
				return;
			}
			for (int i = 0; i < matches.Count; i++)
			{
				Console.WriteLine("(" + (i + 1) + ") " + matches[i].Title);
			}
		}

		public static void PrintAllEntries(List<Post> posts)
		{
			for (int i = 0; i < posts.Count; i++)
			{
				Console.Write("(" + (i + 1) + ") ");
				PrintPostSummary(posts[i]);
			}

		}
	}
}
