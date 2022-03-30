using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class Group
    {

        public static int no = 200;

        public string No { get; private set; }

        public Student[] Students { get; set; }

        Student[] students = new Student[1];
        public Group()
        {
            no+=1;
            no.ToString();
            No = "BP" + no;

        }

        public void Sort()
        {
            int j = 1;
            for (int i = 0; i < Students.Length; i++)
            {
                for (j = 0; j < Students.Length; j++)
                {
                    if (Students[i].Point <= Students[j].Point)
                    {
                        Student student = Students[i];
                        Students[i] = Students[j];
                        Students[j] = student;
                    }
                    
                }
                j = i + 2;
            }

            foreach (Student student in Students)
            {
                Console.WriteLine($"Id: {student.Id} Name:{student.Name} SurName:{student.SurName} Age:{student.Age} Point:{student.Point} ");
            }

        }


        public void AddStudent(Student student)
        {
            
            students[students.Length - 1] = student;
            Students = students;
            Array.Resize(ref students, students.Length + 1);
            Console.WriteLine("Student Added");
            
           

        }


        public void GetAllStudents()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine($"Id: {student.Id} Name:{student.Name} SurName:{student.SurName} Age:{student.Age} Point:{student.Point}");
            }
        }

    }

}


