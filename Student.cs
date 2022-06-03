using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamrin5
{
    public class Student : Person
    {
        public Student(string Name, string CourseName, bool IsStudent): base(Name,CourseName, IsStudent)
        {

        }

        



        public void Study()
        {
            Console.WriteLine($"The name is {Name}");
            Console.WriteLine($"The CourseName is {CourseName}");
        }
    }
}
