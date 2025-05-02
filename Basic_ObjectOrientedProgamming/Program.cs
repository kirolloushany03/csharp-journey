//StaticVsInstance.RunMain();

//constructors are used to initialize a class

//here we did just simple instance and with that without putting any mehtod in the class
// this because constructor is the first thing that executed when an object of a class is created.
/*ExplicitConstructor explicitcons = new ExplicitConstructor();

ConstrucotrWithParameters ConsWithParam = new("msa msa");

MultipleConstructors multipleConstructors = new MultipleConstructors("i am the best here ");

*/

/*//Console.WriteLine("our collectsion class");
Console.WriteLine("our collectsion2 class");
*/
/*OurCollection ourCollection = new OurCollection();
ourCollection.Add("kk");
ourCollection.Add("hellow");
ourCollection.print();*/

/*OurCollection2 ourCollection2 = new (new List<string> 
{ 
    "kiro",
    "koko"
});

ourCollection2.print();*/



/*var t1 = new StaticConstructor();
var t2 = new StaticConstructor();*/


/*OurClassWithHiddenConstructor instance = new(123);

static string RepeatStr(int n, string s)
{
    List<string> list = new List<string>();
    if (n > 0)
    {
        for (int i = 0; i < n; i++)
        {
            list.Add(s);
        }
    }
    return string.Join("",list);
}

RepeatStr(3, "*");


*//*the implicit constructutor
it is the default constractor that comes with the class so we dont have to decalre one
 does not do anything*//*

class ImpliciConstructor
{ 
}

//here the class has parameterless constructor (means constructor dont take any parameters)
class ExplicitConstructor
{
    public ExplicitConstructor()
    {
        Console.WriteLine("explicit constructor printed this ");
    }
}


// here a class that has constructor that has parameter
class ConstrucotrWithParameters
{
    public ConstrucotrWithParameters(string words)
    {
        Console.WriteLine($"so this your word --> {words}");
    }
}


//so here we can use the two constructos together the default with the  one that take parameters 
//using : this() syntax and this put it before the begining of the defualt one
class MultipleConstructors
{

    public MultipleConstructors()
                : this("this the default message")
    {
    }

    public MultipleConstructors(string message)
    {
        Console.WriteLine(message);
    }
}

// so you can normally to initialize the fields without the constructor
// but the constructor made to initialize it 

class OurCollection
{
    private List<string> _string;
    //private List<string> _string = new List<string>(); // i can do this 
    // but normally the inline intialization happens first before constructor
    // so better fo rclean code to put it the initilization in the constructor
    // (more organized as you go bigger projects)
    public OurCollection()
    {
        _string = new List<string>();
    }

    public void Add(string word)
    {
        _string.Add(word);
    }

    public void print()
    {
        foreach (var word in _string)
        {
            Console.WriteLine(word);
        }
    }
}

//conintuen on the previous exampel
// passing list of words to the constructor instead of using the add method in the previous one
class OurCollection2
{
    private List<string> _string;
    public OurCollection2(List<string> words)
    {
        _string = new List<string>();
        foreach (var word in words)
        {
            _string.Add(word);
        }
    }

    public void print()
    {
        foreach (var word in _string)
        {
            Console.WriteLine(word);
        }
    }
}

class StaticConstructor
{ 
    static StaticConstructor()
    {
        Console.WriteLine("staticConstructro consturctor called");
    }
}


class OurClassWithHiddenConstructor
{ 
    public OurClassWithHiddenConstructor(int value)
        :this()
    {
        Console.WriteLine( $"so this the bublic constructor" + 
                            $"and thsi teh recived {value}");
    }

    private OurClassWithHiddenConstructor()
    {
        Console.WriteLine("nobody call thsi one " + 
                           "directly from the outside");
    }
}
*/





using Basic_ObjectOrientedProgamming;

//Fields_and_properties.Run();


Constructor.Main_Run();


// this also another version from constructor that have the tests and the constructor 
//below it so we can realte to it 


// 👷‍♂️ Constructors — Usage --> are used to initialize a class
// 🔹 We have two kinds of constructors:
//    1. **Implicit (default)** — created by the compiler even if you don't see it.
//    2. **Explicit** — you write it yourself, can be parameterless or parameterized.
//
// 🎯 Why do we have default constructors?
// ✅ To avoid errors and bugs from uninitialized fields.
//    Example: if you declare "int age;" and print it, it gives 0 —
//    that's because the default constructor gives it a default value.

// --------------------------------------------------------------------------------------------
// 🔹 Implicit Constructor — Default Values Test
/*
ImplicitConstructor test = new ImplicitConstructor();
test.test1();
*/
class ImplicitConstructor
{
    int age;

    public void test1()
    {
        Console.WriteLine($"so this is the value of 'age' that was only declared --> {age}");
    }
}

// --------------------------------------------------------------------------------------------
// 🔹 Explicit Constructor (Parameterless)
/*
ExplicitConstructor test = new ExplicitConstructor();
*/
class ExplicitConstructor
{
    public ExplicitConstructor()
    {
        Console.WriteLine("explicit constructor here");
    }
}

// --------------------------------------------------------------------------------------------
// 🔹 Constructor with Parameter
/*
ConstructorwithParameter test2 = new ConstructorwithParameter("msa2 alfol");
*/
class ConstructorwithParameter
{
    public ConstructorwithParameter(string message)
    {
        Console.WriteLine(message);
    }
}

// --------------------------------------------------------------------------------------------
// 🔹 Multiple Constructors (Default & Parameterized)
/*
MultipleConstructors instanceTest = new(); // Goes to the default constructor
MultipleConstructors instanceTest2 = new(22, "this go directly to the Parameterized constructor");
*/
// 🧠 What happens here:
// When using the default constructor:
//    ➤ it first calls the parameterized one with default values (1, "...")
//    ➤ then prints from the default constructor body
//
// When using the parameterized constructor directly:
//    ➤ it skips the default and goes straight to the parameterized one
class MultipleConstructors
{
    public MultipleConstructors()
        : this(1, "this default number and go to the Parameterized constructor")
    {
        Console.WriteLine("and this message that is in the default constructor");
    }

    public MultipleConstructors(int number, string message)
    {
        Console.WriteLine($"so this is the number {number} and this is the message: {message}");
    }
}

// --------------------------------------------------------------------------------------------
// 🔹 Collection Initialization using Default Constructor
/*
ourcollectionWords words = new ourcollectionWords(); // here the list is initialized
words.Add("kiro");
words.Add("spider-man");
words.Add("Batman");

words.print();  // 🖨️ print what's in the list
*/
// 📝 Notes:
// ➤ You *can* initialize the list at declaration,
//    but it's safer and cleaner to do it in the constructor.
class ourcollectionWords
{
    private List<string> _strings;

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
        foreach (var word in _strings)
        {
            Console.WriteLine(word);
        }
    }
}

// --------------------------------------------------------------------------------------------
// 🔹 Collection Initialization using Parameterized Constructor
/*
ourcollectionWords2 words2 = new ourcollectionWords2(
    new List<string> { "kiro", "play", "spiderman", "remastered edition" });

words2.print();
*/
// 📝 Notes:
// ➤ Constructor receives a list and fills an internal list with it.
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

// --------------------------------------------------------------------------------------------
// 🔹 Static Constructor — Runs Once per Class
/*
var t1 = new staticconstructor();
var t2 = new staticconstructor(); // Only one static constructor call will happen
*/
// 📝 Notes:
// ➤ Static constructors are related to the class itself.
//    So it runs only once — when the class is first accessed.
class staticconstructor
{
    static staticconstructor()
    {
        Console.WriteLine("static constructor from staticconstructor class");
    }
}

// --------------------------------------------------------------------------------------------
// 🔹 Hidden (Private) Constructor Called via Public One
/*
OurClassWithHiddenConstructor t3 = new OurClassWithHiddenConstructor(22);
*/
// 📝 Notes:
// ➤ The public constructor calls the private one internally,
//    so no one from outside can use the private one directly.
class OurClassWithHiddenConstructor
{
    public OurClassWithHiddenConstructor(int value)
        : this()
    {
        Console.WriteLine($"THIS IS THE PUBLIC CONSTRUCTOR — we received: {value}");
    }

    private OurClassWithHiddenConstructor()
    {
        Console.WriteLine("⚠️ no one can call this — it's the private one from outside directly!");
    }
}
