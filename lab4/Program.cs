using System;
using System.Runtime.InteropServices;



internal class Program
{
    int length, width, height;
    public void setProperty(int l, int w, int h)
    {
        length = l;
        width = w;
        height = h;
    }

    public int volume()
    {
        return (length * width * height);
    }
}


public class Test
{
    public static void Main (string[] args)
    {
        Program b1= new Program();
        b1.setProperty(4, 5, 6);
        int v = b1.volume();
        Console.WriteLine("The volume of Box is ="+v);
        Console.ReadKey();
    }
}
