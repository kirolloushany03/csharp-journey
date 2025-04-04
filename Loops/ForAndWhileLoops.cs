using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class ForAndWhileLoops
    {
        public static void run()
        {
            Console.WriteLine("=== Sum of Positive Numbers ===\n");

            // 💡 Option 1: Using while loop
            int sumWhile = 0;
            int numberWhile;

            Console.WriteLine("-- Using while loop --");
            Console.Write("Enter a number: ");
            numberWhile = Convert.ToInt32(Console.ReadLine());

            while (numberWhile > 0)
            {
                sumWhile += numberWhile;

                Console.Write("Enter a number: ");
                numberWhile = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"[While Loop] Sum of positive numbers = {sumWhile}");

            Console.WriteLine("\n------------------------\n");

            // 💡 Option 2: Using infinite for loop
            int sumFor = 0;

            Console.WriteLine("-- Using for loop --");

            for (; ; )
            {
                Console.Write("Enter a number: ");
                int numberFor = Convert.ToInt32(Console.ReadLine());

                if (numberFor <= 0)
                    break;

                sumFor += numberFor;
            }

            Console.WriteLine($"[For Loop] Sum of positive numbers = {sumFor}");
        }
    }
}
