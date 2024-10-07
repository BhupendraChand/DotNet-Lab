using System;
public class calculate
{
public static void Main(string []args){
Console.WriteLine("Enter the Number:");
float num1=float.Parse(Console.ReadLine());
float num2=float.Parse(Console.ReadLine());
 float add=num1+num2;
float subtract=num1-num2;
float multiply=num1*num2;
float division=num1/num2;

Console.WriteLine("The Addition is ="+add);
Console.WriteLine("The Subtraction is ="+subtract);
Console.WriteLine("The Multiply is ="+multiply);
Console.WriteLine("The Division is ="+division);



}
}