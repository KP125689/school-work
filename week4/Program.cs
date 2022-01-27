using System;

namespace L4._7_BlockPrimePalindromeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime Palindrome Dice Game");
            // Your codes here

            int throws = 0;
            int score  = 0;
            int numPalindromes = 0;

            do
            {
                Random rnd = new Random();
                int randomNum = rnd.Next(0, 1000);
                Console.WriteLine("rolling dice...");
                Console.WriteLine("your number is: ");
                Console.WriteLine(randomNum.ToString("D3")); 
                string conv = Convert.ToString(randomNum);  
                char first = conv[0];
                char last = conv[conv.Length - 1];
                throws++;
               
                if (first == last){
                    score +=10;
                    numPalindromes++;
                    Console.WriteLine("this is a palindrome");
                    Console.WriteLine("would you like to roll to double your points? (y/n)");
                    string answer2 = Console.ReadLine();
                   
                    if(answer2 == "y")
                    {
                        randomNum = rnd.Next(0, 1000);
                        Console.WriteLine("your new number is: ");
                        Console.WriteLine(randomNum.ToString("D3"));
                        conv = Convert.ToString(randomNum);
                        first  =  conv[0];
                        last = conv[conv.Length - 1];
                        throws++;
                        
                        if(first == last)
                            {
                                score = score + score;
                                Console.WriteLine("congrats, your score is now: " + score);
                            }
                        else if(first != last)
                            {
                                score = 0;
                                Console.WriteLine("=========================================");
                                Console.WriteLine("it isnt a palindrome, your score is now 0");
                                Console.WriteLine("=========================================");

                            }
                          
                            
                    }
                    else
                    {
                        Console.WriteLine("rolling dice...");
                    }
                }
                else if (first != last)
                {
                    Console.WriteLine("this isnt a palindrome");
                }
            

            } while(throws <= 100);


            if(throws == 101)
            {
                Console.WriteLine("========================");
                Console.WriteLine("*******game over*******");
                Console.WriteLine("========================");
                Console.WriteLine("number of palindomres: " + numPalindromes);
                Console.WriteLine("number of throws: " + throws);
                Console.WriteLine("game score: " + score);
                Console.WriteLine("========================");


            }



        }
    }
}
