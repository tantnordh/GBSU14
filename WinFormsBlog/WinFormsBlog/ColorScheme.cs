using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBlog
{
	public static class ColorScheme
	{
		public static void General()
		{
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.DarkGray;
		}

		public static void Header1()
		{
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
		}

		public static void Header2()
		{
			Console.ForegroundColor = ConsoleColor.DarkGreen;
		}

	}
}
