using System;

    internal class paramas
    {
        public static int add(int x, params int[] num)
        {
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }
            sum += x;
            return sum;
        }
        public static void Main(string[] args)
        {
            int result = add(11, 12, 13, 14, 15, 16, 17, 18);
            Console.WriteLine("The  result is:" + result);
            Console.ReadKey();
        }
    }
