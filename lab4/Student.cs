using System;


    internal class Student
    {
    int roll;
    string name, campus;
    
public Student()
{

}

public Student(int r,string n, string c)
{
    roll = r;
    name = n;
    campus = c;
}
public void display()
{
    Console.WriteLine("Student Roll No =" + roll);
    Console.WriteLine("Student Name=" + name);
    Console.WriteLine("Student Campus=" +campus);
}

}

public class Student1
{
    public static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.display();
        Student s2 = new Student(101,"Ram","RR Campus");
        s2.display();
        Console.ReadKey();
    }
}