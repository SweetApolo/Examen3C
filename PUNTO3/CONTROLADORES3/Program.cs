using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORES3
{
	class Program
	{
		static void Main(string[] args)
		{
			//Creamos los animales
			cat hopkins = new cat("Hopkins");
			dog alfred = new dog("Alfred");
			canary tweety = new canary("Tweety");
			

			alfred.Smell(alfred, hopkins);
			tweety.See(tweety, hopkins);

			hopkins.Speak(hopkins);
		}
	}
}
