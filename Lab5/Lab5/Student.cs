using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Student
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tЗавдання №1\t");
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

            Console.WriteLine("\tЗавдання №2-3\t");
            Faculty faculty = new Faculty();
            faculty.FacultyName("Інформаційних технологій");

            //ініціалізуємо екземпляр вкладеного класу Department
            Faculty.Department department1 = new Faculty.Department();
            department1.DepartmentName("Програмних систем і технологій, " + department1.NumberOfTeachers(10)+", "+ department1.Disciplines(12)+".");
            
            Console.WriteLine();
            Console.WriteLine("\tЗавдання №4\t");
            //визиваєио методи статичного класу
            ClassStatic.ArrayMaxAndMin();
            ClassStatic.Number();
            ClassStatic.MaxAndMin();

        }

        
    }
}
