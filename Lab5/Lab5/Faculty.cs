using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Faculty
    {
        protected  Department dep1 = new Department();
        protected  Department dep2 = new Department();

        public void FacultyName(string fName)
        {
            Console.WriteLine("Факультет: " + fName + ".");
        }

        //клас Department -> вкладений 
        //перша частина класу Department
        public partial class Department//partial -> ключове слово для розбиття класу
        {

            public void DepartmentName(string name)
            {
                Console.WriteLine("Кафедри: " + name);
            }

        }

        //друга частина класу Department
        public partial class Department
        {
            public string Disciplines(int disciplines)
            {
                return Convert.ToString(disciplines) + " нормативних дисциплін";
            }

            public string NumberOfTeachers(int teachers)
            {
                return Convert.ToString(teachers) + " викладачів";
            }
        }
    }
}
