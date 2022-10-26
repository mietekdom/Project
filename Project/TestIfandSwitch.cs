using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    public class TestIfandSwitch
    {
        public static void TestIfYear()
        {
            Console.WriteLine("Year of birth?");

            string userYearOfBirth = Console.ReadLine();

            int YearOfBirth = int.Parse(userYearOfBirth);

            bool isUserOver18 = DateTime.Now.Year - YearOfBirth > 18;

            if (isUserOver18)
            {
                Console.WriteLine("you are over 18");
            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
            {
                Console.WriteLine("Today is Wednesday");
            }
            else
            {
                Console.WriteLine("Access denied");
            }
            Console.WriteLine("bye!");
        }
    }
}
