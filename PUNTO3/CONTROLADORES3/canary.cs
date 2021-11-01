using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORES3
{
	class canary : observer
	{

		public canary (string name) : base(name)
		{

		}

		public void See(canary canary, cat cat)
		{
			cat.registerObserver(cat, this);
			Console.WriteLine($"{canary.name} Just see { cat.name}");
		}

	}
}
