using System;



    internal class Rectangle

{ 
        int length, breath;
        public void setProperty(int l,  int b)
        {
            length = l;
           breath = b;
        }

        public int Area()
        {
            return (length * breath);
        }

    public int Perimeter()
    {
        return (2*(length + breath));
    }
}


    public class Rectangle1
    {
        public static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.setProperty(10,12);
            int a = r1.Area();
        int p = r1.Perimeter();
        Console.WriteLine("The Area of Rectangle  is =" + a);
        Console.WriteLine("The Perimeter of Rectangle  is =" + p);
        Console.ReadKey();
        }
    }

