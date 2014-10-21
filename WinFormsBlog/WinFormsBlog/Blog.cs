using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBlog
{
	[Serializable]
	public class Blog
	{
		public string xmlFileName = "log.xml";

		[Display(Name = "BlogPosts")]
		public List<Post> Posts { get; set; }
		public string Name { get; set; }
		//Det behövs en tom konstruktor för att xml:en ska fungera
		public Blog()
		{

		}
		public Blog(string name)
		{
			Name = name;
			Posts = new List<Post>();
		}
	}
}
