using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd
{
    internal class prime
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());
            if (num / 2 == 0)
            {
                Console.WriteLine("The given number is Prime Number.");
            }
            else
            {
                Console.WriteLine("The given number is not a Prime Number.");
            }
            Console.ReadKey();

        }
    }
}
