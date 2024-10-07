using System;
public class qno5
{
public static void Main(string []args){
Console.WriteLine("Enter the Number:");

float p=float.Parse(Console.ReadLine());
float t=float.Parse(Console.ReadLine());

float r=float.Parse(Console.ReadLine());

 float simpleinterest=(p*t*r)/100;

Console.WriteLine("The Simple Interest is = "+simpleinterest);




}
}