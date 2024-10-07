using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6
{
    internal class qno4b
    {
        public static void Main(string[] args)
        {
            Stack st = new Stack();


            st.Push("One");
            st.Push("Two");
            st.Push("Three");

            foreach (var elem in st)
            {
                Console.WriteLine(elem);
            }
            Console.ReadKey();
        }
    }
}
