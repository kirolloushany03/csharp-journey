using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_ObjectOrientedProgamming
{
    internal class Fields_and_properties
    {
        public static void Run()
        {
            // 🤔 What are fields? 
            // --> Variables declared directly in a class

            /* Example using fields directly (not recommended due to lack of encapsulation)
            Person2 kiro = new Person2();
            kiro._email = "soso@hotgmail.com"; // Not allowed because _email is private
            Console.WriteLine(kiro._email);    // Not allowed because _email is private
            */

            /* Using method to access private field
            Person3 name3 = new Person3();
            Console.WriteLine(name3.GetName()); // Accessing private field via method
            */

            // Using properties to access and manipulate private fields 🛡️
            Person4 kirowithproperty = new Person4();

            Console.WriteLine(kirowithproperty.Name);   // First property variation
            Console.WriteLine(kirowithproperty.Name2);  // Second property variation
            Console.WriteLine(kirowithproperty.Name3);  // Third property variation (auto-property)

            kirowithproperty.Name3 = "hellow form the new Name 3 seeting and the name now that kiro is the best";
            Console.WriteLine(kirowithproperty.Name3);

            Console.WriteLine("setting the name .. ");
            kirowithproperty.Mutablename = "kiro is hero"; // Fourth property variation
            Console.WriteLine(kirowithproperty.Mutablename);
        }
        // 👤 Class with method but unused field
        class Person
        {
            private string _name;

            public void Me()
            {
                this._name = "kiro"; // Sets the name but doesn't expose it
            }
        }

        // 🧪 Class with private field initialized, but no accessors
        class Person2
        {
            private string _email = "kk@gmail.com"; // This is a field, no access method
        }

        // 📬 Class with private field and a method to read it
        class Person3
        {
            private string _name = "kiro"; // (field initialized)

            public string GetName() // ✅ Method to expose the private field
            {
                return _name;
            }
        }

        // 🛡️ What are properties? 
        // --> Members that provide controlled access (flexible mechanism) 
        // to read, write or compute the value of a private field.
        // ✅ They provide protection and can include logic

        class Person4
        {
            private string _name = "kiro";

            // 🔁 First variation: Full property with logic (great for complex access control)
            public string Name
            {
                get
                {
                    return _name;
                }
            }

            // 🪞 Second variation: Expression-bodied read-only property
            public string Name2 => _name;

            // ⚙️ Third variation: Auto-implemented read/write property with initializer
            // 📝 Note: This doesn't access _name, it's a separate property
            public string Name3 { get; set; } = "kirohero";

            // 🔄 Fourth variation: Full read/write property wrapping a field
            public string Mutablename
            {
                get { return _name; }
                set { _name = value; }
            }
        }
    }
}
