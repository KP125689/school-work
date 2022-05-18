using SimonsShapes;
using System;
using System.IO;


namespace The_Cost_of_Art
{
    public class Program : Shape
    {
        static void Main(string[] args)
        {

            Console.WriteLine(ConstStrings.SELECT_ACTION);
            Console.WriteLine(ConstStrings.CREATE_PAINTING);
            Console.WriteLine(ConstStrings.LOAD_PAINTING);
            Console.WriteLine("3. Exit the Program");
            Console.WriteLine(ConstStrings.VALUE_MIN_MAX, 1, 3);
            string userChoice = Console.ReadLine();
            int threeChoices = Convert.ToInt32(userChoice); // cant handle what isnt a number,, need to fix

                  
            switch (threeChoices)
            {
                case 1:
                    Console.WriteLine("creating a new painting...");
                    Shape newShape = new Shape();
                    newShape.newShape();
                    break;
                case 2:
                    Console.WriteLine("loading painting...");
                    ValidatePainting painting = new ValidatePainting();
                    painting.LoadPaintings();
                    // meed to create edit shape method
                    break;
                case 3:
                    Console.WriteLine(ConstStrings.EXIT);
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine(ConstStrings.NOT_IN_RANGE, userChoice, 1, 3 + " or " + userChoice + ConstStrings.NOT_WHOLE_NUMBER);
                    break;
            }
        }
        
           
        
    }
}
