using System;




    public class Shape
    {
        public double d1;
        public double d2;
        public Shape(double d1, double d2)
        {
            this.d1 = d1;
            this.d2 = d2;
        }
        public virtual double Area()
        {
            Console.WriteLine("Undefined Shape");
            return 0;
        }

    }
    public class Triangle : Shape
    {
        public Triangle(double h, double b) : base(h, b) { }
        public override double Area()
        {
            return 0.5 * d1 * d2;
        }
    }
    internal class qno2
    {

        public static void Main(string[] args)
        {
            Triangle t = new Triangle(15, 20);
            Console.WriteLine("The Area of triangle is = " + t.Area());
            Console.ReadKey();

        }
    }

