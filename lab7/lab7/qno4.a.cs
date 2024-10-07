using System;

    public class qno4a
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter the any two number:");
                double num1 = double.Parse(Console.ReadLine());
                double num2 = int.Parse(Console.ReadLine());
                double div = num1 / num2;
                Console.WriteLine("divsion of two number:" + div);
            }
            catch (DivideByZeroException ex)
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


