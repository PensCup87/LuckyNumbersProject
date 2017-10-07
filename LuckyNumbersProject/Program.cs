using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbersProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string rePlay;
            do
            {
                Console.WriteLine("Welcome to the Camp Crystal Lake Casino Night!");
                Console.WriteLine("\nI'm Jason, and this is a number guesing game that might return a prize.");
                Console.WriteLine("\nI'll need a number for the starting point and ending point.");
                Console.WriteLine("\nLet's begin, choose a number, that will start a number range");
                int initialNumber = int.Parse(Console.ReadLine().Trim());
                Console.WriteLine("Jason thanks you, and can you give me another number, to end the number range?");
                int secondNumber = int.Parse(Console.ReadLine().Trim());

                Console.WriteLine("Now that our range is set, select 6 lives, oop my mistake");
                Console.WriteLine("\nI meant select 6 numbers within the rage " + initialNumber + " and " + secondNumber);


                //int guessCount = 0;
                //do
                //{
                //    Console.WriteLine("Now you can test your life, or luck that is");
                //    Console.WriteLine("\nCampers keep my busy and I mix up my words.");
                //    Console.WriteLine("Please give me your fist lucky number:");
                //    firstLuckyNumber = int.Parse(Console.ReadLine().Trim());
                //    guessCount = 1;

                //    Console.WriteLine();
                //    Console.WriteLine("A wise choice, for a sucker.  Please guess another number: ");
                //    secondLuckyNumber = int.Parse(Console.ReadLine().Trim());
                //    guessCount = 2;

                //    Console.WriteLine();
                //    Console.WriteLine("We need a third digit: ");
                //    thirdLuckyNumber = int.Parse(Console.ReadLine().Trim());
                //    guessCount = 3;

                //    Console.WriteLine();
                //    Console.WriteLine("Your almost there, but need a fourth limb: ");
                //    fourthLuckyNmber = int.Parse(Console.ReadLine().Trim());
                //    guessCount = 4;

                //    Console.WriteLine();
                //    Console.WriteLine("I'm loosing track and that could help you, but we need another puncture: ");
                //    fifthLuckyNumber = int.Parse(Console.ReadLine().Trim());
                //    guessCount = 5;

                //    Console.WriteLine();
                //    Console.WriteLine("Ah, you've lived to give a Final Digit: ");
                //    sixthLuckyNumber = int.Parse(Console.ReadLine().Trim());
                //    guessCount = 6;
                //}
                //while (guessCount > 6);

                //PART 1 REVISED, Sorry Daniel!

                //int userGuess = 0;
                int[] luckyGuesses = new int[6];

                for (int j = 0; j < luckyGuesses.Length; j++)
                {
                    Console.WriteLine("Give your lucky digit: ");
                    luckyGuesses[j] = int.Parse(Console.ReadLine());

                    //while(userGuess < initialNumber && userGuess > secondNumber)

                }




                //Generating a Random Number 
                //Then putting randomNumber into an Array
                int randomDigit = 0;
                int[] beerGuy = new int[6];
                Random rand = new Random();

                for (int i = 0; i < beerGuy.Length; i++)
                {
                    int randomNumber = rand.Next(initialNumber, secondNumber) + 1;
                    beerGuy[i] = randomNumber;
                    Console.WriteLine("Lucky Number: " + beerGuy[i]);

                }


                //PART 3

                //Compares Array Values for a Match
                //Start with a Loop so the check happens more than once
                int totalMatches = 0;
                int equalArrays = 0;
                for (int j = 0; j < luckyGuesses.Length; j++)
                {
                    for (int i = 0; i < beerGuy.Length; i++)
                    {
                        if (luckyGuesses[j] == beerGuy[i])
                        {
                            totalMatches = equalArrays++;
                            
                        }
                    }
                }


                //Comparing Human Numbers to Computer NUmbers

                foreach(int digit in luckyGuesses)
                {
                    if(beerGuy.Contains(digit))
                    {
                        totalMatches++;
                    }
                }
                Console.WriteLine("You have " + totalMatches + " matches");

                int possibleJackPot = 20000;
                int prizeCalc = 0;

                





                //PART 4
                
                Console.WriteLine("Would you like to play again?");
                rePlay = Console.ReadLine().ToLower().Trim();






                ////user Winnings







            }
            while (rePlay == "yes");
            if(rePlay == "no")
            {
                Console.WriteLine("Thanks for playing");
            }
        }
    }
}
