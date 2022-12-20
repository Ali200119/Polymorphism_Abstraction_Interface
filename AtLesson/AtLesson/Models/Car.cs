using System;
namespace AtLesson.Models
{
	public sealed class Car
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public void Test()
		{
			Console.WriteLine("Sealed class");
		}
	}
}