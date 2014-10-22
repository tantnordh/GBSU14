using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBlog2
{
	public class Post
	{
		public int Id { get; private set; }
		public DateTime Date { get; private set; }
		public string Title { get; set; }
		public string Text { get; set; }
		public List<string> Tags { get; set; }
		public List<Comment> Comments { get; set; }

		public Post(int id, DateTime date, string title, string text)
		{
			Id = id;
			Date = date;
			Title = title;
			Text = text;
			Tags = new List<string>();
			Comments = new List<Comment>();
		}
	}
}
