// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//[1]
//simple program to greet user
//Console.WriteLine("what is your name?");

////get the user name
//string name = Console.ReadLine();

//Console.WriteLine("Hello How are your " + name);



/*int num1 = Console.Read();
 
Console.WriteLine($"{num1}+10 = {5+10}");*/

////float
//Console.WriteLine("this with float sign\n");
//Console.WriteLine($"5.5 + 5.10 = {5.5f + 5.10f}");
//Console.WriteLine($"5.5 - 5.10 = {5.5f - 5.10f}");
//Console.WriteLine($"5.5 * 5.10 = {5.5f * 5.10f}");
//Console.WriteLine($"5.5 / 5.10 = {5.5f / 5.10f}");

//Console.WriteLine("====================================");
//Console.WriteLine("this with double sign\n");
//// double ones we can just put the number or add d
//Console.WriteLine($"5.5 + 5.10 = {5.5 + 5.10}");
//Console.WriteLine($"5.5 - 5.10 = {5.5d - 5.10d}");
//Console.WriteLine($"5.5 * 5.10 = {5.5d * 5.10}");
//Console.WriteLine($"5.5 / 5.10 = {5.5 / 5.10d}");

////the only to be true is both sides to be true
//Console.WriteLine($"true && false = {true && false}");
//Console.WriteLine($"true && true = {true && true}");
//Console.WriteLine($"false && false = {false && false}");

//Console.WriteLine("====================================");

////if there is true so the answer willl be true
//Console.WriteLine($"true || false = {true || false}");
//Console.WriteLine($"true || true = {true || true}");
//Console.WriteLine($"false || false = {false || false}");

////using not operator !
//bool nottrue = !true;
//bool notfalse = !false;
//Console.WriteLine("====================================");

//Console.WriteLine($"notTrue  = {nottrue}");
//Console.WriteLine($"notfalse = {notfalse}");


//another value type DateTime
//so we have 3 types DateTime | DateOnly | TimeOnly

//// we can declare a DateTime variable
//DateTime myDateTime;

//// we can declare a DateOnly variable
//DateOnly myDate;

//// we can declare a TimeOnly variable
//TimeOnly myTime;

//// We can assign a value to these variables
//myDateTime = DateTime.Now;
//myDate = new DateOnly(2024, 1, 23); // why we make new this because dateonly is struct
//                                    // so we make instance from it
//                                    // so we create 
//myTime = new TimeOnly(1, 23, 45);

//// We can declare and assign in one line
//DateTime myDateTime2 = DateTime.Now;
//DateOnly myDate2 = new DateOnly(2024, 1, 23);  //yyyy/mm/day
//TimeOnly myTime2 = new TimeOnly(1, 23, 45); //h/min/sec


//DateTime dattimeffromcombination = new DateTime(myDate, myTime);

//Console.WriteLine(myDateTime);
//Console.WriteLine(DateTime.Now);
//Console.WriteLine(dattimeffromcombination);


//implicit converstion and this happen automtically where there is not data loss

//explicit conversion
//from string to double 
string me = "5.5";

double myint = double.Parse(me);
Console.WriteLine($"so the answer will be {myint} and the type {myint.GetType()}");

Console.WriteLine("=================================");
//covert from double to string
double mydouble = 5.5;

string k = mydouble.ToString();
Console.WriteLine($"so the answer will be {k} and the type {k.GetType()}");

