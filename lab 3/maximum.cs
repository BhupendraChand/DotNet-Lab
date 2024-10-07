using System;

internal class maximun
{
    public static void Main(string[] args)
    {
        
        
            int[] arr = { 13, 12, 22, 11, 18, 76, 85, 55, 128 };

            int maximum = arr[0];
            int minimum = arr[1];

            foreach (int i in arr)
            {
                if (i > maximum)
                {
                    maximum = i;
                }
                if (i < minimum)
                {
                    minimum = i;
                }
            }

            Console.WriteLine("Maximum Number is : " + maximum);
            Console.WriteLine("Minimum Number is : " + minimum);
        Console.ReadKey();
    }
        

    }

