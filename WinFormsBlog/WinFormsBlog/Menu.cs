using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBlog
{
	public static class Menu
	{
		public static void ShowMenu()
		{
			Console.Clear();
			ColorScheme.Header1();
			Console.WriteLine("HUVUDMENY\n");
			ColorScheme.General();
			Console.WriteLine("(1) Skapa inlägg");
			Console.WriteLine("(2) Visa blogg");
			Console.WriteLine("(3) Visa rubriklista");
			Console.WriteLine("(4) Sök inlägg via rubrik");
			Console.WriteLine("(5) Sök inlägg via datum ");
			Console.WriteLine("(6) Sök inlägg via taggar ");
			Console.WriteLine("(0) Avsluta");
		}

		public static int GetMenuChoice()
		{
			Console.WriteLine();
			Console.Write("Ange ditt val med ett heltal 0-6: ");
			try
			{
				int temp = int.Parse(Console.ReadLine());
				if (temp > 6 || temp < 0)
				{
					Console.WriteLine("\nFörsök med ett heltal 0-6.");
					return GetMenuChoice();
				}
				return temp;
			}
			catch (FormatException)
			{
				Console.WriteLine("\nFörsök med ett heltal 0-6.");
				return GetMenuChoice();
			}
			catch (OverflowException)
			{
				Console.WriteLine("\nFörsök med ett heltal 0-6.");
				return GetMenuChoice();
			}
		}

		public static void HandleMenuChoice(Blog blog, int menuChoice)
		{
			Console.Clear();
			ManagePost postManager = new ManagePost();
			List<Post> _matchList = new List<Post>();

			switch (menuChoice)
			{
				case 1:
					ColoredHeader("SKAPA INLÄGG");
					blog.Posts.Add(postManager.CreatePost());
					Console.WriteLine();
					Console.WriteLine("Tryck på retur för att komma till huvudmenyn.");
					Console.ReadLine();
					break;

				case 2:
					ColoredHeader("ALLA INLÄGG");
					Print.PrintAllEntries(blog.Posts);
					ChooseEntry(blog.Posts, blog);
					break;

				case 3:
					ColoredHeader("ALLA RUBRIKER");
					Print.PrintEntryTitles(blog.Posts);
					ChooseEntry(blog.Posts, blog);
					break;

				case 4:
					ColoredHeader("SÖK PÅ RUBRIK");
					_matchList = Search.SearchByTitle(blog.Posts, GetTitleToSearchFor());
					Console.Clear();
					ColoredHeader("SÖKRESULTAT");
					Print.PrintEntryTitles(_matchList);
					ChooseEntry(_matchList, blog);
					break;

				case 5:
					ColoredHeader("SÖK PÅ DATUM");
					_matchList = Search.SearchByDate(blog.Posts, GetDateToSearchFor());
					Console.Clear();
					ColoredHeader("SÖKRESULTAT");
					Print.PrintEntryTitles(_matchList);
					ChooseEntry(_matchList, blog);
					break;

				case 6:
					ColoredHeader("SÖK PÅ TAGG");
					_matchList = Search.SearchByTag(blog.Posts, GetTagsToSearchFor());
					Console.Clear();
					ColoredHeader("SÖKRESULTAT");
					Print.PrintEntryTitles(_matchList);
					ChooseEntry(_matchList, blog);
					break;

				case 0:
					XmlParser.Serialize(blog, blog.Posts);
					Environment.Exit(0);
					break;

				default:
					Console.WriteLine("Valet du gjorde är inte tillgängligt");
					break;
			}
		}

		private static void ColoredHeader(string header)
		{
			ColorScheme.Header1();
			Console.WriteLine(header);
			ColorScheme.General();
			Console.WriteLine();
		}

		private static void ChooseEntry(List<Post> posts, Blog blog)
		{
			Console.WriteLine("\n(0) Gå till huvudmenyn");
			Console.WriteLine("\nAnge ditt val: ");
			int choice;
			while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > posts.Count)
			{
				Console.WriteLine("Försök med ett heltal 0-" + posts.Count + ".");
			}

			for (int i = 1; i <= posts.Count; i++)
			{
				if (i == choice)
				{
					Console.Clear();
					Print.PrintPost(posts[i - 1]);
					SinglePostMenu.PostMenu(posts[i - 1], blog);
				}
			}
		}

		private static string GetTitleToSearchFor()
		{
			Console.Write("Skriv in ordet i rubriken du vill söka på: ");
			string temp = Console.ReadLine();
			if (temp.Trim() == string.Empty)
			{
				Console.WriteLine("\nDu har inte skrivit in någon rubrik. Försök igen.\n");
				return GetTitleToSearchFor();
			}
			return temp;
		}

		private static DateTime GetDateToSearchFor()
		{
			Console.Write("Skriv in det datum du vill söka på (ÅÅÅÅ-MM-DD): ");
			try
			{
				return Convert.ToDateTime(Console.ReadLine());
			}
			catch (FormatException)
			{
				Console.WriteLine("\nOgiltigt datumformat. Försök igen med formatet ÅÅÅÅ-MM-DD.\n");
				return GetDateToSearchFor();
			}
		}

		private static string GetTagsToSearchFor()
		{
			Console.Write("Skriv in den tagg du vill söka på: ");
			string temp = Console.ReadLine();
			if (temp.Trim() == string.Empty)
			{
				Console.WriteLine("\nDu har inte skrivit in någon tagg. Försök igen.\n");
				return GetTagsToSearchFor();
			}
			return temp;
		}
	}
}
