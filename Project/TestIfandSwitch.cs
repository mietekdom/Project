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

            int YearOfBirth;
            if (int.TryParse(userYearOfBirth, out YearOfBirth))
            {
                int age = DateTime.Now.Year - YearOfBirth;

                Console.WriteLine("you are " + age);
            }
            else
            {
                Console.WriteLine("incorrect value");
            }

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

        public static void SwitchTest()
        {
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("It is Monday today");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("it is Friday today");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("It is weeknd");
                    break;
                default:
                    Console.WriteLine("In the meddle of the week");
                    break;
            }
        }
    }
}
