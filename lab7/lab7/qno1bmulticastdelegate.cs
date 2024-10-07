using System;

    internal class qno1bmulticastdelegate
    {
        public static int Square(int n)
        {
            return n * n;
        }

        public static int Cube(int n)
        {
            return n * n*n;
        }
        public delegate int multidelegate(int a);
        public static void Main(string[] args)
        {
            multidelegate del = new multidelegate(Square);
            int sq = del(5);
            Console.WriteLine("The Square is =" + sq);
            del += Cube;
            Console.WriteLine("The Cube is =" + del(9));
            Console.ReadKey();
        }
    }
