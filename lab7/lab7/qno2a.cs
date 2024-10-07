using System;

    internal class qno2a
    {

        public delegate int adddelegate(int a, int b);
        public static void Main(string[] args)
        {
            adddelegate del = delegate (int a, int b)
            {

                return a + b;
            };
            Console.WriteLine("The Anonymous Addition of two number is =" + del(4, 6));
            Console.ReadKey();
        }
        
    }

