using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    public class GenderEnum
    {
        public static void EnumGender()
        {
            Console.WriteLine("What is your gender? 1 - male, 2 - female");

            string userInput = Console.ReadLine();

            Gender userGender = (Gender)Enum.Parse(typeof(Gender), userInput);

            if (userGender == Gender.Male)
            {
                Console.WriteLine("only women are allowed");
            }
            else
            {
                Console.WriteLine("allowed");
            }
        }
    }
}
