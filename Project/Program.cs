using System;

namespace Project
{
    class Program
    {
        /// <summary>
        /// stringi and other items 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string text1 = "some value string";
            string text2 = "aaaa";
            string text3 = "bbbbb";

            string tekst = text1 + text2 + text3;

            int a = 7;
            double b = 3.45;

            string aaa = tekst + " " + a.ToString() + " " + b.ToString();



            Console.WriteLine(aaa);
        }
    }
}
