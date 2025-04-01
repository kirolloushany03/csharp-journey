using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dometrain_C__Getting_started
{
    internal class Boolean__Logical_operators
    {
        public static void Run()
        {
            // 📌 Boolean and Logical Operators in C#

            // 🔑 **Boolean in C#**
            // A boolean holds a value of either true or false.
            // In C#, a boolean occupies 1 byte (8 bits).

            // 📜 Declaring and Assigning Values
            bool myBool; // Declaring a boolean variable
            myBool = false; // Assigning false
            myBool = true; // Assigning true

            // 📜 Initializing (Declaring and Assigning Value)
            bool myBool2 = true; // Declaring and assigning true

            // 📜 Re-assigning a value
            myBool2 = false; // Changing the value to false

            // 🧠 Logical Operators:
            // Logical operators perform logical operations on boolean values.

            // 🧩 **AND (&&) Operator:**
            // Returns true if both conditions are true.
            Console.WriteLine("\n========= And && =========\n");

            bool TrueandFalse = true && false;  // False
            bool TrueandTrue = true && true;    // True
            bool FalseandFalse = false && false; // False

            // 🖨️ Printing results
            Console.WriteLine($"True&&False = {TrueandFalse} --type--> {TrueandFalse.GetType()}");
            Console.WriteLine($"True&&True = {TrueandTrue} --type--> {TrueandTrue.GetType()}");
            Console.WriteLine($"False&&False = {FalseandFalse} --type--> {FalseandFalse.GetType()}");

            // 🧩 **OR (||) Operator:**
            // Returns true if at least one condition is true.
            Console.WriteLine("\n========= Or || =========\n");

            bool TrueorFalse = true || false;  // True
            bool TrueorTrue = true || true;    // True
            bool FalseorFalse = false || false; // False

            // 🖨️ Printing results
            Console.WriteLine($"True||False = {TrueorFalse} --type--> {TrueorFalse.GetType()}");
            Console.WriteLine($"True||True = {TrueorTrue} --type--> {TrueorTrue.GetType()}");
            Console.WriteLine($"False||False = {FalseorFalse} --type--> {FalseorFalse.GetType()}");

            // 🧩 **NOT (!) Operator:**
            // Inverts the boolean value (true becomes false and vice versa).
            Console.WriteLine("\n========= Not ! =========\n");

            bool notTrue = !true;   // False
            bool notFalse = !false; // True

            // 🖨️ Printing results
            Console.WriteLine($"!true = {notTrue} --type--> {notTrue.GetType()}");
            Console.WriteLine($"!false = {notFalse} --type--> {notFalse.GetType()}");

        }
    }
}
