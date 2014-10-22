using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBlog2
{
	public class CommentManager
	{
		private static int _id;

		public Comment CreateComment(string name, string text)
		{
			DateTime date = DateTime.Now;
			_id++;
			return new Comment(_id, date, name, text);
		}

		public CommentManager()
		{
			_id = 0;
		}
	}
}
