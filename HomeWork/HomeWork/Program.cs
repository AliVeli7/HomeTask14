using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Student student1 = new Student("NEil","Armstrong",33,99);
            Student student2 = new Student("Jack","Nickolson",19,100);
            Student student3 = new Student("Jack","Sparrov",22,98);
            Student student4 = new Student("Jack", "Sparrov", 22, 90);
            Group group = new Group();
            
            Console.WriteLine(group.No);

            StudentManager student = new StudentManager();


            student.ShowInfo(student1);
            Console.WriteLine("------------");
            
            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);
            group.AddStudent(student4);

            Console.WriteLine("------------");
            group.GetAllStudents();
            Console.WriteLine("------------");
            group.Sort();


        }
    }
}
