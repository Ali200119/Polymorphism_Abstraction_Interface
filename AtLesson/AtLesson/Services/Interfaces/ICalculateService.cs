using System;
namespace AtLesson.Services.Interfaces
{
	public interface ICalculateService
	{
		void SumNumbers(int num1, int num2);
		int GetSumNumbersFromArray(int[] array);
	}
}