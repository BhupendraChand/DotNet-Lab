using System;


    class Vector
    {
        int x, y;
        public Vector()
        {

        }
        public Vector(int a, int b)
        {
            x = a;
            y = b;
        }
        public void displayVector()
        {
            Console.WriteLine("(" + x + ", " + y + ")");
        }
        public static Vector operator *(Vector v1, Vector v2)
        {
            Vector temp = new Vector();
            temp.x = v1.x * v2.x;
            temp.y = v1.y * v2.y;
            return temp;
        }
        public static Vector operator /(Vector v1, Vector v2)
        {
            Vector temp = new Vector();
            temp.x = v1.x / v2.x;
            temp.y = v1.y / v2.y;
            return temp;
        }
    }
    internal class binaryopeartor3b
    {
        public static void Main(string[] args)
        {
            Vector v1 = new Vector(15, 5);
            Vector v2 = new Vector(9, 3);
            Console.WriteLine("The Initial number are =");
            v1.displayVector();
            v2.displayVector();
            
            Console.WriteLine("After multiplying number are =");
            Vector v3 = v1 * v2;
            v3.displayVector();
      
            Console.WriteLine("After dividing number are = ");
            Vector v4 = v1 / v2;
            v4.displayVector();
          

            Console.ReadKey();
        }

    }

