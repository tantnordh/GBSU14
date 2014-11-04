using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemoSeb
{
	public class Information<T> where T : new()
	{
		private T info;

		public Information(T info)
		{
			this.info = info;
		}

		public T GetInfo()
		{
			return info;
		}
	}
}
