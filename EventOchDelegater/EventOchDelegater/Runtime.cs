using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOchDelegater
{	
	public class Runtime
	{
		public Action<int> MinMetodVariabel { get; private set; }
		public Aktion MinMetodVariabelTwo;

		private Func<int, bool> minFunctionsVariabel;
		private MinMetodBeskrivning minAndraMetodVariabel;
		private ComparerDelegate comparer;

		private MyMethodDesc printSum;
		private MyMethodDesc2 printKingsName;

		public Runtime()
		{
			Console.WriteLine("-Programmet körs-");

			printSum = PrintSum;
			printSum += PrintSumPlusOne;
			printSum += delegate(int a, int b) { Console.WriteLine("Anonymous addition: " + (a + b + 2)); };
			
			printSum(1, 2);
			Console.WriteLine();

			printKingsName = PrintKingsName;
			printKingsName("Henry", 8);

			//minAndraMetodVariabel += PrintSiffra;
			//minAndraMetodVariabel += PrintNumber;
			//minAndraMetodVariabel -= PrintSiffra;
			//minAndraMetodVariabel += siffra => Console.WriteLine("Nu gör vi saker anonymt: " + siffra);
			//minAndraMetodVariabel += delegate(int number)
			//{
			//	Console.WriteLine(number + " är siffran i anonyma delegatmetoden.");
			//};
			
			//MinMetodVariabel = PrintNumber;
			//minFunctionsVariabel = IsEven;
			//comparer = IsEven;

			//bool even = minFunctionsVariabel(14);
			//Console.WriteLine(even);

			//minAndraMetodVariabel(13);
		}

		private void PrintNumber(int number)
		{
			Console.WriteLine("Siffran är: " + number);
		}
		private void PrintSiffra(int siffra)
		{
			Console.WriteLine(siffra + " är värdet av talet.");
		}
		private bool IsEven(int number)
		{
			if (number % 2 == 0)
				return true;

			return false;
		}

		private void PrintSum(int a, int b)
		{
			Console.WriteLine("PrintSum: " + (a + b));
		}
		private void PrintSumPlusOne(int a, int b)
		{
			Console.WriteLine("PrintSumPlusOne: " + (a + b + 1));
		}

		private void PrintKingsName(string name, int number)
		{
			string suffix;
			if (number == 1)
			{
				suffix = "st";
			}
			else if (number == 2)
			{
				suffix = "nd";
			}
			else
			{
				suffix = "th";
			}
			Console.WriteLine(name + " the " + number + suffix);
		}
	}
}
