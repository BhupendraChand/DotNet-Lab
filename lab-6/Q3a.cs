using System;


    public class Complex
    {
        public int real, img;
        public Complex() { }
        public Complex(int real, int img)
        {
            this.real = real;
            this.img = img;
        }
        public void display()
        {
            Console.WriteLine("real:" + real + "  "+  "img:"+img+ "i");
        }
        public static Complex operator -(Complex C1)
        {
            Complex temp = new Complex();
            temp.real = -C1.real;
            temp.img = -C1.img;
            return temp;
        }
    }
    internal class unary3a
    {
        public static void Main(string[] args)
        {
            Complex C1 = new Complex(11, 12);
            Console.WriteLine("The Complex number = ");
            C1.display();
            Complex c2 = -C1;
            Console.WriteLine("The Negative complex number =");
            c2.display();
            Console.ReadKey();
        }
    }

