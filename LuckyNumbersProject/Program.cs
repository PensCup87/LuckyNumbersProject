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
            Console.WriteLine("Welcome to the Camp Crystal Lake Casino Night!");
            Console.WriteLine("\nI'm Jason, and this is a number guesing game that might return a prize.");
            Console.WriteLine("\nI'll need two numbers to start.");
            Console.WriteLine("\nLet's begin, choose a number, that will start a number range");
            int initialNumber = int.Parse(Console.ReadLine().Trim());
            Console.WriteLine();
            Console.WriteLine("Jason thanks you, and can you give me another number, to end the number range?");
            int secondNumber = int.Parse(Console.ReadLine().Trim());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Now that our range is set, select 6 lives, oop my mistake");
            Console.WriteLine("\nI meant select 6 numbers within the rage " + initialNumber + " and " + secondNumber);

            int userGuess = 0;

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

            int[] luckyGuesses = new int[6];
            for(int i = 0; i <= 5; i++)
            {
                if(userGuess < initialNumber || userGuess > secondNumber)
                {
                    Console.WriteLine("Enter a number within your range.");
                }
                Console.WriteLine("Give your lucky digit: ");
                userGuess = int.Parse(Console.ReadLine());
            }

            



        }
    }
}
