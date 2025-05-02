////strings

//Console.WriteLine("hello");

////also we can use make sth like quotation to be shown by escaping using the \
////like this
//Console.WriteLine("this the code \"Console.WriteLine(\"hello\");\"");


//// so here we can declare a stirng variable
//string mystring;
//string my_string;
//string Mystring;

////we can also assign value to a string variable
//mystring  = "koko";
//Console.WriteLine(mystring);

////also we can initialise varaibles and concatenate them
//string firstName = "kirollous";
//string Nickname = "koko";
//string fullName = firstName + " His NickName is " +  Nickname;
//Console.WriteLine(fullName);


////we can also input data from the console by the user 
//Console.WriteLine("write your full name");
//my_string = Console.ReadLine();  //read the name from the console

////also we can print the length of the string using the string.length

//Console.WriteLine($"this your full name that you put it now \"{my_string}\" " +
//    $"and the length of your full name is \"{my_string.Length}\"");

////also we can access specific character using the indexing
//Console.WriteLine(my_string[0]);

////also we can decalre a single character 
//char a = 'a';

//---------------------------------------------------------------------------------
//---------------------------------------------------------------------------------

/*//integers (accept only whole nubmers)
// intgers in c# is 32 bits or 4 bytes
//the range of an integer is -2,147,483,648 to -2,147,483,647 just an infor to know

//also here decalring integers variables in c#
int myInt;
int my_int;
int Myint;

//assinging value to integer variable
myInt = 22;

//we can reassing a value to int varable
myInt = 21;


//doing some math with it 

int sum = 5 + 10;
int diffrence = 5 - 10;
int product = 5 * 10;
//float quotient = 5f / 10f;
int quotient = 5 / 10;


Console.WriteLine($"5 + 10= {sum}");
Console.WriteLine($"5 - 10= {diffrence}");
Console.WriteLine($"5 * 10= {product}");
Console.WriteLine($"5 / 10= {quotient}");*/

//---------------------------------------------------------------------------------
//---------------------------------------------------------------------------------
/*//floats vs double
// Floating point numbers are numbers with a decimal point
// A float in C# is 32 bits or 4 bytes
// The range of a float is 1.5 x 10^-45 to 3.4 x 10^38 I
// A double in C# is 64 bits or 8 bytes
// The range of a double is 5.0 x 10^-324 to 1.7 x 10^308


float sum = 5.5f + 10.5f ;
float difference = 5.5f - 10.5f ;
float product = 5.5f * 10.5f ;
float quotient = 5.5f / 10.5f ;

// 🖨️ Printing results
Console.WriteLine($"5.5 + 10.5 = {sum} --type--> {sum.GetType()}");
Console.WriteLine($"5.5 - 10.5 = {difference} --type--> {difference.GetType()}");
Console.WriteLine($"5.5 * 10.5 = {product} --type--> {product.GetType()}");
Console.WriteLine($"5.5 / 10.5 = {quotient} --type--> {quotient.GetType()}");


Console.WriteLine("\n=================double===================\n");
//normally when you write 5.5 and leave it will be like this "double"
double sum2 = 5.5f + 10.5f;  //so when you did like this so the 5.5f convert it implicitly to double
double difference2 = 5.5 - 10.5;  // as the double has more percision than float but better to keep it without f
double product2 = 5.5 * 10.5;
double quotient2 = 5.5 / 10.5;

// 🖨️ Printing results
Console.WriteLine($"5.5 + 10.5 = {sum2} --type--> {sum2.GetType()}");
Console.WriteLine($"5.5 - 10.5 = {difference2} --type--> {difference2.GetType()}");
Console.WriteLine($"5.5 * 10.5 = {product2} --type--> {product2.GetType()}");
Console.WriteLine($"5.5 / 10.5 = {quotient2} --type--> {quotient2.GetType()}");


Console.WriteLine("\n=================Decimal===================\n");

//so here in decimal you can not convert from double to decimal like what we did in double
//from float to double 
//and this because the double and decimal uses binary floating point representation
// and the decimal uses decimal floating point reprecination which is much more precise for financial calculations

// so now what !! what we can do ? dont worry you can just do the explicit conversion mean convert manually
//but just take care that the explicit compiler make the compiler make additional checks at rutime and make little slower in performce as it will need addtional loginc
decimal sum3 = (decimal)5.5d + (decimal)5.5f; // and as you can see here we can just one d and one f
                                              // and no problme both of them is decimal
// and to make it decimal and telling the complier use decimal we use m
decimal difference3 = 5.5m - 10.5m;  
decimal product3 = 5.5m * 10.5m;
decimal quotient3 = 5.5m / 10.5m;

// 🖨️ Printing results
Console.WriteLine($"5.5 + 10.5 = {sum3} --type--> {sum3.GetType()}");
Console.WriteLine($"5.5 - 10.5 = {difference3} --type--> {difference3.GetType()}");
Console.WriteLine($"5.5 * 10.5 = {product3} --type--> {product3.GetType()}");
Console.WriteLine($"5.5 / 10.5 = {quotient3} --type--> {quotient3.GetType()}");*/

//---------------------------------------------------------------------------------
//---------------------------------------------------------------------------------

//Boolean and some operators

//boolean is a tru or false value
// boolean in c# is 1 byte or 8 bits

//we can decalre and assign  a  value to these varaibles 
//bool myBool;


//myBool = false;
//myBool = true;

//// we can also intialise (decalre and assing value)
//bool mybool2 = true;

////we can re-assign
//mybool2 = false;


////also we can do some logic with it 
////using logical operators
////begin with 'and' '&&'

//Console.WriteLine("\n========= And && =========\n");

//bool TrueandFalse = true && false;
//bool TrueandTrue = true && true;
//bool FalseandFalse = false && false;

//Console.WriteLine($"True&&False = {TrueandFalse} --type--> {TrueandFalse.GetType()}");
//Console.WriteLine($"True&&True = {TrueandTrue} --type--> {TrueandTrue.GetType()}");
//Console.WriteLine($"False&False = {FalseandFalse} --type--> {FalseandFalse.GetType()}");

////using 'or' '||'
//Console.WriteLine("\n========= Or || =========\n");


//bool TrueorFalse = true || false;
//bool TrueorTrue = true || true;
//bool FalseorFalse = false || false;

//Console.WriteLine($"True&&False = {TrueorFalse} --type--> {TrueorFalse.GetType()}");
//Console.WriteLine($"True&&True = {TrueorTrue} --type--> {TrueorTrue.GetType()}");
//Console.WriteLine($"False&False = {FalseorFalse} --type--> {FalseorFalse.GetType()}");

////usign ! not

//Console.WriteLine("\n========= not ! =========\n");

//bool notTrue = !true;
//bool notFalse = !false;

//Console.WriteLine($"!true = {notTrue} --type--> {notTrue.GetType()}");
//Console.WriteLine($"!false = {notFalse} --type--> {notFalse.GetType()}");

//==========================================================================
//==========================================================================
/*
//datetime
// so here we can store date and time 
// or date only 
// or time only

//we can declare a DateTime variable
DateTime myDateTime;

// we can declare a DateOnly variable
DateOnly myDate;

// we can declare a TimeOnly variable
TimeOnly myTime;


myDateTime = DateTime.Now;
myDate = new DateOnly(2024,12, 04);
myTime = new TimeOnly(1,23,23);

//also we can decalre and initialise it 
DateTime mydatetime2 = DateTime.Now;
DateOnly myDate2 = new DateOnly(2025,12,03);
TimeOnly mytime2 = new TimeOnly(2,30,20);

//also we can reassign varaibles
myDateTime = DateTime.Now;
myDate = new DateOnly(2024, 1, 23);
myTime = new TimeOnly(1, 23, 45);

//also we can combine them 
DateTime Datetimecombination = new DateTime(
    myDate,
    myTime
    );

Console.WriteLine($"Date only: {myDate}");
Console.WriteLine($"time only: {myTime}");
Console.WriteLine($"Date time: {Datetimecombination}");*/


//==========================================================================
//==========================================================================

/*//going more deeply in casting 
//so there is two of them one is automatically done by c# (implicitly)
//and the other by us(explicitly)

// we can "implicitly" cast between types that are compatible
// for example, we can convert an int to a double
int myInt = 5;
double myDouble = myInt;
Console.WriteLine("Implicit Cast");
Console.WriteLine($"myInt={myInt}");
Console.WriteLine($"myDouble={myDouble}");

// we can also "explicitly" cast between types that are compatible
// for example, we can convert a double to an int
myDouble = 5.5;
myInt = (int) myDouble;
Console.WriteLine("Explicit Cast");
Console.WriteLine($"myInt={myInt}");
Console.WriteLine($"myDouble={myDouble}");

double myDouble2 = 5.5;
int myint = (int)myDouble2;
Console.WriteLine($"mydouble = {myDouble2} --type--> {myDouble2.GetType()}");
Console.WriteLine($"myint = {myint} --type--> {myint.GetType()}");

//// we cannot "cast" when the types are not compatible
//// for example, we cannot cast a string to an int
string myString = "5";
//myInt = (int)myString; // this will not compile will give you
// Cannot convert type 'string' to 'int'

//but we can use parse methode to convert from string to numbers 
myint = int.Parse(myString);
Console.WriteLine("restult from using parse");
Console.WriteLine($"mysring = {myString} --type--> {myString.GetType()}");
Console.WriteLine($"myint = {myint} --type--> {myint.GetType()}");

myString = "5.5";
myDouble = double.Parse(myString);
Console.WriteLine("restult from using parse dobule");
Console.WriteLine($"mysring = {myString} --type--> {myString.GetType()}");
Console.WriteLine($"mydouble = {myDouble} --type--> {myDouble.GetType()}");*/


//revice on if statemetns in c# syntax with some problems
//Problem 1: Even or Odd Number

/*using System.Runtime.CompilerServices;

int x = Convert.ToInt32( Console.ReadLine());
if (x % 2 == 0)
    Console.WriteLine($"this even {x}");
else
Console.WriteLine($"this odd {x}");
*/

//Problem 2: Age Checker
/*Console.WriteLine("write your age");
int age = Convert.ToInt32(Console.ReadLine());
if (age >= 18)
    Console.WriteLine($"you are allowed to enter the roller coaster bec your age {age}");
else
    Console.WriteLine($"your are not allowed to enter the roller coaster bec your age {age}");
*/


//Problem 3: Temperature Advice
/*using System.Text;

Console.OutputEncoding = Encoding.UTF8;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("write your temp🔥");
    long temp = Convert.ToInt32(Console.ReadLine());


    if (temp > 30)
    {
        Console.WriteLine("It’s hot 🔥 , stay cool!");
    }
    else if (temp < 10)
    {
        Console.WriteLine("It’s cold, wear a jacket! 🧥");
    }
    else
    {
        Console.WriteLine("its nice your are good 👍👍");
    }

}*/

//Problem 4: Grade Calculator



/*for (int i = 0; i < 5; i++)
{
    Console.WriteLine("write your grade");
    int grade = Convert.ToInt32(Console.ReadLine());


    if (grade >= 90 && grade <= 100)
    {
        Console.WriteLine("your grade A");
    }
    else if (grade >= 80 && grade <= 89)
    {
        Console.WriteLine("your grade B");
    }
    else if (grade >= 70 && grade <= 79)
    {
        Console.WriteLine("your grade C");
    }
    else
    {
        Console.WriteLine("your grade F");
    }

}*/


//revicing on ternary operator

//Console.WriteLine("input the number ");
//int num = Convert.ToInt32(Console.ReadLine());

// problem one

/*string result = num >= 50
    ? "pass"
    : "Failed" ;
Console.WriteLine(result);
*/

//problem 2
/*Console.WriteLine("write your num 2");
int num2 = Convert.ToInt32(Console.ReadLine());

string result = num > num2
    ? $"num 1 is the largest {num}"
    : $"num 2 is the largest {num2}";

Console.WriteLine(result);*/



//revicing on switch statements and experessions

//Problem 1 - Display the name of a day based on its number (Problem #20)

/*for (int i = 0; i < 6; i++)
{
    Console.WriteLine("write a number");
    int num = Convert.ToInt32(Console.ReadLine());

    switch (num)
    {
        case 1:
            Console.WriteLine("sunday");
            break;
        case 2:
            Console.WriteLine("monday");
            break;
        case 3:
            Console.WriteLine("tuesday");
            break;
        case 4:
            Console.WriteLine("wednesday");
            break;
        case 5:
            Console.WriteLine("thursday");
            break;
        case 6:
            Console.WriteLine("friday");
            break;
        case 7:
            Console.WriteLine("saturday");
            break;
        default:
            Console.WriteLine("weekend");
            break;
    }
}
*/
//swith experession
/*for (int i = 0; i < 6; i++)
{
    Console.WriteLine("enter the grade");
    string grade = Console.ReadLine().Trim().ToLower();

    string result = grade switch
    {
        "a" => "excellent",
        "b" => "good",
        "c" => "not bad",
        "d" => "tryagain",
        _ => "try again"
    };
    Console.WriteLine(result);
}*/

/*//revice on arrays buy finid the first and second and third biggest one in array
static void bigsec(int[] arr)
{
    int biggest = 0, secbig = 0, thirdbiggest = 0;

    foreach (int i in arr)
    {
        if (i > biggest)
        {
            thirdbiggest = secbig;
            secbig = biggest;
            biggest = i;

        }

    }
    Console.WriteLine($"this biggest num is {biggest}");
    Console.WriteLine($"this secound biggest num is {secbig}");
    Console.WriteLine($"this third biggest num is {thirdbiggest}");
}

bigsec([2, 2, 3, 1]);*/



//revice on list quickly

/*List<int> num = new List<int>();


num.Add(0);
num.Add(1);
num.Add(2);
num.Add(3);
num.Add(2);
num.Add(10);
num.Add(20);

Console.WriteLine($"{string.Join(",", num)} --> after adding elemets");


num.Remove(3);

Console.WriteLine($"{string.Join(",", num)} --> after removing 3");


num.Sort();
Console.WriteLine($"{string.Join(",", num)} --> after sorting elements");


num.Reverse();
Console.WriteLine($"{string.Join(",", num)} --> after reversing");


int x = num.IndexOf(10);
Console.WriteLine($"postion (index) of num 10 is {x}");

num.Insert(2, 133333);

Console.WriteLine($"{string.Join(",", num)} --> inserting 133333 in postion 3");


//Console.WriteLine($"{string.Join(",\n", num)}");*/



// revicing on dictionary
/*
Dictionary<string, int> wordstonumber = new();

wordstonumber.Add("one", 1);
wordstonumber.Add("two", 2);
wordstonumber.Add("three", 3);

Console.WriteLine(string.Join(",", wordstonumber));

Console.WriteLine(wordstonumber["one"]);

wordstonumber["one"] = 11245;

Console.WriteLine(string.Join(",", wordstonumber));

Console.WriteLine(wordstonumber.Count);

wordstonumber.Remove("one");

Console.WriteLine(string.Join(",", wordstonumber));

Console.WriteLine(wordstonumber.ContainsKey("one"));

bool contains2 = wordstonumber.TryGetValue
    (
        "two",
        out int kk
    );

Console.WriteLine($"so this the result of conains 2 {contains2} nd this the result of the vlaue of it {kk}");


*/


//revice on loops in a quick Problem: Sum of Positive Numbers


/*int sum = 0;
Console.Write("enter a numer: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number >= 0)
{
    if (number != 0)
    {
        sum += number;
    }

    Console.Write("enter a numer: ");
    number = Convert.ToInt32(Console.ReadLine());

}
Console.WriteLine(sum);*/


/*int sum = 0;
int number;

for (; ; )
{
    Console.Write("Enter a number (0 to stop): ");
    number = Convert.ToInt32(Console.ReadLine());

    if (number <= 0)
        break;

    sum += number;
}

Console.WriteLine("Sum: " + sum);*/



//==========================
//revice on for each
/*using System.Net.Http.Headers;

List<int> numbers = new List<int> { 10, 25, -5, 0, 15, -2, 30 };

Dictionary<string, int> myDictionary = new Dictionary<string, int>
{
    { "koko", 3 },
    { "soso", 5 },
    { "fofo", 2 }
};*/

//print all the values in list
/*foreach (int i in numbers)
{
    Console.WriteLine(i);
}*/


/*//print the dictionary
foreach (KeyValuePair<string, int> babies in myDictionary)
{
    Console.WriteLine($"so this {babies.Key} and the age is {babies.Value}");
}
Console.WriteLine("===================");
//usign break and continue
foreach (KeyValuePair<string, int> i in myDictionary)
{
    if (i.Value == 2)
        break;
    Console.WriteLine(i);
}
*/



//revice on the methods one without anything
//one with arguments
//and last one is with return type and arguemtns

/*void PrintwelcomeMessage()
{
    Console.WriteLine("welcome yala");
}

void sum(int x , int y)
{
    Console.WriteLine($"the sum of the {x} and {y} is {x+y}");
}

int multiply(int x , int y)
{
    return x * y;
}


PrintwelcomeMessage();
sum(10, 15);

int result = multiply(2,5) ;
Console.WriteLine($"the result is : {result}");*/


// revice on try and catch 

/*int divide(int a , int b)
{
    return a / b; 
}


try
{
    divide(1, 0);// so if you have other lines of code after it so it will not run
    //             // if there is an erro inhis line so it will go the catching errors
                    //but to be sure that these lines will always run but in finally block
    //
    //
}
catch (DivideByZeroException e) when (e.Message.Contains("zero"))
{
    Console.WriteLine("you cant divide by zero");
}
catch (Exception e)
{
    Console.WriteLine($"the exception is");
    Console.WriteLine(e);
} //and the finally is will always run after the exception 

finally
{
    Console.WriteLine("and finally finally the code will always run");
}


*/

/* 
╔══════════════════════╗
║   📘 Review on OOP   ║
╚══════════════════════╝
*/




//if you here just put the class before the statemets will give you an error called
// Top-level statements must precede namespace and type declarations.
// and this because statrted from c# version 9 it made top level statemts as 
// you dont have to write main function before doing anythinng but any statmetns recognised
// that it runs inside the main function there is no method come before the main functions

//polished version
// ⚠️ If you try to define a class before top-level statements,
// you'll get an error:
// "Top-level statements must precede namespace and type declarations."

// 🧠 This is because, starting from C# 9, you can write code
// without explicitly declaring a Main method.

// 📌 All top-level statements are treated as if they are
// inside a hidden 'Main' method.

// 🚫 Therefore, type declarations like classes or namespaces
// must come *after* these statements, because you can't define
// a class *inside* a method in C#.


/*using System;
using System.Net.Http.Headers;

Ourclass ourobject = new Ourclass();
Ourclass ourobject2 = new();


//lets make a new instance 
Our2ndclass result = new Our2ndclass();*/
//result.ExampleMehtod();
//int x  = result.ExampleFunction(1, 2);

//so here we can ask question why here we did not create console object everytime
//we try to use it  (and this becase we make it static 🤫🤫)
//Console.WriteLine(x);


//we will knwo about the refrence types in c#
//so first of all the normal datatypes like int, float , double, dattime --> value types
//but objects called refrence types


/*Ourclass object1 = new Ourclass();
Ourclass object2 = new Ourclass();
Ourclass object3 = object1;*/



//so we cna test it 
//Console.WriteLine($"is object 1 == object 2  --> {object1 == object2}"); //this will give false 
//Console.WriteLine($"is object 1 == object 3  --> {object1 == object3}"); // this will give true


//collections

/*List<int> mynumbers1 = new List<int> { 1, 2, 3 };
List<int> mynumbers2 = new List<int> { 1, 2, 3 };*/

//Console.WriteLine($"is the mynumbers1 == mynumbers2 --> {mynumbers1 == mynumbers2}");


//so thats why the objects is pass by refrence and call by refernce
//and the primitive types is called and pass by value like the int , double and these things

//==========================================================================

/*void ChangeRefrrence(List<String> words)
{
    words.Add("kiro");
    words.Add("is");
    words.Add("best");

    words = new List<string>();

    words.Add("112121");
}

List<string> mywords = new List<string> { "kkiro", "kkkiro" };
Console.WriteLine("mywords before change refrence");
Console.WriteLine(string.Join(",", mywords));

ChangeRefrrence(mywords);

Console.WriteLine("mywords after change refrence");
Console.WriteLine(string.Join(",", mywords));


class Ourclass()
{
    int x = 0;
}

class Our2ndclass()
{
    public void ExampleMehtod()
    {
        Console.WriteLine("Hellow from the Example method");
    }
    public int ExampleFunction(int a, int b)
    {
        return a + b;
    }
}*/

//=====================================================================================

//what is the fields  --> variable decalred directly in a class

/*Person2 kiro = new Person2();
kiro._email = "soso@hotgmail.com";
Console.WriteLine(kiro._email);*/

/*Person3 name3 = new Person3();
Console.WriteLine(name3.GetName());*/


/*Person4 kirowithproperty = new Person4();
Console.WriteLine(kirowithproperty.Name);
Console.WriteLine(kirowithproperty.Name2);
Console.WriteLine(kirowithproperty.Name3);
kirowithproperty.Name3 = "hellow form the new Name 3 seeting and the name now that kiro is the best";
Console.WriteLine(kirowithproperty.Name3);

Console.WriteLine("setting the name .. ");
kirowithproperty.Mutablename = "kiro is hero";
Console.WriteLine(kirowithproperty.Mutablename);
class Person 
{
    private string _name;
    public void Me()
    {
        this._name = "kiro";
    }
}

class Person2
{
    private string _email = "kk@gmail.com";
}

class Person3
{
    private string _name = "kiro"; //(field initialized)

    public string GetName() //(method)
    {
        return _name;
    }
}

//what is the properties? member that provide controllerd access (flexible mechanism)
// to read , write or compute the value of a private field and it 
// provide protection for a class field to keep it from being changed
// without the knowledge of the object.
//we can deal with it likek the fields


class Person4
{
    private string _name = "kiro";

    // this the first variation so this variation is for some complex logic
    public string Name
    {
        get
        {
            return _name;
        }
    }

    //secound variation
    public string Name2 => _name;

    //third variation (auto implemented read only properting with initializer)
    public string Name3 { get; set; } = "kirohero"; // this can not access _name
                                               // but another shape for properties

    //fourth variation 
    public string Mutablename
    {
        get { return _name; }
        set { _name = value; }
    }
}*/



//-----------------------------------------------------------------------------
//revice static vs instance

//so first of all to dont get frustrated okay 
//before we continue why we can use static and why we can use instance normal one 

//static
/*
    1-so we can say that the static class that must have static members
    2-we can think it like a function okay to apply the concept DRY(Don't repeat your self)
    3-here you can't create instance like the normal classes
    4- How it works with memory ?
        so in normal calsses that i can create instance the object take place in memory 
        and this only when i create new object from the class
        for instance if the class have only one field liek "int age = 22;"
        so here when in create people p = new people(); so then here in this moment 
        the object take place in memory of the "int age = 22" of this object

        but in static when you just write the class it take place in memory without need
        instance of the class so the class it self take place int he mamory 
 */

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



/*MystaticClass.MystaticMethod();

MyNonStaticClass.MystaticProperty = "kiro from static propety";
MyNonStaticClass.MystaticMethod();

// here is after you made the object and refrence to it to nonstatic
// (The object is a reference to memory that holds those non-static values.)so sosososo
// if you try to access the static proprties or the methods so will not be shown 
//static members are not part of the object — they're stored separately for the class itself.
// That’s why you won’t see static members suggested when accessing through the object.

MyNonStaticClass nonstatic  = new MyNonStaticClass();
nonstatic.MyInstanceProperty = "kiro is a fighter and the best";
nonstatic.MyInstanceMethod();



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
}*/



//---------------------------------------------------------------------------
// constructors --usage--> are used to initialise a class
// so we have two kinds of constructor 
//implicit one and this the default one even if you can't see it
// like normale class and this one like this have default constructor
//and here in the c# it made the default constructor that have default values for the types
//like if you just decalred integer likek this "int age;" so to dont makek errors the default 
//constructor have default values if you did not initilise it iti insitlises with the default value
//so here when i made this test that i just decalred "int age;" and i print it it gave me 0
//so thats mean that the default constructor have default values to initilse the varaible that dont have iniitilization 
//so question why we have default constructor ???? and this to avoid errors and bugs 

//?????????????????????????????????????????????????????????????????

ImplicitConstructor test = new ImplicitConstructor();
test.test1();

ConstructorwithParameter test2 = new ConstructorwithParameter("msa2 alfol");


MultipleConstructors instanceTest = new();
MultipleConstructors instanceTest2 = new(22, "this go directly to the Parameterized constructor");


ourcollectionWords words = new ourcollectionWords(); //here the list initilised
words.Add("kiro");       //}
words.Add("spider-man"); //} --> now all of these just adding in the list   
words.Add("Batman");     //}

words.print();  //print what in the list


//collectionwords2 same as previous but this one will pass to the constrrcutor list of words
ourcollectionWords2 words2 = new ourcollectionWords2(["kiro", "play", "spiderman", "remastered edition"]);
words2.print();


//because of the construcotr is static
//so it will print jsut only one time
//becase it is tstaic related to the class it self not genrate instance
var t1 = new staticconstructor();
var t2 = new staticconstructor();


OurClassWithHiddenConstructor t3 = new OurClassWithHiddenConstructor(22);

class ImplicitConstructor
{
    int age;

    public void test1()
    {
        Console.WriteLine($"so this the value of age that only decalred --> {age}");
    }
}

//explicit one that you can do what ever you want you can add parameters to it 
//you can jsut make ti to print sth any thin you can initialise it

//and this the first version  about parameterless

class ExplicitConstructor
{
    public ExplicitConstructor()
    {
        Console.WriteLine("exciplicit constructor here");
    }
}


class ConstructorwithParameter
{
    public ConstructorwithParameter(string message)
    {
        Console.WriteLine(message);
    }
}


//Now Combine both the default one and the Parameterized  constructor

//so here what happen 
//first i just the default constroto goes to it so it shows that there is this so it called the Parameterized constructor
//and then i comes backe to the constent in the default constructor 

//but in the sedcound initizlation it sent to it directly to the Parameterized constructor
//and this the output 
/*so this the number 1 and this the message this deault number and go to the Parameterized constructor
and this message that inthe default constructor
so this the number 22 and this the message this go directly to the Parameterized constructor*/


class MultipleConstructors
{
    public MultipleConstructors()
        : this(1, "this deault number and go to the Parameterized constructor") //so this one call Parameterized one
                                                                                //and give to it the parameter the default one
                                                                                //that we already put it like the the message
                                                                                //and then it comet to the things that in the defaoutl constructor
    {
        Console.WriteLine("and this message that inthe default constructor");
    }

    public MultipleConstructors(int number, string message)
    {
        Console.WriteLine($"so this the number {number} and this the message {message}");

    }
}



class ourcollectionWords
{
    private List<string> _strings;// actully you here can initlsie the list
                                  // but it is safest to initialise it in the constructor
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
        foreach (var word in _strings) //we can use var but the most
                                       //improtant thing that to use var with insitalized variable
        {
            Console.WriteLine(word);
        }

    }
}

class ourcollectionWords2
{
    private List<string> _strings;// actully you here can initlsie the list
                                  // but it is safest to initialise it in the constructor
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
        foreach (var word in _strings) //we can use var but the most
                                       //improtant thing that to use var with insitalized variable
        {
            Console.WriteLine(word);
        }

    }
}



class staticconstructor
{
    static staticconstructor()
    {
        Console.WriteLine("static constrocot from staticconstructor class");
    }
}



class OurClassWithHiddenConstructor
{
    public OurClassWithHiddenConstructor(int value)
        : this()
    {
        Console.WriteLine($"THIS THE PUBLIC CONSTRUCTOR" +
            $"we recived {value}");
    }

    private OurClassWithHiddenConstructor() 
    {
        Console.WriteLine($"no one can call this the private one " + 
            $"from outside directly!");
    }
}