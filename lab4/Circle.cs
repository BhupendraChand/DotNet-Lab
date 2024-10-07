using System;

    internal class Circle
    {



    private float radius;
    public void setProperty(float r)
    {
        radius = r;
        
    }

    public float findArea()
    {
        return 22/7*radius*radius;
    }

    public float findCircumference()
    {
        return 2*22/7*radius;
    }
}
public class MyCircle
{ 
    public static void Main(string[] args)
    {
        Circle r1 = new Circle();
        r1.setProperty(12);
        float a = r1.findArea();
        float p = r1.findCircumference();
        Console.WriteLine("The Area of Circle  is =" + a);
        Console.WriteLine("The Circumference of Circle  is =" + p);
        Console.ReadKey();
    }
}



