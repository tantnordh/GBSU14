using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBlog
{
	[Serializable]
	public class Post : Entry
	{
		public string Title { get; set; }

		public List<string> Tags { get; set; }

		public List<Comment> Comments { get; set; }

		public int Id { get; set; }

		private static int postNumber = 0;

		//Det behövs en tom konstruktor för att xml:en ska fungera
		public Post()
		{
		}

		public Post(DateTime date, string text, string title)
			: base(date, text)
		{
			Id = postNumber;
			postNumber++;
			Text = text;
			Title = title;
			Comments = new List<Comment>();
			Tags = new List<string>();
		}
	}
}
