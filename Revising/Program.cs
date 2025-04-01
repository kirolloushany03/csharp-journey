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
//floats vs double
// Floating point numbers are numbers with a decimal point
// A float in C# is 32 bits or 4 bytes
// The range of a float is 1.5 x 10^-45 to 3.4 x 10^38 I
// A double in C# is 64 bits or 8 bytes
// The range of a double is 5.0 x 10^-324 to 1.7 x 10^308


float sum = 5.5f + 10.5f ;
float difference = 5.5f - 10.5f ;
float product = 5.5f * 10.5f ;
double quotient = 5.5f / 10.5f ;

// 🖨️ Printing results
Console.WriteLine($"5.5 + 10.5 = {sum}");
Console.WriteLine($"5.5 - 10.5 = {difference}");
Console.WriteLine($"5.5 * 10.5 = {product}");
Console.WriteLine($"5.5 / 10.5 = {quotient}");
