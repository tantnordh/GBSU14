using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBlog
{
	public class Search
	{
		private static List<Post> _matchList;

		public static List<Post> SearchByTitle(List<Post> posts, string searchTitle)
		{
			_matchList = new List<Post>();
			for (int i = 0; i < posts.Count(); i++)
			{
				if (posts[i].Title.ToLower().Contains(searchTitle.ToLower()))
				{
					_matchList.Add(posts[i]);
				}
			}

			return _matchList;
		}

		public static List<Post> SearchByDate(List<Post> posts, DateTime searchDateTime)
		{
			_matchList = new List<Post>();

			for (int i = 0; i < posts.Count(); i++)
			{
				if (posts[i].Date.ToShortDateString() == searchDateTime.ToShortDateString()) // ToShortDateString på båda för att enbart jämföra datum utan att ta hänsyn till klockslag.
				{
					_matchList.Add(posts[i]);
				}
			}

			return _matchList;
		}

		public static List<Post> SearchByTag(List<Post> posts, string searchTag)
		{
			_matchList = new List<Post>();
			for (int i = 0; i < posts.Count(); i++)
			{
				for (int j = 0; j < posts[i].Tags.Count(); j++)
				{
					if (posts[i].Tags[j] != null && posts[i].Tags[j].ToLower().Contains(searchTag.ToLower()))
					{
						_matchList.Add(posts[i]);
					}
				}
			}
			return _matchList;
		}
	}
}
