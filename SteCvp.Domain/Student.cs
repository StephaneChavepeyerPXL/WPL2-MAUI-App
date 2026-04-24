using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteCvp.Domain
{

    public class Student
    {
        private static int _nextID = 1;

        private string _firstName;
        private string _lastName;

        public int ID { get; private set; }

        public string FirstName
        {
            get => _firstName;
            set => _firstName = string.IsNullOrWhiteSpace(value) ? "John" : value;
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = string.IsNullOrWhiteSpace(value) ? "Doe" : value;
        }

        public Student()
        {
            
        }

        public Student(string firstName, string lastName)
        {
            ID = _nextID++;
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }

}
