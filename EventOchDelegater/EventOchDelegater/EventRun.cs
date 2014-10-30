using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOchDelegater
{
	public class EventRun
	{
		public event Action MyEvent;
		public event Action<int> NumberEvent;
		public event EventDelegate EventWithArgs;

		public EventRun()
		{
			Console.WriteLine("- Test av event -");
		}

		public void SkrivSaker()
		{
			Console.WriteLine("Text på skärmen.");

			if (MyEvent != null)
			{
				MyEvent();
			}

			NumberEvent(5);
			EventWithArgs(this, "5 använde vi.");
		}
	}
}
