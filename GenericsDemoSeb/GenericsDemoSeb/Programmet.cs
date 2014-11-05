using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemoSeb
{
	public class Programmet
	{
		public Programmet()
		{
			string one = "Hej";
			string two = "Morgon";
			int siffra = 5;
			int nySiffra = 9;

			string result = GetLargestObject<string>("hej", "elof", "kaffe", "gott", one, two);
			Console.WriteLine("Den största var: " + result);

			int resultNum = GetLargerObject<int>(siffra, nySiffra);
			Console.WriteLine("Den största var: " + resultNum);

			//string[] texter = new string[] { "hej", "elof", "kaffe", "gott" };
			//SkrivUtArray(texter);
			//SkrivUtArray(2, "hej", "elof", "kaffe", "gott", one, two);
			//PrintMany("hej", "elof", "kaffe", "gott", one, two);
			//PrintMany(texter);

			//Swap(ref one, ref two);
			//PrintTypes(one, siffra);
			

			var data = CreateNewType<Person>();

			Person person = new Person();
			//NormalGenericMethod(person);
			List<int> lista = new List<int>();
			Information<Person> info = new Information<Person>(person);

			Console.ReadLine();
		}

		public T GetLargestObject<T>(params T[] array) where T : IComparable<T>
		{
			T result = default(T);

			foreach (T item in array)
			{
				if (item.CompareTo(result) > 0)
				{
					result = item;
				}
			}

			return result;
		}

		public T GetLargerObject<T>(T one, T two) where T : IComparable<T>
		{
			int compareValue = one.CompareTo(two);
			Console.WriteLine("ICompareTo: " + compareValue);

			if (compareValue > 0)
			{
				return one;
			}

			return two;
		}

		public T CreateNewType<T>() where T : new() // class, struct - kolla upp
		{
			return new T();
		}

		public void PrintMany<T>(params T[] objects)
		{	
			Console.WriteLine("Print many körs");
			foreach (T item in objects)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine("----------------");
		}

		public void PrintTypes<T1, T2>(T1 one, T2 two)
		{
			Console.WriteLine(typeof(T1).ToString() + " - " + one);
			Console.WriteLine(typeof(T2).ToString() + " - " + two);
		}

		public void Swap<T>(ref T one, ref T two)
		{
			T temp = one;
			one = two;
			two = temp;
		}

		public T NormalGenericMethod<T>(T objektet) 
			where T : IInformation, new()
		{
			T nyttObj = new T();

			return objektet;
		}




		public void SkrivUtArray(int number, params string[] texts)
		{
			Console.WriteLine("SkritUtArray körs");
			for (int i = 0; i < number; i++)
			{
				foreach (string text in texts)
				{
					Console.WriteLine(text);
				}
			}

			Console.WriteLine("-----------------------");
		}
	}
}
