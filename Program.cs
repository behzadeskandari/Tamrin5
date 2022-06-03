using System;
using System.Collections.Generic;

namespace Tamrin5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter Arz");
            //int Arz = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Tooal");
            //int Tooal = Convert.ToInt32(Console.ReadLine());


            //Rectangle rectangle = new Rectangle(Tooal,Arz,true);

            //rectangle.GetResults();

            //Console.WriteLine(rectangle.Masahat);
            
            
            
            List<Teacher> Teacherlst = new List<Teacher>();
            List<Student> studentlst = new List<Student>();

            for (int i = 0; i < 6; i++)
            {
               
                if (i == 0)
                {
                    Console.WriteLine("Enter ostad");

                    string OsatadName = Console.ReadLine();

                    Console.WriteLine("Enter Course Name");

                    string CourseName = Console.ReadLine();

                    Teacher teacher = new Teacher(OsatadName, CourseName, false);
                   
                  //  teacher.Explain();
                   
                    Teacherlst.Add(teacher);
                }
                else
                {
                    Console.WriteLine("Enter Student");

                    string OsatadName = Console.ReadLine();

                    Console.WriteLine("Enter Student Course Name");

                    string CourseName = Console.ReadLine();

                    Student student = new Student(OsatadName, CourseName, true);
                    
                //    student.Study();

                    studentlst.Add(student);

                }
                    
            }

            foreach (var item2 in Teacherlst)
            {
                Console.WriteLine($"The Teacher Name is {item2.Name}");
                Console.WriteLine($"The Course Name is {item2.CourseName}");
                Console.WriteLine($"Is Student {item2.IsStudent}");
                Console.WriteLine("-----------------------------------------------");
            }

            foreach (var item in studentlst)
            {
                Console.WriteLine($"The Name Is {item.Name}");
                Console.WriteLine($"The Course Name Is {item.CourseName}");
                Console.WriteLine($"Is Student {item.IsStudent}");
                Console.WriteLine("-----------------------------------------------");

            }



        }
    }
}
