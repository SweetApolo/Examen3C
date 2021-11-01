using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORES3
{
	class cat : subject
	{
		public cat(string name) : base(name)
		{

		}

		public void Speak(cat cat)
		{
			Console.WriteLine($"My name is: { cat.name}, Miau");
			notifyObserver(cat);
		}
	}
}
