using System;



    internal class jaggedarray
    {
        public static void Main(string[] args)
        {
            int[][] num = new int[][]
            {
                new int[] { 1, 2, 3, 5 },
                new int[] { 7, 8 },
                new int[] { 4, 6, 9 }
            };

            Console.WriteLine("The Jagged Array is:");
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num[i].Length; j++)
                {
                    Console.Write(num[i][j] + " ");
                }
                Console.WriteLine();
            }

           Console.ReadKey();
        }
    }
