using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBlog2
{
	public static class Search
	{
		public static List<Post> SearchByTitle(this List<Post> posts, string title)
		{
			return posts.Where(p => p.Title.ToLower().Contains(title.ToLower())).ToList();
		}

		public static List<Post> SearchByDate(this List<Post> posts, string date)
		{
			return posts.Where(p => p.Date.ToShortDateString() == date).ToList();
		}

		public static List<Post> SearchByTag(this List<Post> posts, string tag)
		{
			return posts.Where(p => p.Tags.Any(t => t.Contains(tag))).ToList();
		}
	}
}
