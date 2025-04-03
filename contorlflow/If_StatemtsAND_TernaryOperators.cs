using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contorlflow
{
    internal class If_StatemtsAND_TernaryOperators
    {
        public static void Run()
        {
            // ===================== Problem 1: Even or Odd Number ====================
            Console.WriteLine("Enter a number to check if it's even or odd:");
            int x = Convert.ToInt32(Console.ReadLine());
            string evenOdd = (x % 2 == 0) ? $"This number {x} is Even" : $"This number {x} is Odd";
            Console.WriteLine(evenOdd);

            // ===================== Problem 2: Age Checker ============================
            Console.WriteLine("\nEnter your age to check if you are allowed to enter the roller coaster:");
            int age = Convert.ToInt32(Console.ReadLine());
            string ageMessage = (age >= 18) ? $"You are allowed to enter the roller coaster (Your age: {age})" : $"You are not allowed to enter the roller coaster (Your age: {age})";
            Console.WriteLine(ageMessage);

            // ===================== Problem 3: Temperature Advice ===================== 
            Console.WriteLine("\nEnter the current temperature to get advice:");
            long temp = Convert.ToInt32(Console.ReadLine());
            string tempMessage = temp > 30 ? "It’s hot 🔥, stay cool!" :
                                 temp < 10 ? "It’s cold, wear a jacket! 🧥" :
                                 "It’s nice, you’re good 👍👍";
            Console.WriteLine(tempMessage);

            // ===================== Problem 4: Grade Calculator =======================
            Console.WriteLine("\nEnter your grade to receive feedback:");
            int grade = Convert.ToInt32(Console.ReadLine());
            string gradeMessage = (grade >= 90) ? "Your grade is A" :
                                  (grade >= 80) ? "Your grade is B" :
                                  (grade >= 70) ? "Your grade is C" : "Your grade is F";
            Console.WriteLine(gradeMessage);

            // ===================== Problem 5: Ternary Operator Example =================
            // Checking if the number is greater than 50
            Console.WriteLine("\nEnter a number to check if it passed (50 or above):");
            int num = Convert.ToInt32(Console.ReadLine());
            string passFail = (num >= 50) ? "Pass" : "Failed";
            Console.WriteLine($"Result: {passFail}");

            // ===================== Problem 6: Finding the Largest Number =================
            Console.WriteLine("\nEnter two numbers to find the largest:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            string largestNum = (num > num2) ? $"Number 1 ({num}) is the largest" : $"Number 2 ({num2}) is the largest";
            Console.WriteLine(largestNum);
        }
    }
}
