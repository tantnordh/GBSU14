using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
	public class Row
	{
		public List<int> Numbers { get; set; }
		public int RowNumber { get; set; }

		public Row(List<int> numbers)
		{
			Numbers = numbers.OrderBy(n => n).ToList();
		}
	}
}
