using System;


    internal class sumodd
{
    
        
    public static void Main(string[] args) { 
            int[] arr = { 14, 15, 16, 17, 18, 19, 30, 40, 50 };

    int sum = 0;
            for (int i = 0; i<arr.Length; i++) {
                if(arr[i]%2 != 0) { sum += arr[i];
                Console.WriteLine(arr[i]); }
                
            }

            Console.WriteLine("Sum of Odd Number are  : " + sum);
        Console.ReadKey();
    }
   

    }


