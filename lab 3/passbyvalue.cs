using System;

    internal class passbyvalue
    {
        public static void Increment(int p)
        {
            p = p + 1;
            Console.WriteLine("p=" + p);
        }



        public static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the Number=");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Before Call: num=" + num);
            Increment(num);
            Console.WriteLine("After call:num=" + num);
            Console.ReadLine();
        }
    }

