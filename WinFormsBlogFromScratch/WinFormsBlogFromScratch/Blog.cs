using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBlogFromScratch
{
	public class Blog
	{
		public string Name { get; set; }
		public List<Post> Posts { get; set; }
		public int Id { get; set; }

		public Blog(int id, string name)
		{
			Id = id;
			Name = name;
			Posts = new List<Post>();
		}
	}
}
