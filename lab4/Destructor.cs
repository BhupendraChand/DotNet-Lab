using System;



internal class Destructor
{
    public Destructor()
    {
        Console.WriteLine("Constructor is called");
    }
    ~Destructor()
    {
        Console.WriteLine("Destructor is called");
    }
}

public class Destructor1
{
    public static void MAin(string[] args)
    {
        Destructor d1 = new Destructor();
        Console.ReadKey();
    }
}