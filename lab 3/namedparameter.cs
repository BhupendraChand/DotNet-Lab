using System;

    internal class namedparameter
    {
        public static int sum(int x, int y, int z )
        {
            Console.WriteLine("x="+x+",\n "+y+",\n "+z);
            return x + y + z;
          
        }
        public static void Main(string[] args)
        {
            int result = sum(2,4,6);
            Console.WriteLine("The  result is:" + result);
            Console.ReadKey();
        }
    }
