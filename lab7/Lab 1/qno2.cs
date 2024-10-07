using System;

    public class qno2
    {
    public static void Main(String []args)
    {
	int num=int.Parse(args[0]);
	int num1=int.Parse(args[1]);
	int sum=num+num1;
	int sub=num-num1;
	int mul=num*num1;
	float div=num/num1;
	Console.WriteLine("The sum of"+num+"and"+num1+"is"+sum);
	Console.WriteLine("The subtraction of"+num+"and"+num1+"is"+sub);
	Console.WriteLine("The multiplication of"+num+"and"+num1+"is"+mul);
	Console.WriteLine("The Divison of"+num+"and"+num1+"is"+div);
		
    }
    }