using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamrin5
{
    public class Teacher : Person
    {
        public Teacher(string Name, string CourseName, bool IsStudent) : base(Name, CourseName,IsStudent)
        {

        }

        public void Explain()
        {
            Console.WriteLine($"The name is {Name}");
            Console.WriteLine($"The FamilyName is {CourseName}");
        }
    }
}
