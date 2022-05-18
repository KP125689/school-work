using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TheShapesProdigy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Shapes Prodigy!");


            string[] Lines = System.IO.File.ReadAllLines("C:/Users/patrw/Source/Repos/441101-2122-t2-theshapesprodigy-KP125689/TheShapesProdig/Shapes.csv");

           
            var nameShape = new List<string>();
            var Side1 = new List<string>();
            var Side2 = new List<string>();

            Random Question = new Random();
            int randomInt = Question.Next(1, 62); // generate random number from list
            for (int i = 0; i < randomInt; i++)
            {
                string[] Seperate = Lines[i].Split(",");
                // removes the commas from the CS so its easier to read from
                nameShape.Add(Seperate[0]);
                Side1.Add(Seperate[1]);
                Side2.Add(Seperate[2]);


            }

            for (int i = randomInt - 2; i < nameShape.Count; i++)
            {
                string[] Seperate = Lines[i].Split(",");

                Console.WriteLine(nameShape[i] + " " + Side1[i] + " " + Side2[i]);

            }
            Console.WriteLine("enter username: ");
            string userName = Console.ReadLine();


            Console.WriteLine("===================");
            Console.WriteLine("The Shape Quiz");
            Console.WriteLine("===================");

            int score = 0;
            int maxScore = 10;
            Console.WriteLine("Your score is " + score + "/" + maxScore);

            Console.WriteLine("press any key to continue...");
            
        }

        
    }
           
}
