using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinFormsBlogFromScratch
{
	public class Post
	{
		public int PostId { get; set; }
		public string Title { get; set; }
		public DateTime Date { get; set; }
		public string Text { get; set; }
		public List<string> Tags { get; set; }
		public List<Comment> Comments { get; set; }
	}
}
