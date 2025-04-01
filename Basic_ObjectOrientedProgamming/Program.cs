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


OurClassWithHiddenConstructor instance = new(123);

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


/*the implicit constructutor
it is the default constractor that comes with the class so we dont have to decalre one
 does not do anything*/

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






