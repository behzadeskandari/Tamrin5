using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamrin5
{
    public class Person
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _courseName;

        public string CourseName
        {
            get { return _courseName; }
            set { _courseName = value; }
        }

        public Person(string Name,string CourseName,bool IsStudent)
        {
            this.Name = Name;
            this.CourseName = CourseName;
            this.IsStudent = IsStudent;
        }

        private bool _isStudent;

        public bool IsStudent
        {
            get { return _isStudent; }
            set { _isStudent = value; }
        }

    }
}
