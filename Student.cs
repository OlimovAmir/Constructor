using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Student
    {
        public Student(string lastName, DateTime birthday)
        {
            _lastName = lastName;
            _birthday = birthday;
        }

        public Student(string lastName, string firstName, string middleName ,DateTime birthday)
        {
            _lastName=lastName;
            _firstName=firstName;
            _middleName=middleName;
            _birthday=birthday;
        }

        public Student(Student student)
        {
            _firstName = student._firstName;
            _middleName = student._middleName;
            _lastName = student._lastName;
            _birthday=student._birthday;
                        
        }
        public void SetLastName(string lastName)
        {
            _lastName = lastName;
        }
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private DateTime _birthday;

        public void Print()
        {
            Console.WriteLine($"Name: {_firstName}\nLastName: {_lastName}\nMiddleName: {_middleName}\nbirthday: {_birthday} ");
        }

    }
}
