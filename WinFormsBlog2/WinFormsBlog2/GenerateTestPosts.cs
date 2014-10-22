using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBlog2
{
	public static class GenerateTestPosts
	{
		private static PostManager _postManager;
		private static CommentManager _commentManager;

		public static void GetPosts(int numberOfPosts, PostManager postManager, CommentManager commentManager)
		{
			_postManager = postManager;
			_commentManager = commentManager;

			for (int i = 0; i < numberOfPosts; i++)
			{
				CreateTestPost(i);
			}
		}

		private static Post CreateTestPost(int number)
		{
			string title = "Testrubrik " + (number + 1);
			string text = "Testinlägg " + (number + 1) + " med en massa text hit och dit.";
			string tags = "test" + (number + 1) + ", testinlägg";
			string commentName = "Testkommenterare";
			string commentText = "Testkommentar till testinlägg " + (number + 1); 


			_postManager.CreatePost(title, text, tags);
			_postManager.Posts[number].Comments.Add(_commentManager.CreateComment(commentName, commentText));

			return _postManager.Posts[number];
		}

	}
}
