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

			ShowMainMenu();
			HandleMenuChoice(GetMenuChoice());
			Console.ReadLine();
		}

		private static void ShowMainMenu()
		{
			Console.Clear();
			string title = "Huvudmeny";
			string options = "(1) Skapa inlägg\n(2) Visa blogg\n(3) Visa rubriklista\n" +
							 "(4) Sök inlägg via rubrik\n(5) Sök inlägg via datum\n(6) Sök inlägg via taggar\n(0) Avsluta";

			title.PrintTitle();
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
			string title;

			switch (menuChoice)
			{
				case 1:
					title = "Skapa inlägg";
					title.PrintTitle();
					_postManager.CreatePost(GetPostTitle(), GetEntryText(), GetTags());
					_postManager.PrintSinglePost(_postManager.SelectedPost);
					break;

				case 2:
					_postManager.PrintPosts(_postManager.Posts);
					break;

				//case 3:
				//	ColoredHeader("ALLA RUBRIKER");
				//	break;

				//case 4:
				//	ColoredHeader("SÖK PÅ RUBRIK");
				//	break;

				//case 5:
				//	ColoredHeader("SÖK PÅ DATUM");
				//	break;

				//case 6:
				//	ColoredHeader("SÖK PÅ TAGG");
				//	break;

				case 0:
					Environment.Exit(0);
					break;
			}
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
