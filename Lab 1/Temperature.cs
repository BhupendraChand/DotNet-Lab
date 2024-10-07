using System;
public class temperature
{
public static void Main(string []args){
Console.WriteLine("Enter the Celsius:");

float c=float.Parse(Console.ReadLine());
 float fahrenheit=(c*9/5)+32;

Console.WriteLine("The Fahrenheit is = "+fahrenheit);




}
}