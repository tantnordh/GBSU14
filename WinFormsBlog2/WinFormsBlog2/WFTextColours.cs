﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsVersion
{
	public static class WFTextColours
	{
		public static void PrintTitle(this string text, RichTextBox richTextBox)
		{
			richTextBox.SelectionFont = new Font("Bookman Old Style", 24f, FontStyle.Regular);
			richTextBox.SelectionColor = Color.DarkMagenta;
			richTextBox.AppendText(text);
			richTextBox.AppendText(Environment.NewLine);
		}

		public static void PrintSubTitle(this string text, RichTextBox richTextBox)
		{
			richTextBox.SelectionFont = new Font("Arial", 14f, FontStyle.Regular);
			richTextBox.SelectionColor = Color.DarkMagenta;
			richTextBox.AppendText(text);
			richTextBox.AppendText(Environment.NewLine);
		}

		public static void PrintBodyText(this string text, RichTextBox richTextBox)
		{
			richTextBox.SelectionFont = new Font("Arial", 11f, FontStyle.Regular);
			richTextBox.SelectionColor = Color.Gray;
			richTextBox.AppendText(text);
			richTextBox.AppendText(Environment.NewLine);
		}

		public static void PrintPostInfo(this string text, RichTextBox richTextBox)
		{
			richTextBox.SelectionFont = new Font("Arial", 11f, FontStyle.Regular);
			richTextBox.SelectionColor = Color.Goldenrod;
			richTextBox.AppendText(text);
			richTextBox.AppendText(Environment.NewLine);
		}
	}
}
