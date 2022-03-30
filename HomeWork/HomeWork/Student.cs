using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class Student:Group
    { 
        private static int _id=1;
        public int Id { get; private set; }
        public string Name;
        public string SurName;
        public int Age;
        public double Point;

        

        public Student(string name,string surName,int age, double point)
        {
            
            Id = _id++;
            Name = name;
            SurName = surName;
            Age = age;
            Point = point;


        }

        public Student()
        {
        }
    }
}
