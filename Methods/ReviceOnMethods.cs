using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class ReviceOnMethods
    {
        // ==========================
        // 🎯 Revision on Methods in C#
        // - No arguments, no return
        // - With arguments, no return
        // - With arguments and return type
        // ==========================
        public static void run()
        {
            Console.OutputEncoding = Encoding.UTF8; //just to enable emojies
            PrintWelcomeMessage();

            PrintSum(10, 15);

            int result = Multiply(2, 5);
            Console.WriteLine($"✖️ The result of multiplication is: {result}");
        }

        // ✅ 1. Method without arguments and no return type
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("👋 Welcome to the method revision!");
        }

        // ✅ 2. Method with arguments, no return type
        static void PrintSum(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine($"➕ The sum of {x} and {y} is {sum}");
        }

        // ✅ 3. Method with arguments and return type
        static int Multiply(int x, int y)
        {
            return x * y;
        }

    }
}
