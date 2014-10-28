using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleVersion
{
	public static class TextColours
	{
		public static void PrintHeader(this string text)
		{
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.WriteLine(text.ToUpper());
		}
	
		public static void PrintTitle(this string text)
		{
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.WriteLine(text.ToUpper());
		}

		public static void PrintSubTitle(this string text)
		{
			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine(text);
		}

		public static void PrintBodyText(this string text)
		{
			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.WriteLine(text);
		}

		public static void PrintPostInfo(this string text)
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine(text);
		}

		public static void PrintInstruction(this string text)
		{
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.WriteLine();
			Console.WriteLine(text);
			Console.ForegroundColor = ConsoleColor.DarkGray;
		}
	}
}
