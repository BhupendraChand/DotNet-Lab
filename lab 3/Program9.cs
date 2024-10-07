using System;

    {
       

        public static void Main(string[] args)
        {
            int[] arr = { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 40, 50 };

            foreach (int i in arr)
            {
                int flag = 0;

                for (int j = 1; j <= i; j++)
                {
                    if(i%j == 0)
                    {
                        flag++;
                    }
                }

                if (flag == 2)
                {
                    Console.WriteLine(i + " ");
                }

                flag = 0;
            }

        }
    }

