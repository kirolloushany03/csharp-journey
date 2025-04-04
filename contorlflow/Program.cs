//using contorl flow

//int number = Convert.ToInt32(Console.ReadLine());

//if (number > 0)
//{
//    Console.WriteLine("postive");
//}
//else if (number < 0)
//{
//    Console.WriteLine("negative");
//}
//else
//{

//    Console.WriteLine("zero");

//}


//ternary operator
//variable  = (condition) ? true experession : false experession

//int x = 12;

//string result = x > 5 ? "x is greater than 12" : "x is lesss than 12";
//Console.WriteLine(result);


//string result1 = x == 5 ? "x is equal 12" : "x is not equal 12";
//Console.WriteLine(result1);


//string kk = x == 13 ? "bravo you got it ✔️" : "still not true ❌";
//Console.WriteLine(kk);


// learning the switch (statement, experession)in C# 
// what is your day ?

//Console.WriteLine("enter number from 1 to 7 to get your day name?");
//int number = Convert.ToInt32(Console.ReadLine());

////switch statements
//switch (number)
//{

//    case 2:
//    case 1:
//        Console.WriteLine("sunday");
//        break;

//        //Console.WriteLine("monday");
//        //break;
//    case 3:
//        Console.WriteLine("tuesday");
//        return; //return ends execution of the program ('return' exits the entire method.) 
//                // Unlike 'break', which exits only the switch case
//    case 4:
//        Console.WriteLine("wednesday");
//        break;
//    case 5:
//        Console.WriteLine("thursday");
//        break;
//    case 6:
//        Console.WriteLine("friday");
//        break;
//    case 7:
//        Console.WriteLine("saturday");
//        break;
//    //default:
//    //    Console.WriteLine("wrong number you have to choose 1 -> 7");
//    //    break;
//}

////or make the defult out of the thing here
//Console.WriteLine("wrong number you have to choose 1 -> 7");


////swithch experession (like ternary experession)

//Console.WriteLine("enter the day name to know what is it");

//string dayofweekname = Console.ReadLine().ToLower(); //here was a problme if the user entered Monday or monday
//                                                     //also we can use .ToUpper but you have to put all of the options uppercases                                              
//                                                     //(howa mal sayb) or also we can use .ToLower 

//string result = dayofweekname switch
//{
//    ("monday")=> "first day of the week",
//    _=> "invalid"  //default in the switch experession
//};

//Console.WriteLine(result);

////when to use statments or experessions you can use both
////but experession as it like more  cleaner and more maintainable code (readable and smaller in code will be better) 

////we can use switches in for example in the exception middlware  like in send responsed status code
////or in Http methods 


//Arrays
//-- zero based
//-- fixed size
//-- we can set and get values from array
//--fixed size
//-- we can get values from an array 
//-- we can set values to array


////decalartion
//int[] numbers = new int[3];//integer_array name_of_array = make_new_array ingert[size of array] 


//numbers[0] = 1;
//numbers[1] = 2;
//numbers[2] = 3;


////decalre and initialize an arry

//int[] number2 = new int[5]
//    {
//        5,6,7,8,9
//    };

//int[] number3 = new int[5]
//{
//    1,
//    2,
//    3,
//    4,
//    5
//};

//int[] number4 = new int[2]
//    {
//        14,
//        16
//    };

//Console.WriteLine($"so the lengith of number4 array is {number4.Length}");


//how to run resutl both files
using contorlflow;

If_StatemtsAND_TernaryOperators.Run();

SwitchStatementsAndExperessions.run();