using System;
    internal class qno5
{ 
    struct Company
    {
        long phone;
        string address;
        string name;
        double salary;
        public Company (long p, string a, string n, double s)
        {
            phone = p;
            address = a;
            name = n;
            salary = s;
        }
        public void display()
        {
            Console.WriteLine("Name is=" +name);
            Console.WriteLine("Phone is="+phone);
            Console.WriteLine("Address is="+address);
            Console.WriteLine("Salary is ="+salary);
        }
    }
    internal class QNO5
    {
        public static void Main(string[] args)
        {
            Company c1 = new Company(9821618660, "Dhangadhi", "Bhupendra Chand", 20000);
            c1.display();
            Console.ReadKey();
        }
    }
}

