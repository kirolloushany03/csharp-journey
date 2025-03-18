using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dometrain_C__Getting_started
{
    internal class Integers
    {
        public static void RunMain()
        {
            // 🌍 Enable UTF-8 Encoding to support emojis
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // 🔢 Integers in C#

            // ℹ️ Integers (int) accept only whole numbers
            // 🏗️ An integer in C# is 32 bits (4 bytes)
            // 📌 Range of an integer: -2,147,483,648 to 2,147,483,647 (FYI)

            // 🔹 Declaring integer variables
            int myInt;
            int my_int;
            int Myint;

            // ✍️ Assigning a value to an integer variable
            myInt = 22;

            // 🔄 Reassigning a value to an integer variable
            myInt = 21;

            // ➕➖✖️➗ Performing basic arithmetic operations
            int sum = 5 + 10;
            int difference = 5 - 10;
            int product = 5 * 10;

            // ⚠️ Integer division (Note: 5 / 10 gives 0 because both are integers)
            int quotient = 5 / 10;

            // 🖨️ Printing results
            Console.WriteLine($"5 + 10 = {sum}");
            Console.WriteLine($"5 - 10 = {difference}");
            Console.WriteLine($"5 * 10 = {product}");
            Console.WriteLine($"5 / 10 = {quotient} (Integer division result)");

            // 💡 If you want a precise division result, use float or double
            float floatQuotient = 5f / 10f;
            Console.WriteLine($"5 / 10 as float = {floatQuotient}");

        }
    }
}
