using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_ObjectOrientedProgamming
{
    internal class Constructor
    {
        // 👷‍♂️ Constructors — Usage --> are used to initialize a class
        // We have two kinds of constructors:
        // 🔹 Implicit Constructor — this is the default one, even if you can't see it
        //      Like in a normal class, this constructor is created behind the scenes.
        //      In C#, it assigns default values to the fields.
        //      For example, if you declare an integer like: int age; 
        //      and print it without initializing, you'll get 0.
        //      This happens because the default constructor automatically assigns a default value.
        //      So when I did this test by declaring "int age;" and printed it, it showed 0.
        // ✅ That means the default constructor sets default values for uninitialized variables.

        // ❓ So why do we have a default constructor??? 
        // ➕ To avoid errors and bugs caused by uninitialized fields!
        public static void Main_Run()
        {
            // 🔄 Testing object creation and constructor behavior:
            ImplicitConstructor test = new ImplicitConstructor();
            test.test1();

            ConstructorwithParameter test2 = new ConstructorwithParameter("msa2 alfol");

            MultipleConstructors instanceTest = new(); // Goes to the default constructor
            MultipleConstructors instanceTest2 = new(22, "this go directly to the Parameterized constructor");

            // 🧩 The main reason for using constructors is to initialize the class members properly

            ourcollectionWords words = new ourcollectionWords(); // here the list is initialized
            words.Add("kiro");       //}
            words.Add("spider-man"); //} --> now all of these just adding into the list   
            words.Add("Batman");     //}

            words.print();  // 🖨️ print what’s in the list

            // 🧺 collectionWords2: same as previous, but this one passes the list of words directly to the constructor
            ourcollectionWords2 words2 = new ourcollectionWords2(["kiro", "play", "spiderman", "remastered edition"]);
            words2.print();

            // ⚙️ Because the constructor is static:
            // It will print only once, regardless of how many instances you create
            // This is because a static constructor is related to the class itself, not the instances
            var t1 = new staticconstructor();
            var t2 = new staticconstructor();

            // 🔒 This class uses a private constructor that's hidden from outside
            OurClassWithHiddenConstructor t3 = new OurClassWithHiddenConstructor(22);
        }

        // 🔹 Implicit Constructor Example
        // 👉 Demonstrates default values assigned by the compiler
        class ImplicitConstructor
        {
            int age;

            public void test1()
            {
                Console.WriteLine($"so this is the value of 'age' that was only declared --> {age}");
            }
        }


        // 🔹 Explicit Constructor (Parameterless)
        // 👉 Constructor you write yourself without any parameters
        class ExplicitConstructor
        {
            public ExplicitConstructor()
            {
                Console.WriteLine("explicit constructor here");
            }
        }


        // 🔹 Constructor with Parameters
        // 👉 Demonstrates passing arguments into the constructor
        class ConstructorwithParameter
        {
            public ConstructorwithParameter(string message)
            {
                Console.WriteLine(message);
            }
        }


        // 🔹 Multiple Constructors (Overloading)
        // 👉 Combines default constructor and parameterized constructor with chaining
        class MultipleConstructors
        {
            public MultipleConstructors()
                : this(1, "this default number and go to the Parameterized constructor") // calls parameterized one
            {
                Console.WriteLine("and this message that is in the default constructor");
            }

            public MultipleConstructors(int number, string message)
            {
                Console.WriteLine($"so this is the number {number} and this is the message: {message}");
            }
        }


        // 🔹 Collection Initialization using Default Constructor
        // 👉 Initializes the list inside the constructor
        class ourcollectionWords
        {
            private List<string> _strings; // actually, you can initialize the list here
                                           // but it's safest to initialize it in the constructor

            public ourcollectionWords()
            {
                _strings = new List<string>();
            }

            public void Add(string word)
            {
                _strings.Add(word);
            }

            public void print()
            {
                foreach (var word in _strings) // we can use 'var', but the most
                                               // important thing is to use 'var' with initialized variables
                {
                    Console.WriteLine(word);
                }
            }
        }


        // 🔹 Collection Initialization using Parameterized Constructor
        // 👉 Accepts a list of strings and populates the internal list
        class ourcollectionWords2
        {
            private List<string> _strings;

            public ourcollectionWords2(List<string> words)
            {
                _strings = new List<string>();

                foreach (var word in words)
                {
                    _strings.Add(word);
                }
            }

            public void print()
            {
                foreach (var word in _strings)
                {
                    Console.WriteLine(word);
                }
            }
        }


        // 🔹 Static Constructor Example
        // 👉 Runs only once per class, not per instance
        class staticconstructor
        {
            static staticconstructor()
            {
                Console.WriteLine("static constructor from staticconstructor class");
            }
        }


        // 🔹 Private Constructor (Hidden Constructor)
        // 👉 Uses a private constructor that can only be called from within the class
        class OurClassWithHiddenConstructor
        {
            public OurClassWithHiddenConstructor(int value)
                : this() // calls the private constructor
            {
                Console.WriteLine($"THIS IS THE PUBLIC CONSTRUCTOR — we received: {value}");
            }

            private OurClassWithHiddenConstructor()
            {
                Console.WriteLine("⚠️ no one can call this — it's the private one from outside directly!");
            }
        }
    }
}
