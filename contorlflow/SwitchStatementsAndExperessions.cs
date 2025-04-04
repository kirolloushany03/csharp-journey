using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contorlflow
{
    internal class SwitchStatementsAndExperessions
    {
        public static void run()
        {
            // ================== Problem 1: Get Day Name by Number ==================
            for (int i = 0; i < 3; i++) // Reduced iterations for simplicity
            {
                Console.Write("\nEnter a number (1-7) for the day: ");
                int num = Convert.ToInt32(Console.ReadLine());

                string day = num switch
                {
                    1 => "Sunday",
                    2 => "Monday",
                    3 => "Tuesday",
                    4 => "Wednesday",
                    5 => "Thursday",
                    6 => "Friday",
                    7 => "Saturday",
                    _ => "Invalid input! Please enter a number between 1 and 7."
                };

                Console.WriteLine($"Day: {day}");
            }

            // ================== Problem 2: Grade Evaluation Using Switch Expression ==================
            for (int i = 0; i < 3; i++) // Reduced iterations for simplicity
            {
                Console.Write("\nEnter your grade (A, B, C, D): ");
                string grade = Console.ReadLine().Trim().ToUpper(); // Using Uppercase to standardize input

                string result = grade switch
                {
                    "A" => "Excellent 🎉",
                    "B" => "Good 👍",
                    "C" => "Not bad 🙂",
                    "D" => "Try Again ❌",
                    _ => "Invalid grade! Please enter A, B, C, or D."
                };

                Console.WriteLine($"Result: {result}");
            }
        }
    }
}
