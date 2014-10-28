using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesInCommon;

namespace ConsoleVersion
{
	public static class MainMenu
	{
		private static ConsolePostManager _postManager = new ConsolePostManager();
		private static CommentManager _commentManager = new CommentManager();

		public static void Run()
		{
			GenerateTestPosts.GetPosts(3, _postManager, _commentManager);

			int menuChoice = -1;
			while (menuChoice != 0)
			{
				ShowMainMenu();
				HandleMenuChoice(GetMenuChoice());
				string instruction = "Tryck på valfri tangent för att återgå till huvudmenyn.";
				instruction.PrintInstruction();
				Console.ReadKey();
			}
		}

		private static void ShowMainMenu()
		{
			Console.Clear();
			string header = "Huvudmeny";
			string options = "(1) Skapa inlägg\n(2) Visa blogg\n(3) Visa rubriklista\n" +
							 "(4) Sök inlägg via rubrik\n(5) Sök inlägg via datum\n(6) Sök inlägg via taggar\n(0) Avsluta";

			header.PrintHeader();
			Console.WriteLine();
			options.PrintBodyText();
		}

		private static int GetMenuChoice()
		{
			string instruction = "Ange ditt val med ett heltal 0-6: ";
			string exceptionMessage = "Försök med ett heltal 0-6.";
			instruction.PrintInstruction();

			int choice;

			while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 6)
			{
				exceptionMessage.PrintInstruction();
			}

			return choice;
		}

		private static void HandleMenuChoice(int menuChoice)
		{
			Console.Clear();
			string header;

			switch (menuChoice)
			{
				case 1:
					header = "Skapa inlägg";
					header.PrintHeader();
					Console.WriteLine();

					_postManager.CreatePost(GetPostTitle(), GetEntryText(), GetTags());
					_postManager.PrintSinglePost(_postManager.SelectedPost);
					break;

				case 2:
					header = "Alla inlägg";
					header.PrintHeader();
					Console.WriteLine();

					_postManager.PrintPosts(_postManager.Posts);
					break;

				case 3:
					header = "Alla rubriker";
					header.PrintHeader();
					Console.WriteLine();

					_postManager.PrintTitles(_postManager.Posts);
					break;

				case 4:
					header = "Sök på rubrik";
					header.PrintHeader();
					Console.WriteLine();

					PrintSearchResult(_postManager.Posts.SearchByTitle(GetPostTitle()));
					break;

				case 5:
					header = "Sök på datum";
					header.PrintHeader();
					Console.WriteLine();

					PrintSearchResult(_postManager.Posts.SearchByDate(GetDate()));
					break;

				case 6:
					header = "Sök på tagg";
					header.PrintHeader();
					Console.WriteLine();

					PrintSearchResult(_postManager.Posts.SearchByTag(GetTag()));
					break;

				case 0:
					Environment.Exit(0);
					break;
			}
		}

		private static void PrintSearchResult(List<Post> posts)
		{
			
			if (posts.Count == 0)
			{
				Console.Clear();
				string header = "Sökresultat";
				string text = "Din sökning gav inget resultat.";
				header.PrintHeader();
				Console.WriteLine();
				text.PrintBodyText();
			}
			else if (posts.Count == 1)
			{
				_postManager.PrintSinglePost(posts[0]);
			}
			else
			{
				_postManager.PrintPosts(posts);
			}
		}

		private static string GetTag()
		{
			string instruction = "Ange tagg: ";
			instruction.PrintInstruction();

			return Console.ReadLine();
		}

		private static string GetDate()
		{
			string instruction = "Ange datum ÅÅÅÅ-MM-DD: ";
			instruction.PrintInstruction();

			DateTime date;
			while (!DateTime.TryParse(Console.ReadLine(), out date))
			{
				instruction.PrintInstruction();
			}

			return date.ToShortDateString();
		}

		private static string GetTags()
		{
			string instruction = "Ange eventuella taggar, separera med kommatecken: ";
			instruction.PrintInstruction();

			return Console.ReadLine();
		}

		private static string GetEntryText()
		{
			string instruction = "Skriv text: ";
			instruction.PrintInstruction();

			return Console.ReadLine();
		}

		private static string GetPostTitle()
		{
			string instruction = "Ange titel: ";
			instruction.PrintInstruction();

			return Console.ReadLine();
		}
	}
}
