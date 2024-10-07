using System;




    public class  methodoverloading
    {
        public int add(int a, int b, int c)
        {
           return a+ b + c;
        }
        public int add(int a, int b)
        {
           return a+ b;
        }
        public double add(double a, double b)
        {
            return a+ b;
        }
    }
    internal class qno1
    {
        public static void Main(string[] args)
        {
            methodoverloading c = new methodoverloading();
            int x= c.add(11, 12, 13);
            int y=c.add(11, 12);
           double z= c.add(12.8, 13.5);
            Console.WriteLine("The sum of two integers =" + x);
            Console.WriteLine("The sum of three integers ="+y);
            Console.WriteLine("The sum of two float =" + z);
            Console.ReadKey();
        }
    }

