using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBlog
{
	public class XmlParser
	{
		public static void Serialize(Blog blog, List<Post> posts)
		{
			string filename = blog.xmlFileName;

			XmlSerializer serial = new XmlSerializer(typeof(List<Post>));

			System.IO.StreamWriter writer = new System.IO.StreamWriter(@filename);
			serial.Serialize(writer, posts);
		}

		public static Blog Deserialize(Blog blog)
		{
			StreamReader reader;
			string filename = blog.xmlFileName;
			List<Post> posts = new List<Post>();

			XmlSerializer serializer = new XmlSerializer(typeof(List<Post>));
			try
			{
				reader = new StreamReader(filename);
			}
			catch (FileNotFoundException)
			{
				return null;
			}

			posts = (List<Post>)serializer.Deserialize(reader);
			blog.Posts.Clear();
			foreach (var item in posts)
			{
				blog.Posts.Add(item);
			}
			reader.Close();

			return blog;
		}
	}
}
