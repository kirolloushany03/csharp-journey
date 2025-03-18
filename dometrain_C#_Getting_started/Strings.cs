using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dometrain_C__Getting_started
{
    internal class Strings
    {
        public static void RunMain()
        {
            // 🌍 Enable UTF-8 Encoding to support emojis
            Console.OutputEncoding = System.Text.Encoding.UTF8; //this for enabling emojies

            // 📌 Strings in C#

            // 🖨️ Printing a simple string
            Console.WriteLine("hello");

            // 📝 Using escape characters to include quotes inside a string
            Console.WriteLine("This is the code: \"Console.WriteLine(\"hello\");\"");

            // 🔹 Declaring string variables
            string mystring;
            string my_string;
            string Mystring;

            // ✍️ Assigning a value to a string variable
            mystring = "koko";
            Console.WriteLine(mystring);

            // 🔗 Initializing and concatenating string variables
            string firstName = "Kirollous";
            string Nickname = "koko";
            string fullName = firstName + " His NickName is " + Nickname;
            Console.WriteLine(fullName);

            // ⌨️ Taking user input from the console
            Console.WriteLine("Write your full name:");
            my_string = Console.ReadLine();  // Reading input from the console

            // 🔢 Getting the length of a string using `.Length`
            Console.WriteLine($"This is your full name that you entered: \"{my_string}\" " +
                $"and the length of your full name is \"{my_string.Length}\"");

            // 🔍 Accessing a specific character using indexing
            Console.WriteLine(my_string[0]);

            // 🔤 Declaring a single character
            char a = 'a';

        }
    }
}
