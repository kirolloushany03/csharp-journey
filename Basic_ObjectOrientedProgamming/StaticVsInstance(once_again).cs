using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_ObjectOrientedProgamming
{
    internal class StaticVsInstance_once_again_
    {
        // 🔹 static
        /*
            1- We can say that a static class must only have static members.
               ❌ You can't add instance members (like fields or methods) inside a static class.

            2- You can think of it like a function: it's great to apply the DRY concept 
               (Don't Repeat Yourself) when you need reusable logic.

            3- You can't create an instance from a static class like you do with normal classes.

            4- 🧠 How it works with memory?

                - In normal classes, memory is only used when you create an object.
                  For example, if the class has one field like: "int age = 22;",
                  then when you write: people p = new people(); → only then
                  does the object take up memory for that "age" field.

                - But in static classes, memory is allocated when the class is first used —
                  no need to create any object. The class itself (with all static members)
                  is stored once in memory and shared across the application.
         */


        // 🔸 instance
        /*
         * This is the normal class.
         * You create an instance from the class (blueprint), and only then it gets allocated in memory.
         * 
         * Also, you can have static members inside an instance class ✅
         *
         * ❓ Question: What happens in memory when we have both instance and static members
         * in the same instance class?
         * 
         * 🏗️ When you write a class with both instance and static members,
         *     the compiler keeps them separate internally.
         *
         * ⏱️ As soon as you use the class in any way (like accessing a static member),
         *     the static members are loaded into memory — even if you never create an object!
         *
         * 📦 Then, if/when you create an object using `new`, the instance members
         *     are stored separately in memory for that object only.
         *
         * 💡 Extra Tip:
         *     You *can* access static members using an object, but it's not recommended ❌
         *     Because static members belong to the class itself — not the object.
         *     So always access them using the class name for clarity ✅
         */
        public static void Run()
        {
            MystaticClass.MystaticMethod();

            MyNonStaticClass.MystaticProperty = "kiro from static propety";
            MyNonStaticClass.MystaticMethod();

            // here is after you made the object and refrence to it to nonstatic
            // (The object is a reference to memory that holds those non-static values.)so sosososo
            // if you try to access the static proprties or the methods so will not be shown 
            //static members are not part of the object — they're stored separately for the class itself.
            // That’s why you won’t see static members suggested when accessing through the object.

            MyNonStaticClass nonstatic = new MyNonStaticClass();
            nonstatic.MyInstanceProperty = "kiro is a fighter and the best";
            nonstatic.MyInstanceMethod();
        }
        static class MystaticClass
        {
            //'MystaticClass.name': cannot declare instance members in a static class
            //public string name { get; set; }
            public static void MystaticMethod()
            {
                Console.WriteLine("this the static method");
            }
        }


        class MyNonStaticClass
        {
            public string MyInstanceProperty { get; set; }

            public static string MystaticProperty { get; set; }

            public static void MystaticMethod()
            {
                Console.WriteLine($"the static property value is : {MystaticProperty}");
            }
            public void MyInstanceMethod()
            {
                Console.WriteLine($"the static propery value is:{MystaticProperty}");
                Console.WriteLine($"the instace property vlaue is :{MyInstanceProperty}");
            }
        }
        // 🔥 BONUS TIPS 🔥
        /*
         * 🔹 Static Constructor:
         *    - A static class or a class with static members can have a static constructor.
         *    - It runs only once, before any static member is accessed or the class is used.
         *    - You don’t call it manually.
         *
         * 🔹 Thread Safety:
         *    - Static members are shared across all threads.
         *    - In multi-threaded apps, make sure you use locks or thread-safe data structures
         *      when writing to static fields.
         *
         * 🔹 Use Cases:
         *    - Static classes are great for: 
         *      📌 Utility classes, logging, constants, converters, config access, helpers, etc.
         *    - Instance classes are for objects that represent real-world data 
         *      (like `User`, `Product`, `Order`, etc).
         *
         * 🔹 Shared Static Fields in Instance Classes:
         *    - If you declare a static field inside an instance class,
         *      that static field is shared by **all instances**.
         *      If one object changes it, all other objects will see the change.
         */
    }
}
