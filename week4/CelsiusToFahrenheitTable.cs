using System;

namespace L4._3_CelsiusToFahrenheitTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Celsius to Fahrenheit Conversion Table");
            
            // All your codes goes here
            Console.WriteLine("| {0, -10} | {1,5:C5} |", "Celcius", "farenheit");
            Console.WriteLine("");
            for (int c = 1; c <= 10; c++)
            {
                int farenheit = (c * 9) / 5 + 32;
                Console.WriteLine("| {0, -10} | {1,9} | ", c, farenheit);
            }

            


        }
    }
}
