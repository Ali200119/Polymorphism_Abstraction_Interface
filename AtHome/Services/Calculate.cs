using System;
using AtHome.Services.Interfaces;

namespace AtHome.Services
{
	public class Calculate: ICalculate
	{
        void ICalculate.Calculate(double num1, double num2, string operation)
        {
            switch (operation)
            {
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;

                case "-":
                    Console.WriteLine(num1 - num2);
                    break;

                case "*":
                    Console.WriteLine(num1 * num2);
                    break;

                case "/":
                    if (num2 != 0)
                    {
                        Console.WriteLine(num1 / num2);
                        break;
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You can't devide by zero");
                        Console.ResetColor();
                        break;
                    }
            }
        }
    }
}

