﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleVersion
{
	public static class TextColours
	{
		public static void PrintTitle(this string text)
		{
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.WriteLine(text);
			Console.WriteLine();
		}

		public static void PrintSubTitle(this string text)
		{
			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine(text);
			Console.WriteLine();
		}

		public static void PrintBodyText(this string text)
		{
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine(text);
			Console.WriteLine();
		}

		public static void PrintPostInfo(this string text)
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine(text);
			Console.WriteLine();
		}
	}
}