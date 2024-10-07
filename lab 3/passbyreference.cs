using System;

    internal class passbyreference
    {
        public static void Increment(ref int p)
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
                Increment( ref num);
                Console.WriteLine("After call:num=" + num);
                Console.ReadLine();
            }
        }
    
