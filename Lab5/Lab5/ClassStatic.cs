using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Lab5
{
    public static class ClassStatic//статичний клас
    {
        private static double[] arr = new double[4];
        private static int[] numbers = new int[] { 1, 2, 5, 3, 7, 5, 1, 3, 4 };
        private static int[] numarr = new int[] { 4, 5, 2, 3, 8, 7, 6, 1 };

        static ClassStatic()
        {
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Елемент масива: ");
                arr[i] = Convert.ToDouble(Console.ReadLine());
            }
        }
        public static void ArrayMaxAndMin()
        {
            //мінімальний і максимальний елемент через Math
            double maximum = Math.Max(arr.Max(), arr.Min());
            Console.WriteLine("Максимальний елемент масиву: " + maximum);
            double minimum = Math.Min(arr.Min(), arr.Max());
            Console.WriteLine("Мінімальний елемент масиву: " + minimum);
        }

        //лінійних пошук
        public static void Number()
        {
            int k = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                k++;
            }
            Console.WriteLine("Кількість вказаних цифр: " + k);
        }

        //максимальний і мінімальний елемент -> через лінійний пошук
        public static void MaxAndMin()
        {
            int max = numarr[0];
            for (int i = 0; i < numarr.Length; i++)
            {
                if (max < numarr[i])
                {
                    max = numarr[i];
                }
            }
            Console.WriteLine("Максимальний елемент масиву: " + max);
            int min = numarr[0];
            for (int i = 0; i < numarr.Length; i++)
            {
                if (min > numarr[i])
                {
                    min =  numarr[i];
                }
            }
            Console.WriteLine("Мінімальний елемент масиву: " + min);
        }

    }
}
