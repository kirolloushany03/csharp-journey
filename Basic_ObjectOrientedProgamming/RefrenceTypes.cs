using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Basic_ObjectOrientedProgamming
{
    internal class RefrenceTypes
    {
        public static void Run()
        {
            //Intro_Oop.RunTheFile();


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
            //but why the console we don't have to create to it a new object?


            // so here is the objects is a refrence type not like the other data types which is
            // value type like {int, float, double, bool} 
            // except the coolections also liek the object is refrence type

            //so what happened in these blocks
            OurClass object1 = new OurClass(); // object 1 new refrence to OurClass
            OurClass object2 = new OurClass(); //object 2 new diffrenct refrence to OurClass
            OurClass object3 = object1; // object 3 points to object 1
                                        // so it has the same refrence to OurClass of object 1

            Console.WriteLine($"this for object 1 refrence {RuntimeHelpers.GetHashCode(object1)}");
            Console.WriteLine($"this for object 2 refrence {RuntimeHelpers.GetHashCode(object2)}");
            Console.WriteLine($"this for object 3 refrence {RuntimeHelpers.GetHashCode(object3)}");

            //another exmaples onthe collections
            List<int> mylist1 = new List<int> { 1, 2, 3 };
            List<int> mylist2 = new List<int> { 1, 2, 3 };

            Console.WriteLine($"list1 = {RuntimeHelpers.GetHashCode(mylist1)}");
            Console.WriteLine($"list2 = {RuntimeHelpers.GetHashCode(mylist2)}");
            Console.WriteLine(mylist1 == mylist2); //so here the ==  is check the refrence and will be false

            //so by refernce types  are pointers you can change the original thing
            // we can say here the list so you refrence to the list it self but if the value type you can not
            // change in  it self

            // so this one will change th elist it self that you will use in it and will add them to the list 
            // and this because we make refrence type to the list
            void ChangeRefrence(List<string> words)
            {

                words.Add("from");
                words.Add("dev");
                words.Add("leader");
            }


            List<string> mywords = new List<string> { "hello", "world" };
            Console.WriteLine("mywords before ChangeRefrence");
            Console.WriteLine($"[{string.Join(",", mywords)}]");

            ChangeRefrence(mywords);

            Console.WriteLine("mywords after the ChangeRefrence");
            Console.WriteLine($"[{string.Join(",", mywords)}]");

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

        //{1️} - Swap List Elements (Pass by Reference)
        /*void SwapFirstAndLast( List<int> numbers)
        {
            if (numbers.Count >= 2)
            {
                int temp;
                temp = numbers[0];
                numbers[0] = numbers[numbers.Count - 1];
                numbers[numbers.Count - 1] = temp;
            }
            else
            {
                Console.WriteLine("the list is two small and less than 2 numbers");
            }
        }

        void FullListPrint(List<int> FullList)
        {
            Console.WriteLine($"[{string.Join(",", FullList)}]");
        }*/

        //{1.1}testing it
        /*
        List<int> nums = new List<int> { 1, 2, 3, 4, 5 };
        FullListPrint(nums);
        SwapFirstAndLast( nums);
        FullListPrint(nums);*/

    }
}
