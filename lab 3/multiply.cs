using System;

    internal class multiply
    {
        public static void Main(string[] args)
        {
            int[,] mar1 = new int[,] { { 7, 8, 9 }, { 4, 5, 6 }, { 1, 2, 3 } };
            int[,] mar2 = new int[,] { { 4, 5, 6 }, { 7, 8, 9 }, { 1, 2, 3 }};
            
            int[,] mul = new int[3, 3];



            // Multiplication of two matrices
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mul[i, j] = 0; 
                    for (int k = 0; k < 3; k++)
                    {
                        mul[i, j] += mar1[i, k] * mar2[k, j];
                    }
                }
            }
            Console.WriteLine("Multiplication of two matrices:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(mul[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
