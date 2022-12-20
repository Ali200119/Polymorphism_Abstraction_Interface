using System;
namespace AtLesson.Models
{
	public abstract class Animal
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Color { get; set; }

        public virtual void Sound()
        {
            Console.WriteLine("Animal sound");
        }

        public abstract void Eating();
    }
}

