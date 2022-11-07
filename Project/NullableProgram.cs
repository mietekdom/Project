using System;
using System.Collections.Generic;
using System.Text;
using Project.Enum;

namespace Project
{
    public class NullableProgram
    {
        public static void Test()
        {
            string[] cars = { "Volvo", "Mazda", "Audi" };

            try
            {
                System.Console.WriteLine("Inside try - 1");
                cars[4] = "Tesla";
                Console.WriteLine("Inside try - 2");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Handing Index Out Of Range Exception exception");
            }
            catch (Exception e)
            {
                Console.WriteLine("Handling any exception");
            }
            finally
            {
                Console.WriteLine("Cleanup");
            }
            Console.WriteLine("Outside of Try catch");
        }

        public static void Testy()
        {
            Gender gender = Gender.Male;

        }
    }
}
