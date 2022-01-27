using System;
using System.IO;
using System.Collections.Generic;

namespace L7._4_ConsoleShoppingBasket
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("Happy Days Games.");
            Console.WriteLine("====================================");

            //Enter your codes here
            string filename = "categories.csv";
            string filename2 = "productCatalogue.csv";
            string line;
            string line2;
            

            string[] firstCategory = File.ReadAllLines(filename);
            for (int count= 0; count < firstCategory.Length; count++ )
            {
                Console.WriteLine(count + ". " + firstCategory[count]);
            }

            Console.WriteLine("choose an option between [0-3] inclusive");
            string choice1 = Console.ReadLine();

            string[] secondCategory = File.ReadAllLines(filename2);
            List<string> productName = new List<string>();
            for ( int count2 = 0; count2 < secondCategory.Length; count2++)
            {
                string[] splits = secondCategory[count2].Split(",");
                
                if(splits[1] == firstCategory[int.Parse(choice1)])
                {
                    Console.WriteLine(secondCategory[count2]);
                    productName.Add(secondCategory[count2]);
                }
                    
            }

            List<string> basket = new List<string>();

            int productMax = productName.Count - 1;
            int count3;

            do
            {
                Console.WriteLine("choose a product from 0 to " + productMax + " inclusive");
                count3 = int.Parse(Console.ReadLine());
                if( count3 >= 0 && count3 <= productMax)
                {
                    basket.Add(productName[count3]);
                }

            }while (count3 >= 0 && count3 <= productMax);


            Console.WriteLine("");
            Console.WriteLine("Your basket is below");
            Console.WriteLine("");

            double[] userPrice = new double[productName.Count];
            string[] userGame = new string[productName.Count];
            double finalPrice = 0;

            for (int count4 = 0 ; count4 < basket.Count; count4++)
            {
                string[] splits2 = productName[count4].Split(',');
                Console.WriteLine(splits2[0] + " " + splits2[2]);
                finalPrice += double.Parse(splits2[2]);

            }
            Console.WriteLine("your total is: " + finalPrice);
            




        }
    }
}


 