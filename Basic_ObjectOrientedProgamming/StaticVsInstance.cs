using System;

namespace Basic_ObjectOrientedProgamming
{
    internal class StaticVsInstance
    {
        public static void RunMain()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // to enable emojies
            /*
             * 🔥 Difference Between Static and Instance Members 🔥
             * 
             * ✅ Static → Shared across all objects.
             * ✅ Instance → Each object has its own unique value.
             */

            /*
             * 🚀 Static Members:
             * - Apply to the class itself, not a specific object.
             * - Cannot access instance members (fields, methods, properties).
             * 
             * 🚀 Instance Members:
             * - Belong to a specific object.
             * - Can access both instance and static members.
             */

            /*
             * 🛠️ When to Use:
             * ✅ Use **static members** when data should be shared across all objects.
             * ✅ Use **instance members** when data is unique per object.
             */

            /*
             * ❌ Cannot create an instance of a static class!
             * StaticClass myStatic = new StaticClass();  // ❌ ERROR: Cannot instantiate a static class
             */

            // ✅ Using a static method directly (without instantiation)
            StaticClass.MyStaticMethod();

            /*
             * 🎯 Example: Console.WriteLine() works the same way.
             * - Console is a static class.
             * - WriteLine is a static method.
             * - That’s why we don’t need to create an instance of Console!
             */

            MyNonStaticClass nonStatic1 = new();
            MyNonStaticClass nonStatic2 = new();

            Console.WriteLine("\n🔹 Before mutating properties in MyNonStaticClass:");
            nonStatic1.MyInstanceMethod();
            nonStatic2.MyInstanceMethod();
            MyNonStaticClass.MyStaticMethod();

            // 🔄 Mutating the properties
            Console.WriteLine("\n🔄 Mutating the properties...\n");
            nonStatic1.MyInstanceProperty = "dev";
            nonStatic2.MyInstanceProperty = "is the leader";
            MyNonStaticClass.MyStaticProperty = "Kiro Hkmk";

            Console.WriteLine("\n✅ After changing the properties:\n");
            nonStatic1.MyInstanceMethod();
            nonStatic2.MyInstanceMethod();
            MyNonStaticClass.MyStaticMethod();
        }
    }

    // 🚀 Class with Both Static and Instance Members
    class MyNonStaticClass
    {
        // Instance property (unique for each object)
        public string MyInstanceProperty { get; set; } = "kiro";

        // Static property (shared across all objects)
        public static string MyStaticProperty { get; set; } = "hh";

        /*
         * ❌ Static methods cannot access instance properties.
         * - Because static methods belong to the class, not an object.
         */
        public static void MyStaticMethod()
        {
            Console.WriteLine($"Static Property: {MyStaticProperty}");
            // ❌ ERROR: Cannot access non-static members in a static method
            // Console.WriteLine($"Instance Property: {MyInstanceProperty}");
        }

        // ✅ Instance methods can access both static and instance members.
        public void MyInstanceMethod()
        {
            Console.WriteLine($"Static Property: {MyStaticProperty}");
            Console.WriteLine($"Instance Property: {MyInstanceProperty}");
        }
    }

    // ✅ Static Class Example
    static class StaticClass
    {
        public static void MyStaticMethod()
        {
            Console.WriteLine("📢 This is from the static method.");
        }
    }
}
