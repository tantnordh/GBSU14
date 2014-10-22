using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
	public static class CreateRandomRow
	{
		private static Random _random;
		private static List<int> _numbers;

		public static Row NewRow()
		{
			_numbers = new List<int>(5);
			int number = 0;
			for (int i = 0; i < 5; i++)
			{
				int uniqueNumber = 0;
				while (uniqueNumber == 0 || _numbers.Contains(uniqueNumber))
				{
					uniqueNumber = number.RandomIntOneToTwenty();
				}

				_numbers.Add(uniqueNumber);
			}

			Row row = new Row(_numbers);
			row.Numbers = row.Numbers.OrderBy(n => n).ToList();

			return row;
			
		}

		public static int RandomIntOneToTwenty(this int number)
		{
			if (_random == null)
			{
				_random = new Random();
			}

			return _random.Next(1, 21);
		}
	}
}
