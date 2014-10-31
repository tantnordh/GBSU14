using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
	public class Calculator
	{
		public int Add(string expression)
		{
			if (!expression.Any())
				return 0;

			List<string> delimiters = new List<string> { "\n", "," };
			if (expression.StartsWith("//", StringComparison.Ordinal))
			{
				string delimiter = expression.Substring(2);
				delimiter = delimiter.Split(new string[] { "\n" }, StringSplitOptions.None)[0];
				delimiters.Add(delimiter);
				expression = expression.Substring(expression.IndexOf("\n") + 1);
			}

			String[] stringValues = expression.Split(delimiters.ToArray(), StringSplitOptions.None);
			var intValues = stringValues.Select(int.Parse);
			intValues = intValues.Where(i => i <= 1000);

			return intValues.Sum();
		}
	}
}
