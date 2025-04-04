//while loop and do while loop


//1️ --> Count to N – Write a program that asks the user for a number N
//and prints all numbers from 1 to N using a while loop.

//int number = Convert.ToInt32(Console.ReadLine());

//int count = 0;
//while (count < number)
//{
//    Console.WriteLine(count);
//    count++;
//}

//2- --> Even Numbers Only – Print all even numbers from 1 to 100 using a while loop.

//int i = 0;

/*while (i <= 100)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    i++;
}*/


//3- Sum of Digits – Ask the user for a number and calculate the sum of its digits using a while loop.
//int num = 123;
//int sum = 0;

//Console.WriteLine($"num here is -->{num}");
/*while (num > 0)
{
    int last_digit = num % 10;
    sum += last_digit;
    num /= 10;
    Console.WriteLine($"num here is -->{num}");
}*/

/*do
{
    int LD = num % 10;
    sum += LD;
    num /= 10;
} while (num > 0);*/

//Console.WriteLine(sum);



// for loop 


/*//int i;
Console.WriteLine("inter the number you want to count");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 0; num > 0; i++ )
{
    int ld = num % 10;
    sum += ld;
    num /= 10;
}
Console.WriteLine( sum );*/


//using for loops with condtions 
// continue and break
/*for (int i = 0; i < 10; i++)
{
    if (i == 5) 
    {
        Console.WriteLine("we are outta here");
        continue;
    }

    Console.WriteLine(i);

    if (i == 6)
    {
        Console.WriteLine("you got it");
        break;
    }
}*/




// using Foreach loops to iterate over collections

//iterate over array
/*int[] numbersArr = { 1,2,3,4,5,6,7,8,9};
foreach (int i in numbersArr)
{
    Console.WriteLine(i);
    
}


List<string> numbers = new (){

    "red",
    "blue",
    "koko",
    "green",
};

int countList = 0;
foreach (string s in numbers)
{ 
    Console.WriteLine (s);
    countList++;

}
Console.WriteLine($"this the count from the integrated function to count the list of stirngs {numbers.Count}");
Console.WriteLine($"this the count from the our loop to count the list of stirngs {countList}");
*/

// in dictionaries
/*Dictionary<int, string> ages = new() 
{
    {1, "koko" },
    {2, "soso" },
    {3, "fofo" },
    {4, "shosho" },
};*/

/*foreach (KeyValuePair<int, string> person in ages)  //we used here the keyvaluepair in the type as the dictionary two types in it
{
    Console.WriteLine($"{person.Key} years old  name is  {person.Value}");
}*/

//another and better readable way to make the type as variable var
/*foreach (var person in ages)
{

    Console.WriteLine($"{person.Key} years old  name is  {person.Value}");
}
Console.WriteLine("=================================");*/
//using break with dictionaries
/*foreach (var person in ages)
{
    Console.WriteLine($"{person.Key} years old  name is  {person.Value}");

    if (person.Key == 3)
    {
        Console.WriteLine($"bas howa dh aly kan nfsy feeh aly rakm {person.Key}");
        Console.WriteLine("bay mn 5er salam");
        break;
    }

}*/


using Loops;

ForeEach.run();