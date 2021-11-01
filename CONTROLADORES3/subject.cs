using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORES3
{
	class subject
	{

		public observer[] observers = new observer[5];
		public string name;

		public subject(string name)
		{
			this.name = name;
		}

		public virtual int registerObserver(subject subject, observer observer)
		{
			for (int i = 0; i < 5; i++)
			{
				if(subject.observers[i] == null)
				{
					subject.observers[i] = observer;
					return 0;
				}
			}
			return registerObserver(subject, observer);
		}

		public void notifyObserver(subject subject)
		{
			for (int i = 0; i < 5; i++)
			{
				if (subject.observers[i] != null)
				{
					subject.observers[i].notify(subject.observers[i], subject);
				}
			}
		}

	}
}
