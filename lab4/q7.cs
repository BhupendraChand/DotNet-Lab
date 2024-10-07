using System;

namespace lab4
{

    namespace RRLC
    {
        public class Qn_7
        {
            public void Display()
            {
                Console.WriteLine("This is namespace.(bhupendra chand)");
            }
        }
    }



    namespace RR_BCA
    {
        class AnotherNameSpace
        {
            public static void Main(String[] args)
            {
                RRLC.Qn_7 myObject = new RRLC.Qn_7();
                myObject.Display();

                Console.ReadKey();
            }
        }
    }
}