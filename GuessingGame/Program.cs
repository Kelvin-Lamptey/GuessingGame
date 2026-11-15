using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                ShowMenu();
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    PlayGame();
                }
                else if (choice == "2")
                {
                    running = false;
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("Invalid option, please try again.");
                }

                Console.WriteLine();
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("--- Number Guessing Game ---");
            Console.WriteLine("1. Play Game");
            Console.WriteLine("2. Quit");
            Console.Write("Choose an option: ");
        }

        static void PlayGame()
        {
            Random rand = new Random();
            int secretNumber = rand.Next(1, 101);
            int maxTries = 5;
            int tries = 0;
            bool won = false;

            Console.WriteLine("I have picked a number between 1 and 100.");
            Console.WriteLine("You have " + maxTries + " tries to guess it.");

            while (tries < maxTries && !won)
            {
                Console.Write("Enter your guess: ");
                int guess = Convert.ToInt32(Console.ReadLine());
                tries++;

                won = CheckGuess(guess, secretNumber, tries, maxTries);
            }

            if (!won)
            {
                Console.WriteLine("You ran out of tries! The number was " + secretNumber);
            }
        }

        static bool CheckGuess(int guess, int secretNumber, int tries, int maxTries)
        {
            if (guess == secretNumber)
            {
                Console.WriteLine("Correct! You guessed it in " + tries + " tries.");
                return true;
            }
            else if (guess < secretNumber)
            {
                Console.WriteLine("Too low! Tries left: " + (maxTries - tries));
                return false;
            }
            else
            {
                Console.WriteLine("Too high! Tries left: " + (maxTries - tries));
                return false;
            }
        }
    }
}
