using System;

    internal class qno2b
    {
        public delegate int multiplydelegate(int a, int b);
        public static void Main(string[] args)
        {
            multiplydelegate del = (a, b) => a * b;
            int res = del(6, 9);
            Console.WriteLine("The lembda Multiply is="+res);
            Console.ReadKey();

        }
    }
