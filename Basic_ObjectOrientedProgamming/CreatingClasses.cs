using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_ObjectOrientedProgamming
{
    internal class CreatingClasses
    {
        // ------------------------------
        // Fields and Properties
        // ------------------------------

        // What is a field? << A field is a variable that is declared directly in a class.

        /// <summary>
        /// Example 1: Declaring a field inside a class
        /// </summary>
        class Person
        {
            private string _name;  // {1} Declaring a field in a class

            /*public void Whome()
            {
                this._name = "john"; // 'this' keyword selects the field from this class
            }*/
        }
        /// <summary>
        /// Example 2: Initializing the field inside the class
        /// </summary>
        class Person2
        {
            // Private access modifier specifies that something is accessible only within the class
            private string _name = "koko";
        }
        public static void Run()
        {

            // ------------------------------
            // Working with Getter and Setter
            // ------------------------------

            /*Person3 p3 = new Person3();

            Console.WriteLine(p3._name); // This will give an error:
                                         // "'Person3._name' is inaccessible due to its protection level" */

            /*Console.WriteLine($"Enter new name (current name: {p3.GetName()})");

            string newName = Console.ReadLine();
            p3.SetName(newName);
            Console.WriteLine($"So this is the new name --> {p3.GetName()}");*/

            // ------------------------------
            // Using Properties (Modern Approach)
            // ------------------------------

            Person4 kokowithproperty = new Person4();

            Console.WriteLine($"So this from name --> {kokowithproperty.name}");
            Console.WriteLine($"So this from Name2 --> {kokowithproperty.Name2}");
            //Console.WriteLine($"So this from Name3 --> {kokowithproperty.Name3}");

            Console.WriteLine("Setting the name...");
            kokowithproperty.MutableName = "soso with koko";
            Console.WriteLine($"Name after setting is --> {kokowithproperty.MutableName}");
            Console.WriteLine($"So this from Name3 --> {kokowithproperty.Name3}");


        }

        // ------------------------------
        // Example 3: Getter and Setter Using Methods (Older Approach)
        // ------------------------------
        class Person3
        {
            private string _name = "koko";

            public string GetName()
            {
                return _name;
            }

            public void SetName(string name)
            {
                this._name = name;
            }
        }

        // ------------------------------
        // Defining the Person4 Class with Properties
        // ------------------------------
        class Person4
        {
            private string _name = "koko";

            // (1) Using a full property with a getter
            public string name
            {
                // This method is useful if we need to do more than one process in the getter
                get
                {
                    return _name;
                }
            } // Instead of all of this, we can use the next approach

            // (2) Expression-bodied property (shortcut for a simple getter)
            public string Name2 => _name;

            // (3) Read-only property with an initial value
            public string Name3 { get; } = "koko :)";
            // The only way to access Name3 is directly through its property.
            // But the other properties can access _name inside the class.

            // (4) Mutable property (Getter and Setter)
            public string MutableName
            {
                get { return _name; }
                set { _name = value; }
            }
        }
    }
}
