using System.Security.Cryptography.X509Certificates;
using System.Text;

int IntDivision(int x, int y) 
{
    return x / y; 
}

Console.OutputEncoding = Encoding.UTF8; //to convert to utf8 to be able to show the emojies
//int result  = IntDivision(10, 0);


// using try catch blocks

try 
{
    int result = IntDivision(10, 0);

}
catch (Exception e)
{
    Console.WriteLine("an exception was thrown!");
    Console.WriteLine($"message of exception => {e.Message}");
}

Console.WriteLine("===================================(👆☝️👆 so this the original catch)");

//we can also catch specific types of execeptions and handle them differently
try
{
    int result = IntDivision(10, 0);

}
catch (DivideByZeroException e)
{
    Console.WriteLine("you can't divide by zero");
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine("an exception was thrown!");
    Console.WriteLine($"message of exception => {e.Message}");
}

Console.WriteLine("===================================(👆☝️👆 catch with specific types of exceptions)");


//also we can use exception filters  to catch exceptions meet certain conditions
try
{
    int result = IntDivision(10, 0);

}
catch (Exception e) when (e.Message.Contains("divide by zero"))
{
    Console.WriteLine("cant divide by zero");
}
catch (Exception e)
{
    Console.WriteLine("an exception was thrown!");
    Console.WriteLine($"message of exception => {e.Message}");
}

Console.WriteLine("===================================(👆☝️👆 catch by filtering the catch message by contains)");


//adding finally block 
try
{
    int result = IntDivision(10, 0);

}
catch (Exception e)
{
    Console.WriteLine("an exception was thrown!");
    Console.WriteLine($"message of exception => {e.Message}");
}
finally
{
    Console.WriteLine("and this the end of the debugging and exceptions session for example 😂");
}

Console.WriteLine("===================================(👆☝️👆 adding finally)");
