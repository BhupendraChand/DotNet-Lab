using System;


internal class Employee
{
    int eid;
    string ename;
    static string company;

    public Employee(int id, string name)
    {
        eid = id;
        ename = name;

    }

    static Employee()
    {
        company = "RR Campus";
    }

    public void display()
    {
        Console.WriteLine("Employee Id =" + eid);
        Console.WriteLine("Employee Name =" + ename);
        Console.WriteLine("Employee Company =" + company);
    }


    internal class staticconstEx
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee(105, "Romeo");
            e1.display();
            Console.ReadKey();
        }
    }
}