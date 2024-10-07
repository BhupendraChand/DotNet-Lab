using System;

    internal class Program10
    {
       

        public static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3]
            {
                {1,2,3},
                {5,6,7 },
                {8,9,10 }
            };

            int exp = 0;

            int i = 0;
            for (int j = 0; j < matrix.GetLength(0); j++) {
                exp = exp + matrix[i, j] * (matrix[i + 1, (j + 1) % 3] * matrix[i+2, (j+2)%3] - matrix[i+1, (j+2)%3] * matrix[i+2, (j+1)%3]);
            }

            Console.WriteLine(exp);


            

        }
    }

