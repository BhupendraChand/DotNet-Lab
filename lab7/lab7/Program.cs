using System;

    internal class Program
    {
        public static int Square(int n)
        {
            return n * n;
        }
        public delegate int delegateSqurae(int a);
        public static void Main(string[] args)
        {
            delegateSqurae del = new delegateSqurae(Square);
            int res = del(5);
            Console.WriteLine("The Square is ="+res);
            Console.ReadKey();
        }
    }
