using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dometrain_C__Getting_started
{
    internal class CastingandParse
    {
        public static void Run()
        {
            // 📌 Casting in C#

            // 🔑 **Introduction**
            // Casting is the process of converting one data type into another.
            // There are two types of casting:
            // 1️⃣ **Implicit Casting (Automatic by C#)** ✅
            // 2️⃣ **Explicit Casting (Manual by Developer)** ⚠️

            // 📜 **Implicit Casting (Safe Conversions)**
            // - Happens automatically when converting from a smaller to a larger type.
            // - No data loss occurs.

            int myInt = 5;
            double myDouble = myInt; // ✅ Allowed: int → double

            Console.WriteLine("🔹 Implicit Cast");
            Console.WriteLine($"myInt = {myInt} --type--> {myInt.GetType()}");
            Console.WriteLine($"myDouble = {myDouble} --type--> {myDouble.GetType()}");

            // 📜 **Explicit Casting (Manual Conversions)**
            // - Happens when converting from a larger type to a smaller type.
            // - Requires explicit syntax: (type)
            // - Data loss may occur.

            myDouble = 5.5;
            myInt = (int)myDouble; // ⚠️ Manual conversion: double → int (loses decimal part)

            Console.WriteLine("\n🔸 Explicit Cast");
            Console.WriteLine($"myDouble = {myDouble} --type--> {myDouble.GetType()}");
            Console.WriteLine($"myInt = {myInt} --type--> {myInt.GetType()}");

            // 📜 **Casting Between Incompatible Types**
            // - Some types cannot be cast directly (e.g., string → int).
            // - Using `(type)` syntax will cause an error.
            // - We need methods like `Parse()` or `TryParse()`.

            // ❌ This will NOT compile:
            // string myString = "5";
            // myInt = (int)myString; // ❌ ERROR: Cannot convert 'string' to 'int'

            // ✅ Using `int.Parse()` to convert string → int
            string myString = "5";
            myInt = int.Parse(myString);

            Console.WriteLine("\n🔹 Using Parse() for Conversion");
            Console.WriteLine($"myString = {myString} --type--> {myString.GetType()}");
            Console.WriteLine($"myInt = {myInt} --type--> {myInt.GetType()}");

            // ✅ Using `double.Parse()` to convert string → double
            myString = "5.5";
            myDouble = double.Parse(myString);

            Console.WriteLine("\n🔹 Using Parse() for Double Conversion");
            Console.WriteLine($"myString = {myString} --type--> {myString.GetType()}");
            Console.WriteLine($"myDouble = {myDouble} --type--> {myDouble.GetType()}");
        }
    }
}
