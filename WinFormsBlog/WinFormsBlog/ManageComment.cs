using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBlog
{
	public class ManageComment : Manage
	{
		public override Comment CreateComment()
		{
			DateTime date = DateTime.Now;
			Console.WriteLine("Ange namn: ");
			string name = Console.ReadLine();
			Console.WriteLine("Skriv in din text: ");
			string text = Console.ReadLine();
			List<Comment> comments = new List<Comment>();

			return new Comment(date, text, name);
		}

		public override void DeleteCommentById(List<Comment> comments, int id)
		{
			for (int i = 0; i < comments.Count(); i++)
			{
				if (comments[i].Id == id)
				{
					comments.Remove(comments[i]);
					return;
				}
			}
		}
	}
}
