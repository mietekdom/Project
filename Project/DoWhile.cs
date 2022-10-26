using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    public class DoWhile
    {
        public static void DoWhileTest()
        {
            Console.WriteLine("To exit, type 'x'");

            string userInput;

            do
            {
                userInput = Console.ReadLine();
                Console.WriteLine($"Echo: {userInput}");
            } while (userInput != "x");
        }
    }
}
