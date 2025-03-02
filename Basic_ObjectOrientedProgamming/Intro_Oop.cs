using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_ObjectOrientedProgamming
{
    internal sealed  class Intro_Oop
    {
        public static void RunTheFile()
        {
            //to create class just put class (مش محتاجة حاجة يعني 😂)



            /*public class Program
            {
                class OurClass
                {
                    public void sayhellow()
                    {
                        Console.WriteLine("hwllow");
                    }   
                }
                public static void Main()
                {
                    OurClass ourporoject = new OurClass();

                    ourporoject.sayhellow();
                }
            }*/

            //here if you just put the class before the top level statments will give you 
            //this error {top-level statements must precede namespace and type declarations
            //and the top-level statemts means > statemts don’t need to be inside a class or method.
            //and this reaplces the need for the main method
            //but still also we can make the main method as i did at the first of the program 


            //creating object from the class by using the new keybword
            OurClass ourpoject = new OurClass();

            //creating object from class by short-form method
            OurClass ourpoject2 = new();

            OurSecoundClass ourclass = new();

            ourclass.RunMethod();
            int sum = ourclass.SumTwoNumbers(2, 3);
            Console.WriteLine($"sp the sum of the two numbers is >> {sum}");

            //also here as example of the classes and objects is in?
            // console class
            Console.WriteLine("this this WriteLine method on the Console class");
            //but why the console we dont have to create to it a new object?
        }

            // so here we put he classes at the end below the top-level statements and this
            // because pass this error "top-level statements must precede namespace and type declarations."
            // as we dont use the main method right now
        public class OurClass
        {

        }

        public class OurSecoundClass
        {
            public void RunMethod()
            {
                Console.WriteLine("hey from the runmethod");
            }

            public int SumTwoNumbers(int x, int y)
            {
                return x + y;
            }
        }
    }
}

