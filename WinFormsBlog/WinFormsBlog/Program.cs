using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsBlog
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());

			Console.Clear();
			Blog blog = new Blog("Namnet på bloggen");
			Console.Title = blog.Name;
			var testEntries = new CreateTestEntries(blog);
			blog = XmlParser.Deserialize(blog);
			if (blog == null)
			{
				blog = testEntries.GetBlog();

			}
			ColorScheme.General();
			Console.WindowHeight = Console.WindowHeight * 3 / 2;

			int menuChoice = -1;
			while (menuChoice != 0)
			{
				Menu.ShowMenu();
				menuChoice = Menu.GetMenuChoice();
				Menu.HandleMenuChoice(blog, menuChoice);
			}
		}
	}
}

