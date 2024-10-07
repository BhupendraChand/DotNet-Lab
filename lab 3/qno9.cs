using System;

    internal class qno9 { 
    public static void Main (String[] args)
{
    int[] arr = { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 45, 55 };

            foreach (int i in arr)
            {
                int flag = 0;

                for (int j = 1; j <= i; j++)
                {
                    if(i%j == 0)
                    {
                        flag++;
                    }
                }

                if (flag == 2)
{
    Console.WriteLine("The Sum of Prime Element is:"+i + " ");
}

flag = 0;
            }
        Console.ReadKey();
        }
    }
