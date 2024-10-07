using System;

    internal class optional
    {
        public static int multiplication(int x, int y = 5)
        {
            return x * y;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int result1 = multiplication(a, b);
            int result2 = multiplication(a);
            Console.WriteLine("Result1=" + result1);
            Console.WriteLine("Result2=" + result2);
            Console.ReadKey();

        }
    }

