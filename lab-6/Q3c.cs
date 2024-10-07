using System;


    class Distance
    {
        public int feet, inch;
        public Distance()
        {

        }
        public Distance(int feet, int inch)
        {
            this.feet = feet;
            this.inch = inch;
        }
        public void display()
        {
            Console.WriteLine("Distance = "+feet+"f"+inch +"inch");
        }
        public static bool operator ==(Distance d1, Distance d2)
        {
            bool status = false;
            int dt1 = d1.feet * 12 + d1.inch;
            int dt2 = d2.feet * 12 + d2.inch;
            if (dt1 == dt2)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            return status;
        }
        public static bool operator !=(Distance d1, Distance d2)
        {
            bool status = false;
            int dt1 = d1.feet * 12 + d1.inch;
            int dt2 = d2.feet * 12 + d2.inch;
            if (dt1 != dt2)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            return status;
        }
    }
    internal class relationaloperator3c
    {
        public static void Main(string[] args)
        {
            Distance d1 = new Distance(5, 6);
            Distance d2 = new Distance(4, 6);
            Console.WriteLine("The Distance are = ");
            d1.display();
            d2.display();
            if (d1 == d2)
            {
                Console.WriteLine("This is two Equal Distances Found.");
            }
            else
            {
                Console.WriteLine("This is two Unequal Distances Found.");
            }
            Console.ReadKey();
        }

    }

