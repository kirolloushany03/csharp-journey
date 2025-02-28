using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal sealed class ArgumentsAndReturnValues
    {
        public void Run()
        {

            //methods with  arguments and return value
            int Add(int a, int b)
            {
                return a + b;
            }

            //calling method
            int sum = Add(1, 2);
            Console.WriteLine(sum);

            //we can call the method like this 

            int x = 2, y = 5;

            int sum2 = Add(x, y);
            Console.WriteLine($"sum2  = {sum2}");

            //also we can call the method kind of nested one 

            int sum3 = Add(Add(1, 2), Add(3, 4));
            Console.WriteLine($"sum3 with nested methods {sum3}");
        }
    }
}
