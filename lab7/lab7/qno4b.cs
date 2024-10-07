using System;



    internal class qno4b
    {
        public static void Main(string[] args)
        {
            try
            {
                int[] num = new int[5] { 10, 20, 30, 40, 50 };
                Console.WriteLine("The indexoutofrangeexception number is ="+num[4]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("End a program:");
                Console.ReadKey();
            }
        }


    }

