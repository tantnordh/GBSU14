using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOchDelegater
{
	public delegate void MinMetodBeskrivning(int siffra);
	public delegate bool ComparerDelegate(int number);

	public delegate string NameGettingDelegate(int age, string socialSecNumber);

	public delegate void Aktion(int number);

	public delegate void MyMethodDesc(int a, int b);
	public delegate void MyMethodDesc2(string name, int number);

	public delegate void EventDelegate(object sender, string eventArgs);
}
