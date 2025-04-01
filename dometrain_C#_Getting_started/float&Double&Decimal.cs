using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dometrain_C__Getting_started
{
    internal class float_Double_Decimal
    {
        public static void Run()
        {
            // 📌 Floats vs Doubles vs Decimals in C#
            // Floating point numbers are numbers with a decimal point.

            // 🏷️ Float: 32 bits (4 bytes)
            //    - Range: 1.5 × 10⁻⁴⁵ to 3.4 × 10³⁸

            // 🏷️ Double: 64 bits (8 bytes)
            //    - Range: 5.0 × 10⁻³²⁴ to 1.7 × 10³⁰⁸

            // 🏷️ Decimal: 128 bits (16 bytes)
            //    - Range: From ±1.0 × 10⁻²⁸ to ±7.9 × 10²⁸
            //    - Precision: 28-29 decimal digits
            //    - Use case: Most precise, especially for financial and monetary calculations

            // 🧮 Performing Arithmetic with Floats
            float sum = 5.5f + 10.5f;
            float difference = 5.5f - 10.5f;
            float product = 5.5f * 10.5f;
            float quotient = 5.5f / 10.5f;

            // 🖨️ Printing float results with type
            Console.WriteLine($"5.5 + 10.5 = {sum} --type--> {sum.GetType()}");
            Console.WriteLine($"5.5 - 10.5 = {difference} --type--> {difference.GetType()}");
            Console.WriteLine($"5.5 * 10.5 = {product} --type--> {product.GetType()}");
            Console.WriteLine($"5.5 / 10.5 = {quotient} --type--> {quotient.GetType()}");

            Console.WriteLine("\n=================double===================\n");

            // 🧮 Performing Arithmetic with Doubles
            // When you write 5.5, it is implicitly treated as a double
            double sum2 = 5.5f + 10.5f; // float values are automatically converted to double
            double difference2 = 5.5 - 10.5; // No need for 'f' with double
            double product2 = 5.5 * 10.5;
            double quotient2 = 5.5 / 10.5;

            // 🖨️ Printing double results with type
            Console.WriteLine($"5.5 + 10.5 = {sum2} --type--> {sum2.GetType()}");
            Console.WriteLine($"5.5 - 10.5 = {difference2} --type--> {difference2.GetType()}");
            Console.WriteLine($"5.5 * 10.5 = {product2} --type--> {product2.GetType()}");
            Console.WriteLine($"5.5 / 10.5 = {quotient2} --type--> {quotient2.GetType()}");

            Console.WriteLine("\n=================Decimal===================\n");

            // 🧮 Performing Arithmetic with Decimals
            // Decimal values cannot be implicitly converted from double
            // Decimal uses decimal floating point representation, more precise for financial calculations

            // Explicit conversion from double/float to decimal
            decimal sum3 = (decimal)5.5d + (decimal)5.5f; // Using both double 'd' and float 'f'
            decimal difference3 = 5.5m - 10.5m;  // Using 'm' to define decimals
            decimal product3 = 5.5m * 10.5m;
            decimal quotient3 = 5.5m / 10.5m;

            // 🖨️ Printing decimal results with type
            Console.WriteLine($"5.5 + 10.5 = {sum3} --type--> {sum3.GetType()}");
            Console.WriteLine($"5.5 - 10.5 = {difference3} --type--> {difference3.GetType()}");
            Console.WriteLine($"5.5 * 10.5 = {product3} --type--> {product3.GetType()}");
            Console.WriteLine($"5.5 / 10.5 = {quotient3} --type--> {quotient3.GetType()}");

        }
    }
}
