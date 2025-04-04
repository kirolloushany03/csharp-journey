using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class ForEach
    {
        public static void run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<int> numbers = new() { 10, 25, -5, 0, 15, -2, 30 };

            Dictionary<string, int> myDictionary = new()
        {
            { "koko", 3 },
            { "soso", 5 },
            { "fofo", 2 }
        };

            // ✅ Print all values in the list
            Console.WriteLine("📋 List of numbers:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\n📋 Dictionary entries:");
            // ✅ Print dictionary key-value pairs
            foreach (var pair in myDictionary)
            {
                Console.WriteLine($"Name: {pair.Key}, Age: {pair.Value}");
            }

            Console.WriteLine("\n🔁 Using break in foreach:");
            foreach (var pair in myDictionary)
            {
                if (pair.Value == 2)
                    break;

                Console.WriteLine($"Breaking loop at: {pair.Key}, Age: {pair.Value}");
            }

            Console.WriteLine("\n🔁 Using continue in foreach:");
            foreach (var pair in myDictionary)
            {
                if (pair.Value == 2)
                    continue;

                Console.WriteLine($"Continued: {pair.Key}, Age: {pair.Value}");
            }
        }
    }
}
