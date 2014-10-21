using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBlog
{
	public class Manage
	{
		public virtual Post CreatePost()
		{
			return null;
		}
		public virtual Comment CreateComment()
		{
			return null;
		}

		public virtual void DeletePostById(List<Post> posts, int id, Blog blog)
		{
		}

		public virtual void DeleteCommentById(List<Comment> comments, int id)
		{
		}
	}
}
