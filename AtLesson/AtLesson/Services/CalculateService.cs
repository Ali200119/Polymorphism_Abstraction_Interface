using System;
using AtLesson.Services.Interfaces;

namespace AtLesson.Services
{
    public class CalculateService : ICalculateService, ICommonService
    {
        public string FullData()
        {
            throw new NotImplementedException();
        }

        public int GetSumNumbersFromArray(int[] array)
        {
            int sum = 0;

            foreach (var number in array)
            {
                sum += number;
            }

            return sum;
        }

        public void SumNumbers(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);
        }
    }
}