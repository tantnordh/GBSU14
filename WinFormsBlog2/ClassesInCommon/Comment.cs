using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassesInCommon
{
	public class Comment
	{
		public int Id { get; private set; }
		public DateTime Date { get; private set; }
		public string Name { get; private set; }
		public string Text { get; private set; }

		public Comment(int id, DateTime date, string name, string text)
		{
			Id = id;
			Date = date;
			Name = name;
			Text = text;
		}
	}
}
