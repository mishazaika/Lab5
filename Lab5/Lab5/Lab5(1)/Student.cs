using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Student
    {
        static void Main(string[] args)
        {
            St_Assesment straight1 = new St_Assesment();
            St_Assesment straight2 = new St_Assesment();

            Console.WriteLine("\tПерший семестр\t");
            Console.WriteLine("__________________________");
            straight1.StRating();
            straight1.MyRating();

            Console.WriteLine("\tДругий семестр\t");
            Console.WriteLine("__________________________");
            straight2.StRating();
            straight2.MyRating();

        }

        
    }
}
