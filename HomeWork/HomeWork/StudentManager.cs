using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class StudentManager
    {
        public void ShowInfo(Student student)
        {
           
                Console.WriteLine($"Id: {student.Id} Name:{student.Name} SurName:{student.SurName} Age:{student.Age} Point:{student.Point}");
            


        }
    }
}
