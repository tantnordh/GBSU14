using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOchDelegater
{
	class Program
	{
		static void Main(string[] args)
		{
			//var testLista = new List<int>();
			//testLista.Where(IsEven);

			//Runtime program = new Runtime();
			//program.MinMetodVariabel(25);

			//EventRun program = new EventRun();
			//program.MyEvent += delegate()
			//{
			//	Console.WriteLine("Anonymt svar på eventet.");
			//};
			//program.MyEvent += OnEventStarted;
			//program.NumberEvent += OnNumberEvent;
			//program.EventWithArgs += program_EventWithArgs;
			
			//program.SkrivSaker();

			EventRunTwo program = new EventRunTwo();
			program.KingsNamingEvent += OnKingsNamingEvent;
			program.PrintThings();

			Console.ReadLine();
		}

		private static void OnKingsNamingEvent(string name, int number)
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

		private static void program_EventWithArgs(object sender, string eventArgs)
		{
			EventRun run = sender as EventRun;

			Console.WriteLine(eventArgs + " - " + run);
		}

		private static void OnNumberEvent(int number)
		{
			Console.WriteLine(number + " är siffran från eventet.");
		}

		private static void OnEventStarted()
		{
			Console.WriteLine("Eventet körs.");
		}

		private static void NyMetod(int heltal)
		{
			Console.WriteLine("Heltal skrivs ut: " + heltal);
		}
		public static bool IsEven(int number)
		{
			return number % 2 == 0;
		}
	}
}
