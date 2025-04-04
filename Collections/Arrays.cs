internal sealed class Arrays
{
    public void RunExample() 
    { 
        //Arrays
        //-- zero based
        //-- fixed size
        //--we can set and get values from array
        //--fixed size
        //--we can get values from an array
        //--we can set values to array


        //decalartion
        int[] numbers = new int[3];//integer_array name_of_array = make_new_array ingert[size of array] 


        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;


        //decalre and initialize an arry

        int[] number2 = new int[5]
            {
                5,6,7,8,9
            };

        int[] number3 = new int[5]
        {
            1,
            2,
            3,
            4,
            5
        };

        int[] number4 = new int[2]
            {
                14,
                16
            };

        Console.WriteLine($"so the lengith of number4 array is {number4.Length}");

    /*//revice on arrays buy finid the first and second and third biggest one in array
        static void bigsec(int[] arr)
        {
            int biggest = 0, secbig = 0, thirdbiggest = 0;

            foreach (int i in arr)
            {
                if (i > biggest)
                {
                    thirdbiggest = secbig;
                    secbig = biggest;
                    biggest = i;

                }

            }
            Console.WriteLine($"this biggest num is {biggest}");
            Console.WriteLine($"this secound biggest num is {secbig}");
            Console.WriteLine($"this third biggest num is {thirdbiggest}");
        }

        bigsec([2, 2, 3, 1]);*/
    }
}
