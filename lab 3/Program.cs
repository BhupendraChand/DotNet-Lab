using System;

    internal class Program
{
       
            public static void Main(string[] args)
    {
        int[,] matrix = {
                { 2, 3, 4 },
                { 5, 6, 7 },
                { 8, 9, 10 }
            };
        int sum = 0;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i == j)
                {
                    sum += matrix[i, j];
                }
            }
        }

        Console.WriteLine("Sum of diagonals : " + sum);
    }

}
    
