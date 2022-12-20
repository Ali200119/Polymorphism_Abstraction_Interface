using System;
using AtLesson.Services.Interfaces;

namespace AtLesson.Services
{
	public class Person: Test, IPerson
	{
		public Person()
		{
		}

        public void GetName()
        {
            Console.WriteLine("Hello World!");
        }
    }
}

