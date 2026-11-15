using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[0];
            bool running = true;

            while (running)
            {
                ShowMenu();
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    scores = EnterScores();
                }
                else if (choice == "2")
                {
                    ShowReport(scores);
                }
                else if (choice == "3")
                {
                    running = false;
                    Console.WriteLine("Exiting Grade Tracker...");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Try again.");
                }

                Console.WriteLine();
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("--- Student Grade Tracker ---");
            Console.WriteLine("1. Enter Student Scores");
            Console.WriteLine("2. View Grades and Statistics");
            Console.WriteLine("3. Quit");
            Console.Write("Select an option: ");
        }

        static int[] EnterScores()
        {
            Console.Write("How many students? ");
            int count = Convert.ToInt32(Console.ReadLine());
            int[] scores = new int[count];

            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter score for student " + (i + 1) + ": ");
                scores[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Scores saved.");
            return scores;
        }

        static void ShowReport(int[] scores)
        {
            if (scores.Length == 0)
            {
                Console.WriteLine("No scores entered yet. Please enter scores first.");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("--- Student Grades ---");
            for (int i = 0; i < scores.Length; i++)
            {
                string grade = GetGrade(scores[i]);
                Console.WriteLine("Student " + (i + 1) + ": Score = " + scores[i] + ", Grade = " + grade);
            }

            double avg = GetAverage(scores);
            int highest = GetHighest(scores);
            int lowest = GetLowest(scores);

            Console.WriteLine();
            Console.WriteLine("--- Class Summary ---");
            Console.WriteLine("Average Score: " + avg);
            Console.WriteLine("Highest Score: " + highest);
            Console.WriteLine("Lowest Score: " + lowest);
        }

        static double GetAverage(int[] scores)
        {
            int sum = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                sum = sum + scores[i];
            }
            return (double)sum / scores.Length;
        }

        static int GetHighest(int[] scores)
        {
            int highest = scores[0];
            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] > highest)
                {
                    highest = scores[i];
                }
            }
            return highest;
        }

        static int GetLowest(int[] scores)
        {
            int lowest = scores[0];
            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] < lowest)
                {
                    lowest = scores[i];
                }
            }
            return lowest;
        }

        static string GetGrade(int score)
        {
            if (score >= 70)
            {
                return "A";
            }
            else if (score >= 60)
            {
                return "B";
            }
            else if (score >= 50)
            {
                return "C";
            }
            else if (score >= 40)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}
