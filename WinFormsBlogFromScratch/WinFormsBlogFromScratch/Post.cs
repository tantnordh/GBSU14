using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinFormsBlogFromScratch
{
	public class Post
	{
		public int PostId { get; private set; }
		public string Title { get; private set; }
		public DateTime Date { get; private set; }
		public string Text { get; set; }
		public List<string> Tags { get; private set; }
		public List<Comment> Comments { get; private set; }

		public Post(int postid, string title, DateTime date, List<string> tags)
		{
			PostId = postid;
			Title = title;
			Date = date;
			Tags = tags;
			Comments = new List<Comment>();
		}
	}
}
