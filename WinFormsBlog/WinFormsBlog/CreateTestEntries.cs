using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBlog
{
	public class CreateTestEntries
	{
		private static DateTime _datum1;
		private static DateTime _datum2;
		private static DateTime _datum3;
		private static DateTime _datum4;
		private static Blog _blog;
		private static Comment _testComment1;
		private static Comment _testComment2;
		private static Comment _testComment3;
		private static Comment _testComment4;
		private static Post _testPost1;
		private static Post _testPost2;
		private static Post _testPost3;

		public Blog GetBlog()
		{
			return _blog;
		}

		public CreateTestEntries(Blog blog)
		{
			_datum1 = new DateTime(2014, 10, 1);
			_datum2 = new DateTime(2014, 10, 2);
			_datum3 = new DateTime(2014, 10, 3);
			_datum4 = new DateTime(2014, 10, 4);

			// Först skapas bloggar
			_testPost1 = new Post(_datum1, "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. ", "Lorem ipsum...");
			_testPost1.Tags.Add("startar, blogginlägg");
			_testPost2 = new Post(_datum2, "Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus.", "Nullam dictum...");
			_testPost2.Tags.Add("test, blogginlägg, dag två, kör");
			_testPost3 = new Post(_datum3, "Maecenas tempus, tellus eget condimentum rhoncus, sem quam semper libero, sit amet adipiscing sem neque sed ipsum. Nam quam nunc, blandit vel, luctus pulvinar, hendrerit id, lorem. Maecenas nec odio et ante tincidunt tempus. Donec vitae sapien ut libero venenatis faucibus. Nullam quis ante. Etiam sit amet orci eget eros faucibus tincidunt. Duis leo. Sed fringilla mauris sit amet nibh. Donec sodales sagittis magna. Sed consequat, leo eget bibendum sodales, augue velit cursus nunc...", "Maecenas tempus...");
			_testPost3.Tags.Add("test, kör");

			// Sen kommntarer
			_testComment1 = new Comment(_datum2, "Testkommentar. Massor med text för test. Jajjemen text för test. Eller test för text?", "Tant");
			_testComment2 = new Comment(_datum3, "Jaså ännu mer utfyllnadstext? Det kommenterar jag gärna. Kommentar kommentar.", "Bodil");
			_testComment3 = new Comment(_datum4, "Ho ho ho vad mycket utfyllnad. Texten svämmar över i sin obegriplighet. Jag kommenterar ändå.", "Tant Bodil");
			_testComment4 = new Comment(_datum4, "Jag kan bara inte låta bli att kommentera din nonsenstext. Kommenterar hela dagen. lång.", "Tant Bodil igen");

			_blog = blog;
			_blog.Posts.Add(_testPost1);
			_testPost1.Comments.Add(_testComment1);

			_blog.Posts.Add(_testPost2);
			_testPost2.Comments.Add(_testComment2);

			_blog.Posts.Add(_testPost3);
			_testPost3.Comments.Add(_testComment3);
			_testPost3.Comments.Add(_testComment4);
		}
	}
}
