using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    public class Array
    {
        public static void ArrayTest()
        {
            string[] cars = { "Volvo", "Honda", "Mazda"};
            Console.WriteLine(cars[2]);

            int arrayLenght = cars.Length;
            Console.WriteLine(arrayLenght);

            cars[2] = "Tesla";
            Console.WriteLine(cars[2]);

            Console.WriteLine(cars[cars.Length - 1]);

            int i = 0;
            while (i < cars.Length)
            {
                Console.WriteLine(cars[i]);
                if (cars[i] == "Honda")
                {
                    Console.WriteLine("bye");
                    break;
                }
                i++;
            }

            Console.WriteLine("***");

            for (int j = 0; j < cars.Length; j++)
            {
                Console.WriteLine(cars[i]);
                if (cars[j] == "Honda")
                {
                    Console.WriteLine("bye");
                    break;
                }
                i++;
            }


            Console.WriteLine("***");

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
