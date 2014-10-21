using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBlog
{
	[Serializable]
	public class Entry
	{
		public DateTime Date { get; set; }

		public string Text { get; set; }

		//Det behövs en tom konstruktor för att xml:en ska fungera
		public Entry()
		{
		}

		public Entry(DateTime date, string text)
		{
			Date = date;
			Text = text;
		}
	}
}
