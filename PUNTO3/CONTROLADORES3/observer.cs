using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORES3
{
	class observer
	{

		public string name;
		public observer(string name)
		{
			this.name = name;
		}

		public void notify(observer observer, subject subject)
		{
			Console.WriteLine($"{observer.name}  Just heard {subject.name}");
		}


	}
}
