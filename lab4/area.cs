using System;
    internal class area

{ 
   private float height,depth,width;
public void setProperty(float h, float d, float w )
{
        height = h;
        depth = d;
        width = w;
}
public float Volume()
{
return height * depth* width ;
}

public float SurfaceArea()
{
return  2*width*height+height*depth+width*depth;
}
}

public class Box
{
    public static void Main(string[] args)
    {
        area r1 = new area();
        r1.setProperty(12,10,2);
        float v = r1.Volume();
        float s = r1.SurfaceArea();
        Console.WriteLine("The Volume of Box is =" + v);
        Console.WriteLine("The Surface Area of Box is =" + s);
        Console.ReadKey();
    }
}



