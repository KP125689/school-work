using System;
using System.IO;
using System.Collections.Generic;

namespace L10._5_ConsoleShoppingBasket
{
    class Program
    {
        static void method1() // this method is to make the code more neat by removing it from the main code
        {
           
            Console.WriteLine("");
            Console.WriteLine("Your basket is below");
            Console.WriteLine("");

        }
        struct test 
        {
            //note to self: cant find any reason to use structs or enum 
        }



        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("Happy Days Games (Refactored).");
            Console.WriteLine("====================================");

            string filename = "categories.csv";
            string filename2 = "productCatalogue.csv";
            
            
            //this will split the categories file and display it as a list/ table
            string[] firstCategory = File.ReadAllLines(filename);
            for (int count= 0; count < firstCategory.Length; count++ )
            {
                Console.WriteLine(count + ". " + firstCategory[count]);
            }

        
            Console.WriteLine("choose an option between [0-3] inclusive");
            string choice1 = Console.ReadLine();
       

            string[] secondCategory = File.ReadAllLines(filename2);
            List<string> productName = new List<string>();
            
            
           
            // this will split the console shopping basket so each column can be used
            for (int count2 = 0; count2 < secondCategory.Length; count2++)
            {
                string[] splits = secondCategory[count2].Split(","); //splits each line by the comma
                
                try //using exception handling just incase the csv file has changed, it will catch is as an error and end the program
                {
                    if(splits[1] == firstCategory[int.Parse(choice1)])
                    {
                        
                        Console.WriteLine(secondCategory[count2]);
                        productName.Add(secondCategory[count2]);
                    }  
                }
                catch
                {
                    Console.WriteLine("an error has occured, the program will now terminate");
                    System.Environment.Exit(1);

                }
               
                    
            }


           
            List<string> basket = new List<string>();

            
            int productMax = productName.Count - 1;
            int count3;

            
            
            do
            { //user will choose a product to buy
                Console.WriteLine("choose a product from 0 to " + productMax + " inclusive");
                Console.WriteLine("or write a number that is GREATER THAN " + productMax + " to stop shopping");
                count3 = int.Parse(Console.ReadLine());
                if( count3 >= 0 && count3 <= productMax)
                {
                    basket.Add(productName[count3]);
                }

            }while (count3 >= 0 && count3 <= productMax);

 
            
            method1(); // call method here. much neater.


            
            //used to calculate the total price at the end
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
