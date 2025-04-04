using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal sealed class Listsdemo
    {
        public static void Runcode() 
        {


            //List
            //-- Lists are zero based
            //-- dynamic in size
            //-- get values from list 
            //--set values to list
            //--add values
            //--remove values
            //--insert values to list
            //--clear list
            //--sort a list


            List<string> laptop = new List<string>();
            //List<string> laptop = new(); // OR

            laptop.Add("processor");
            laptop.Add("gpu");
            laptop.Add("ram");
            laptop.Add("hard");
            laptop.Add("screen");

            Console.WriteLine($"{string.Join(",\n", laptop)}\n-->Original list ");


            laptop.Remove("gpu");
            Console.WriteLine("=======================");
            Console.WriteLine($"{string.Join(",\n", laptop)}\n-->after removing gpu ");
            Console.WriteLine("=======================");

            laptop[1] = "camera"; //add with index override means it remove thevalue and put the new one
            Console.WriteLine($"{string.Join(",\n", laptop)}\n-->after putting camer in postion 1 ");
            Console.WriteLine("=======================");

            laptop.Insert(0, "koko");
            Console.WriteLine($"{string.Join(",\n", laptop)}\n-->after inserting koko in postion 0 ");



            List<int> numbers = new List<int>
            {
                1,2,3,4,5,6,7
            };
            Console.WriteLine("=======================");
            Console.WriteLine($"{numbers.Count} -->count the original one");
            Console.WriteLine($"{string.Join(",", numbers)} --> oringial one\n");

            numbers.Remove(2); //putting the value you want to remove not the index
            Console.WriteLine($"{numbers.Count} -->count after removing the value 2");
            Console.WriteLine($"{string.Join(",", numbers)} --> count after removing the value 2\n");

            // inserting here is not override i mean not remove the value at the postion
            // but it move all one space to rigth and put the value we want in the postion we want
            numbers.Insert(0, 88);
            Console.WriteLine($"{string.Join(",", numbers)} --> after inserting 88 in postion 0\n");


            numbers.Reverse();
            Console.WriteLine($"{string.Join(",", numbers)} --> reversed\n");

            numbers.Sort();

            Console.WriteLine($"{string.Join(",", numbers)} --> sorted\n");

            numbers.Clear();
            if (numbers.Count == 0 || numbers.Count < 0)
            {
                Console.WriteLine("the list is empty try to inputt some data in it");
                //Console.WriteLine(string.Join(",", numbers));

            }

        }
    }
}
