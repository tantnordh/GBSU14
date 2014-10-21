using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBlog
{
	public class SinglePostMenu
	{
		public static void PostMenu(Post post, Blog blog)
		{
			ColorScheme.Header1();
			Console.WriteLine("MENY");
			ColorScheme.General();
			Console.WriteLine("(1) Kommentera");
			Console.WriteLine("(2) Uppdatera");
			Console.WriteLine("(3) Radera kommentar");
			Console.WriteLine("(4) Radera inlägg");
			Console.WriteLine();
			Console.WriteLine("(0) Gå till huvudmenyn");
			Console.WriteLine();
			Console.WriteLine("Ange ditt val: ");

			HandleMenuChoice(post, blog);
		}

		private static void HandleMenuChoice(Post post, Blog blog)
		{
			int choice;
			while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 4)
			{
				Console.WriteLine("Försök med ett heltal 0-4: ");
			}

			if (choice == 0)
			{
				return;
			}

			ManageComment commentManager = new ManageComment();
			ManagePost postManager = new ManagePost();

			switch (choice)
			{
				case 1:
					Console.WriteLine("\nLÄMNA KOMMENTAR\n");
					Comment newComment = commentManager.CreateComment();
					post.Comments.Add(newComment);
					Console.WriteLine("Tryck på retur för att återgå till huvudmenyn.");
					Console.ReadLine();
					break;

				case 2:
					Post updatedPost = postManager.Update(post, blog);
					for (int i = 0; i < blog.Posts.Count; i++)
					{
						if (updatedPost.Id == post.Id)
						{
							post = updatedPost;
							return;
						}
					}
					break;

				case 3:
					Console.WriteLine("\nRADERA KOMMENTAR\n");
					Console.WriteLine("Ange kommentarsID: ");
					int commentToDelete = int.Parse(Console.ReadLine());
					commentManager.DeleteCommentById(post.Comments, commentToDelete);
					break;

				case 4:
					Console.WriteLine("\nRADERA INLÄGG\n");
					Console.WriteLine("Ange inläggsID: ");
					int postToDelete = int.Parse(Console.ReadLine());
					postManager.DeletePostById(blog.Posts, postToDelete, blog);

					break;

				case 0:
					Environment.Exit(0);
					break;

				default:
					Console.WriteLine("Valet du gjorde är inte tillgängligt");
					break;
			}
		}
	}
}
