
using System.Linq.Expressions;
using System.Security;

KiroCoolestCalaculator kiro = new("hellow the coolest calculator ever");
kiro.Start();


public sealed class KiroCoolestCalaculator
{
    private string _greeting;

    public KiroCoolestCalaculator(string greeting)
    { 
        _greeting = greeting;
    }

    public void Start()
    {
        Console.WriteLine(_greeting);

        Dictionary<string, string> supportedOpertaors = new()
        {
            {"+","Add" },
            {"/", "Divide"},
            {"-", "minus" },
            {"x", "mulitply" }
        };

        while (true)
        {
            Console.WriteLine("opertor choices are as follows:");
            foreach (var op in supportedOpertaors)
            {
                Console.WriteLine($"{op.Value}.{op.Key}");
            }

            Console.WriteLine("Enter an Opertor:");
            string ChoosedOpertor = Console.ReadLine();

            if (!supportedOpertaors.TryGetValue(
                ChoosedOpertor,
                out var selctedOpertorDescrtiption))
            {
                Console.WriteLine("Invalid opertor choice");
                continue;
            }

            Console.WriteLine($"you selected: {selctedOpertorDescrtiption}");
            Console.WriteLine();

            Console.WriteLine(
                $"the range of integers is " +
                $"{int.MinValue} to {int.MaxValue}");

            Console.WriteLine("enter the first intger");
            string FirstNumberInput = Console.ReadLine();
            if (!int.TryParse(FirstNumberInput, out int firstnumber))
            {
                Console.WriteLine($"{FirstNumberInput} could not parsed as integer");
                continue;
            }

            Console.WriteLine("enter the secound intger");
            string SecoundNumberInput = Console.ReadLine();
            if (!int.TryParse(SecoundNumberInput, out int secoundnumber))
            {
                Console.WriteLine($"{SecoundNumberInput} could not parsed as integer");
                continue;
            }

            int result;

            try
            {
                result = ChoosedOpertor switch
                {
                    "+" => firstnumber + secoundnumber,
                    "-" => firstnumber - secoundnumber,
                    "/" => firstnumber / secoundnumber,
                    "x" => firstnumber * secoundnumber,
                    _ => throw new NotSupportedException(
                        $"Arithemtic is not currently supported" +
                        $"for opertor {ChoosedOpertor}")
                };
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("you can not divide by zero");
                continue;
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"there was an unhandeld exception: --> {ex.Message}");
                continue;
            }

            Console.WriteLine($"the result is {result}");
        }
    }
}

//enhne version
// is negative nubmer will be pars correctly or not ?
//is there way that we can change the infinte loop or not?
//while loop 
//addin gother types of errors if found in try catch block
//if number can not get parsed dont get back the first step we can ask the user for another valid numer without goin back to the frist one




// finallyyyyyyyyyyyyyyyyyyyyy finshed this course was really amazing course i learned alot