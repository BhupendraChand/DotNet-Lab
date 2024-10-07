using System;

public struct StructureBook
{
    int bid;
    string title;
    double price;

    
    public void SetProperty(int id, string n, double p)
    {
        bid = id;
        title = n;
        price = p;
    }

    public void Display()
    {
        Console.WriteLine("Book Id = " + bid);
        Console.WriteLine("Book Title = " + title);
        Console.WriteLine("Book Price = " + price);
    }
}

public class Book
{
    public static void Main(string[] args)
    {
        StructureBook b1 = new StructureBook();
        b1.SetProperty(1005, "C# programming language", 508);
        b1.Display();
        Console.ReadKey();
    }
}
