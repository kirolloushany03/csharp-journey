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

