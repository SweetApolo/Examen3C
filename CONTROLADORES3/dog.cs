using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORES3
{
	class dog : observer
	{
		public dog(string name) : base(name)
		{

		}

		public void Smell(dog dog, cat cat)
		{
			cat.registerObserver(cat, this);
			Console.WriteLine($"{dog.name} Just smelled {cat.name}");
		}
	}
}
