/*using Basic_ObjectOrientedProgamming;

CreatingClasses.Run();*/

// first differnce and the most improtand between the static and instance memebers
// static --> shared across all the objects
// instance --> each objects has its own unique value

/*
 * so static member 
    * static members (fields or methods, properties) --> can not access instance memebers  (fields or methods , properties)
* 
* but instance memeber
    * can access static members 
* 
*/


/*
 * so when to use the static memebers and when to use the instance memebers
 * 
 * using the static memebers when data should be shared across all the objects
 * 
 * using the instance memebers when data is unique per object
 */




/*
 * so we can not make instance from the static members 
 * so you can use it or access it wihtout making instance
*/


// so we will get this erro if we try it
// Cannot create an instance of the static class 'StaticClass'
/*StaticClass mystaticClass = new StaticClass();*/


//but we can use it directly without making an instance 
StaticClass.MystaticMethod();
// and this exactly like when we use the "WriteLine" from the "Console"
// in Console.WriteLine(""); why we do this \
// because the Console class is static and also the WriteLineMethod is also static


MyNonStaticClass NonStatic1 = new();
MyNonStaticClass NonStatic2 = new();

Console.WriteLine("before mutatin properties on my MyNonStaticClass");
NonStatic1.MyinstanceMethod();
NonStatic2.MyinstanceMethod();
MyNonStaticClass.MyStaticMethod();

//mutating the properties
Console.WriteLine("\nmutating the properties\n");
NonStatic1.MyInstanceProperty = "dev";
NonStatic2.MyInstanceProperty = "is the learder";
MyNonStaticClass.MyStaticProperty = "kiro Hkmk";


Console.WriteLine("\naferte chanign the prperties\n");
NonStatic1.MyinstanceMethod();
NonStatic2.MyinstanceMethod();
MyNonStaticClass.MyStaticMethod();









class MyNonStaticClass
{

    public string MyInstanceProperty { get; set; } = "kiro";

    public static string MyStaticProperty { get; set; } = "hh";

    //here tryign to access static and instance properties from static method
    public static void MyStaticMethod()
    {
        Console.WriteLine($"so this the  static property {MyStaticProperty}");

        //here we got error becasue MyInstanceProperty is is non static
        //Console.WriteLine($"so this the instance property {MyInstanceProperty}");
    }

    public void MyinstanceMethod()
    {
        Console.WriteLine($"so this the  static property {MyStaticProperty}");
        Console.WriteLine($"so this the instance property {MyInstanceProperty}");
    }

}


static class StaticClass
{
    public static void MystaticMethod()
    {
        Console.WriteLine("this from the static method");
    }
}