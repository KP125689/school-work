using System;
using System.IO;

namespace L7._5_ConsoleHeartsMiningGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // initialise program variables
            char spade = '\u2660';
            char heart = '\u2665'; 
            char playAgain = 'N';

            // change text encoding from ASCII to UTF8, to enable spade and hearts symboll display
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            //Enter your codes here
            Console.WriteLine("would you like to play this game? (y/n)");
            string letsPlay = Console.ReadLine();

            do
            {
    
                int heartsFound = 0;
                int score = 0;
                int totalHearts = 0;
                
                int choice = 0;  
                bool i = true;
                // user chooses difficulty
                while (i == true)
                {
                    Console.WriteLine("select difficulty level [1-5] inclusive");
                    int userOption = int.Parse(Console.ReadLine());
                    switch(userOption)
                    {
                        case 1:
                            Console.WriteLine("Good choice");
                            totalHearts = 15;
                            i = false;
                            break;
                        case 2:
                            Console.WriteLine("Good choice");
                            totalHearts = 12;
                            i = false;
                            break;
                        case 3:
                            Console.WriteLine("Good choice");
                            totalHearts = 9;
                            i = false;
                            break;
                        case 4:
                            Console.WriteLine("Good choice");
                            totalHearts = 6;
                            i = false;
                            break;
                        case 5:
                            Console.WriteLine("Good choice");
                            totalHearts = 3;
                            i = false;
                            break;
                        default:
                            Console.WriteLine("please put a valid choice");
                            break;

                    }
                    userOption = choice;
                }
                // 3d array for characters
                char[,,] letters = 
                {
                    {
                        {'A' , spade},
                        {'B' , spade},
                        {'C' , spade},
                        {'D' , spade},
                        {'E' , spade},
                        {'F' , spade}
                    },
                    {
                        {'G' , spade},
                        {'H' , spade},
                        {'I' , spade},
                        {'J' , spade},
                        {'K' , spade},
                        {'L' , spade}
                    },
                    {
                        {'M' , spade},
                        {'N' , spade},
                        {'O' , spade},
                        {'P' , spade},
                        {'Q' , spade},
                        {'R' , spade}
                    },
                    {
                        {'S' , spade},
                        {'T' , spade},
                        {'U' , spade},
                        {'V' , spade},
                        {'W' , spade},
                        {'X' , spade}
                    },

                };

            
                // creates table/grid of letters
                for(int rows = 0; rows != 4; rows++)
                {
                    Console.WriteLine("");
                    for(int columns = 0; columns != 6; columns++)
                    {
                        Console.Write(" | " + letters[rows,columns,0] + " | ");                
                    }    
                }

                //user stats
                Console.WriteLine("hearts found: " + heartsFound + " out  of " + totalHearts);
                Console.WriteLine("SCORE: " + score);

                //places a random heart under a letter
                for(int userOpt = 0; userOpt != choice; userOpt++)
                {
                Random rnd = new Random();
                var randomNum = rnd.Next(0, letters.Length);
                randomNum = letters[letters.Length,letters.Length,heart];
                }
                
               
                // user input
                int count = 0; //counts amount of times user inputs letter
                do
                {
                Console.WriteLine("please choose a letter from the grid");
                char userInput;
                userInput = Convert.ToChar(Console.ReadLine());
                count++;
                //binary search algo

                int minVal = 0;
                int maxVal = letters.Length - 1;
                var key = userInput;
                while(minVal <= maxVal)
                {
                    int mid = (minVal + maxVal) / 2;
                    if (key == mid)
                    {
                        letters[0,0, letters.Length] = spade;

                    }
                    else if (key < mid)
                    {
                        maxVal = mid - 1;
                    }
                    else
                    {
                        minVal = mid - 1;
                    }    
                }
                

                }while(heartsFound != totalHearts);

                if(heartsFound == totalHearts)
                {
                    using(StreamWriter writer = new StreamWriter("gameStatistics.txt"))
                    {
                        score = heartsFound / count;
                        Console.WriteLine("your score is: " + score);
                        Console.WriteLine("total hearts found: " + totalHearts);
                    }
                }
            }
            while(letsPlay == "y");

            if( letsPlay == "n")
            {
                Console.WriteLine("okay bye");
            }
            
            
            

          // unfinished 

             



        }
    }
}
