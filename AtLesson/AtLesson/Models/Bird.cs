using System;
namespace AtLesson.Models
{
	public class Bird: Animal
	{
		public string Type { get; set; }

        public override void Eating()
        {
            Console.WriteLine("Bird eating");
        }

        public override void Sound()
        {
            Console.WriteLine("Bird sound");
        }
    }
}