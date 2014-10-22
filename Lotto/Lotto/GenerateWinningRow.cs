using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
	public static class GenerateWinningRow
	{
		public static List<int> WinningRow()
		{
			Random random = new Random();
			List<int> numbers = new List<int>();

			for (int i = 0; i < 5; i++)
			{
				numbers.Add(random.Next(1, 21));
			}

			return numbers;
		}
	}
}
