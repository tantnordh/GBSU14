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

			BackToMainAnyKey();
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

			SelectPost(posts);
		}

		public void PrintTitles(List<Post> posts)
		{
			string titlePlusNumber;
			for (int i = 0; i < posts.Count; i++)
			{
				titlePlusNumber = "(" + (i + 1) + ") " + posts[i].Title;
				titlePlusNumber.PrintBodyText();
			}

			SelectPost(posts);
		}

		public void PrintSearchResult(List<Post> posts)
		{

			if (!posts.Any())
			{
				Console.Clear();
				string header = "Sökresultat";
				string text = "Din sökning gav inget resultat.";
				header.PrintHeader();
				Console.WriteLine();
				text.PrintBodyText();

				BackToMainAnyKey();
			}
			else if (posts.Count == 1)
			{
				PrintSinglePost(posts[0]);
			}
			else
			{
				PrintPosts(posts);
			}
		}

		private void SelectPost(List<Post> posts)
		{
			BackToMainMenuZero();
			string instruction = "Ange ditt val som ett heltal 0 - " + posts.Count + ": ";
			Console.WriteLine();
			instruction.PrintInstruction();

			int choice;
			while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 | choice > posts.Count)
			{
				instruction.PrintInstruction();
			}

			if (choice != 0)
			{
				PrintSinglePost(posts[choice - 1]);
			}
		}

		private static void BackToMainMenuZero()
		{
			Console.WriteLine();
			string quit = "(0) Gå till huvudmenyn";
			quit.PrintBodyText();
		}

		private static void BackToMainAnyKey()
		{
			string instruction = "Tryck på valfri tangent för att återgå till huvudmenyn.";
			instruction.PrintInstruction();
			Console.ReadKey();
		}
	}
}
