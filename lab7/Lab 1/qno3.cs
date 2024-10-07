using System;
public class qno3
{
public static void Main(string []args){
Console.WriteLine("Enter the Number:");

float l=float.Parse(Console.ReadLine());
float b=float.Parse(Console.ReadLine());
 float area=(l*b);
float perimeter=2*(l+b);

Console.WriteLine(" Area of Rectangle is = "+area);

Console.WriteLine(" Perimeter of Rectangle is = "+perimeter);


}
}