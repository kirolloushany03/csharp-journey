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
using System.Net.Http.Headers;

List<int> numbers = new List<int> { 10, 25, -5, 0, 15, -2, 30 };

Dictionary<string, int> myDictionary = new Dictionary<string, int>
{
    { "koko", 3 },
    { "soso", 5 },
    { "fofo", 2 }
};

//print all the values in list
/*foreach (int i in numbers)
{
    Console.WriteLine(i);
}*/


//print the dictionary
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
