using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    public class ConsoleApplication
    {
        public static void ConsolApp()
        {
            Console.WriteLine("Input value");

            int inputValue = int.Parse(Console.ReadLine());

            int sum = 0;
            int? maxValue = null;

            while(inputValue != 0)
            {
                if (maxValue == null || inputValue > maxValue)
                {
                    maxValue = inputValue;
                }

                sum += inputValue;
                inputValue = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"sum of number is {sum}");
            Console.WriteLine($" max value is {maxValue}");
            
        }
    }
}
