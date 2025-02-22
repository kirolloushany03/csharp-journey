using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal sealed class Dict
    {
        public void RunDic() 
        {
            //Dictionaries
            // - we can get values   (by key)
            // - we can set values   (by key)
            // - we can add values   (by key)
            // - we can remove  values
            // - we can clear dictionary
            // - we can check if the dictionary contains specific key
            // -- in dictionary -- 
            // - keys  are unique
            // - values not need to be unique
            // - key don't need to be integers

            //Decalre a dictionary
            Dictionary<int, string> numberwords = new();
            Dictionary<string, int> wordsnumbers = new Dictionary<string, int>();
            Dictionary<int, bool> numbersbool = new();

            numberwords.Add(1, "kk");
            numberwords.Add(2, "lk");

            wordsnumbers.Add("one", 22);
            wordsnumbers.Add("two", 23);

            //getting values by keys
            int one = wordsnumbers["one"]; //and here the value will be integer thats why type of variable int
            string two = numberwords[1]; // also here the value will be string thats why type of varaibel string
            Console.WriteLine(one);
            Console.WriteLine(two);

            numberwords.Add(22, "koko");
            wordsnumbers.Add("soso", 22);


            //decalre and instilizing dictionary
            Dictionary<string, int> WordsToNumbers2 = new Dictionary<string, int>
                {
                    {"one", 12 },
                    {"two", 13 },
                    {"three", 14 }
                };

            Dictionary<int, string> NumbersToWords = new Dictionary<int, string>
            {
                //{1 , "one" }, //Or
                //{44 , "two" },
                [1] = "one",
                [2] = "two",
                [4] = "three",
                [3] = "three"
            };

            Console.WriteLine($"thisteh NumbersTowrods -->{string.Join("|", NumbersToWords)}");

            //count the dictionary will give you the numbers of pairs
            Console.WriteLine($"the count of NumbersToWords {NumbersToWords.Count}");


            //check if key in dictionary
            Console.WriteLine(NumbersToWords.ContainsKey(3));

            //we check and get the value at the same time from dictionary andgive 
            bool contains2 = NumbersToWords.TryGetValue(55, out string? value);
            Console.WriteLine(contains2);


            Console.WriteLine(string.Join("--", wordsnumbers));

            //will be safer to edit and override the value
            wordsnumbers["one"] = 23;
            Console.WriteLine(string.Join("--", wordsnumbers));

        }
    }
}
