using System;
namespace AtLesson.Models
{
	public class Shark: Animal
	{
		public int ToothCount { get; set; }

        public override void Eating()
        {
            Console.WriteLine("Shark eating");
        }

        public override void Sound()
        {
            Console.WriteLine("Shark sound");
        }
    }
}

