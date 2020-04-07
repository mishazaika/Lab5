using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class St_Assesment
    {
        private Random random = new Random();
        private int[,] arrRating = new int[9, 9];
        private int sum;
        private int k;

        public St_Assesment()
        {
            Console.OutputEncoding = Encoding.UTF8;
            sum = 0;
            k = 81;
        }

        public void StRating()
        {
            for(int i = 0; i< 9;  i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    arrRating[i, j] = random.Next(46, 100);
                }
            }
        }

        public void MyRating()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)

                    Console.Write(arrRating[i, j] + " ");
                Console.WriteLine();
            }

            Console.WriteLine("__________________________");

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)

                    sum += arrRating[i, j];
            }
            sum = sum / k;
            Console.WriteLine("Середній рейтинг за семестр: " + Convert.ToString(sum));
            Console.WriteLine();

        }
    }
}
