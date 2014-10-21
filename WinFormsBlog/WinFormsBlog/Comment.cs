using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBlog
{
	[Serializable]
	public class Comment : Entry
	{
		public string Name { get; set; }

		public int Id { get; set; }

		public string CommentText { get; set; }

		public DateTime CommentDate { get; set; }

		private static int commentNumber = 0;

		//Det behövs en tom konstruktor för att xml:en ska fungera
		public Comment()
		{
		}

		public Comment(DateTime date, string text, string name)
			: base(date, text)
		{
			Name = name;
			CommentText = text;
			CommentDate = date;
			Id = commentNumber;
			commentNumber++;
		}
	}
}
