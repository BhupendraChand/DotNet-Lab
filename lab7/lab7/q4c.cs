using System;
 
    internal class q4c
    {
        public static void Main(string[] args)
        {
            try
            {
                object obj = 5;
                int n = (short)obj;
                Console.WriteLine(n);
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { 
            Console.WriteLine("End  a Program:"); 
        }
            Console.ReadKey();
        }
    }

