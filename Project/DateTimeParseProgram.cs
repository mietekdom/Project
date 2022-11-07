using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    public class DateTimeParseProgram
    {
        public static void DateTimeCalculator()
        {
            var today = DateTime.Now; //day.month.year 
            var dateYear = DateTime.Now.Year; //year

            Console.WriteLine(today);

            Console.WriteLine("Write your day of birth");
            int dateOfBirthString = int.Parse(Console.ReadLine());

            Console.WriteLine("Write your month of birth");
            int monthOfBirthString = int.Parse(Console.ReadLine());

            Console.WriteLine("Write your year of birth");
            int yearOfBirthString = int.Parse(Console.ReadLine());

            DateTime dateOfBirth = new DateTime(yearOfBirthString, monthOfBirthString, dateOfBirthString);

            TimeSpan timeSpan = today - dateOfBirth;

            Console.WriteLine("Calculate days: " + timeSpan.TotalDays);

            
        }
    }
}
