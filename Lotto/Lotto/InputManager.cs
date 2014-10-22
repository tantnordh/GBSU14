using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
	public static class InputManager
	{
		public static int GetInput(this int number, string instruction, int startNumber, int endNumber)
		{
			instruction.PrintInstruction();
			int choice;
			while (!int.TryParse(Console.ReadLine(), out choice) || choice < startNumber || choice > endNumber)
			{
				Console.WriteLine("Ange ett heltal " + startNumber + "-" + endNumber + ": ");
			}

			return choice;
		}

		public static int GetInput(this int number, string instruction, string exceptionMessage, int startNumber)
		{
			instruction.PrintInstruction();
			int choice;
			while (!int.TryParse(Console.ReadLine(), out choice) || choice < startNumber)
			{
				Console.WriteLine(exceptionMessage);
			}

			return choice;
		}

		public static List<int> GetRowNumberInput(this Row rowToEdit, string instruction, string exceptionMessage)
		{
			instruction.PrintInstruction();
			List<string> newNumbersStrList;
			bool onlyIntegers;

			newNumbersStrList = GetInputForRowEdit();
			onlyIntegers = OnlyIntegersOneToTwenty(newNumbersStrList);

			while (newNumbersStrList.Count != 5 || !onlyIntegers)
			{
				Console.WriteLine(exceptionMessage);
				newNumbersStrList = GetInputForRowEdit();
			}

			List<int> newNumbers = new List<int>();
			for (int i = 0; i < newNumbersStrList.Count; i++)
			{
				newNumbers.Add(int.Parse(newNumbersStrList[i]));
			}

			return newNumbers;
		}

		private static bool OnlyIntegersOneToTwenty(List<string> newNumbersStrList)
		{
			bool onlyIntegersOneToTwenty = true;
			for (int i = 0; i < newNumbersStrList.Count; i++)
			{
				int number = -1;
				onlyIntegersOneToTwenty = int.TryParse(newNumbersStrList[i], out number);
				
				if (number < 1 || number > 20)
					onlyIntegersOneToTwenty = false;

				if (!onlyIntegersOneToTwenty)
					break;
			}
			return onlyIntegersOneToTwenty;
		}

		private static List<string> GetInputForRowEdit()
		{
			List<string> newNumbersStrList = new List<string>(Console.ReadLine().Split(',', ' '));
			List<string> numbersStrListWithoutDuplicates = new List<string>();

			numbersStrListWithoutDuplicates = newNumbersStrList.GroupBy(n => n).Select(g => g.First()).ToList();

			return numbersStrListWithoutDuplicates;
		}
	}
}
