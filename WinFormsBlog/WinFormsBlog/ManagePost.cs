using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBlog
{
	public class ManagePost : Manage
	{
		public override Post CreatePost()
		{
			DateTime date = DateTime.Now;
			Console.WriteLine("Ange titel: ");
			string title = Console.ReadLine();
			Console.WriteLine("Skriv in din text: ");
			string text = Console.ReadLine();
			List<Comment> comments = new List<Comment>();

			Post temp = new Post(date, text, title);
			Console.WriteLine("Tagga inlägget (eller lämna fältet tomt och tryck retur), separera taggar med kommatecken: ");
			temp.Tags = new List<string>(Console.ReadLine().Split(','));
			return temp;
		}

		public Post Update(Post post, Blog blog)
		{
			Console.Clear();
			Print.PrintPostSummary(post);
			Console.WriteLine();
			Console.WriteLine("Skriv in text att lägga till.");
			post.Text = post.Text + "\n" + Console.ReadLine();
			return post;
		}

		public void GetPostById(List<Post> posts, int id)
		{
			Post post;
			for (int i = 0; i < posts.Count(); i++)
			{
				if (posts[i].Id == id)
				{
					post = posts[i];
					Print.PrintPost(post);
				}
			}
		}

		public override void DeletePostById(List<Post> posts, int id, Blog blog)
		{
			for (int i = 0; i < posts.Count(); i++)
			{
				if (posts[i].Id == id)
				{
					posts.Remove(posts[i]);
					return;
				}
			}
		}
	}
}
